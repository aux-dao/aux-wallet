using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using OX;
using OX.IO.Json;
using OX.Network.P2P.Payloads;
using OX.Wallets;
using OX.Wallets.NEP6;
using OX.SmartContract;
using OX.VM;
using OX.Cryptography.ECC;

namespace AuxCore
{
    public class AUXContractParametersContext
    {
        private UInt160[] WaitWitnesses;
        private class ContextItem
        {
            public byte[] Script;
            public ContractParameter[] Parameters;
            public Dictionary<ECPoint, byte[]> Signatures;

            private ContextItem() { }

            public ContextItem(Contract contract)
            {
                this.Script = contract.Script;
                this.Parameters = contract.ParameterList.Select(p => new ContractParameter { Type = p }).ToArray();
            }

            public static ContextItem FromJson(JObject json)
            {
                return new ContextItem
                {
                    Script = json["script"]?.AsString().HexToBytes(),
                    Parameters = ((JArray)json["parameters"]).Select(p => ContractParameter.FromJson(p)).ToArray(),
                    Signatures = json["signatures"]?.Properties.Select(p => new
                    {
                        PublicKey = ECPoint.Parse(p.Key, ECCurve.Secp256r1),
                        Signature = p.Value.AsString().HexToBytes()
                    }).ToDictionary(p => p.PublicKey, p => p.Signature)
                };
            }

            public JObject ToJson()
            {
                JObject json = new JObject();
                if (Script != null)
                    json["script"] = Script.ToHexString();
                json["parameters"] = new JArray(Parameters.Select(p => p.ToJson()));
                if (Signatures != null)
                {
                    json["signatures"] = new JObject();
                    foreach (var signature in Signatures)
                        json["signatures"][signature.Key.ToString()] = signature.Value.ToHexString();
                }
                return json;
            }
        }

        public readonly IVerifiable Verifiable;
        private readonly Dictionary<UInt160, ContextItem> ContextItems;

        public bool Completed
        {
            get
            {
                if (ContextItems.Count < WaitWitnesses.Length)
                    return false;
                return ContextItems.Values.All(p => p != null && p.Parameters.All(q => q.Value != null));
            }
        }


        public AUXContractParametersContext(IVerifiable verifiable, UInt160[] waitwitnesses)
        {
            this.Verifiable = verifiable;
            this.WaitWitnesses = waitwitnesses;
            this.ContextItems = new Dictionary<UInt160, ContextItem>();
        }

        public bool Add(Contract contract, int index, object parameter)
        {
            ContextItem item = CreateItem(contract);
            if (item == null) return false;
            item.Parameters[index].Value = parameter;
            return true;
        }

        public bool AddSignature(Contract contract, ECPoint pubkey, byte[] signature)
        {
            if (contract.Script.IsMultiSigContract())
            {
                ContextItem item = CreateItem(contract);
                if (item == null) return false;
                if (item.Parameters.All(p => p.Value != null)) return false;
                if (item.Signatures == null)
                    item.Signatures = new Dictionary<ECPoint, byte[]>();
                else if (item.Signatures.ContainsKey(pubkey))
                    return false;
                List<ECPoint> points = new List<ECPoint>();
                {
                    int i = 0;
                    switch (contract.Script[i++])
                    {
                        case 1:
                            ++i;
                            break;
                        case 2:
                            i += 2;
                            break;
                    }
                    while (contract.Script[i++] == 33)
                    {
                        points.Add(ECPoint.DecodePoint(contract.Script.Skip(i).Take(33).ToArray(), ECCurve.Secp256r1));
                        i += 33;
                    }
                }
                if (!points.Contains(pubkey)) return false;
                item.Signatures.Add(pubkey, signature);
                if (item.Signatures.Count == contract.ParameterList.Length)
                {
                    Dictionary<ECPoint, int> dic = points.Select((p, i) => new
                    {
                        PublicKey = p,
                        Index = i
                    }).ToDictionary(p => p.PublicKey, p => p.Index);
                    byte[][] sigs = item.Signatures.Select(p => new
                    {
                        Signature = p.Value,
                        Index = dic[p.Key]
                    }).OrderByDescending(p => p.Index).Select(p => p.Signature).ToArray();
                    for (int i = 0; i < sigs.Length; i++)
                        if (!Add(contract, i, sigs[i]))
                            throw new InvalidOperationException();
                    item.Signatures = null;
                }
                return true;
            }
            else
            {
                int index = -1;
                for (int i = 0; i < contract.ParameterList.Length; i++)
                    if (contract.ParameterList[i] == ContractParameterType.Signature)
                        if (index >= 0)
                            throw new NotSupportedException();
                        else
                            index = i;

                if (index == -1)
                {
                    // unable to find ContractParameterType.Signature in contract.ParameterList 
                    // return now to prevent array index out of bounds exception
                    return false;
                }
                return Add(contract, index, signature);
            }
        }

        private ContextItem CreateItem(Contract contract)
        {
            if (ContextItems.TryGetValue(contract.ScriptHash, out ContextItem item))
                return item;
            item = new ContextItem(contract);
            ContextItems.Add(contract.ScriptHash, item);
            return item;
        }



        public ContractParameter GetParameter(UInt160 scriptHash, int index)
        {
            return GetParameters(scriptHash)?[index];
        }

        public IReadOnlyList<ContractParameter> GetParameters(UInt160 scriptHash)
        {
            if (!ContextItems.TryGetValue(scriptHash, out ContextItem item))
                return null;
            return item.Parameters;
        }

        public Witness[] GetWitnesses()
        {
            if (!Completed) throw new InvalidOperationException();
            Witness[] witnesses = new Witness[this.WaitWitnesses.Length];
            for (int i = 0; i < this.WaitWitnesses.Length; i++)
            {
                ContextItem item = ContextItems[this.WaitWitnesses[i]];
                using (ScriptBuilder sb = new ScriptBuilder())
                {
                    foreach (ContractParameter parameter in item.Parameters.Reverse())
                    {
                        sb.EmitPush(parameter);
                    }
                    witnesses[i] = new Witness
                    {
                        InvocationScript = sb.ToArray(),
                        VerificationScript = item.Script ?? new byte[0]
                    };
                }
            }
            return witnesses;
        }


    }
    public class ContractTransactionHelper
    {
        ContractTransaction CT;
        LightAccount Account;
        public ContractTransactionHelper(ContractTransaction ct, LightAccount account)
        {
            this.CT = ct;
            this.Account = account;
        }
        public ContractTransaction Build()
        {
            AUXContractParametersContext context;
            try
            {
                context = new AUXContractParametersContext(this.CT, new UInt160[] { this.Account.ScriptHash });
            }
            catch (InvalidOperationException)
            {
                return default(ContractTransaction);
            }
            if (Sign(context) && context.Completed)
            {
                if (context.Verifiable is ContractTransaction ct)
                {
                    ct.Witnesses = context.GetWitnesses();
                    return ct;
                }
            }
            return default(ContractTransaction);
        }
        public virtual bool Sign(AUXContractParametersContext context)
        {
            bool fSuccess = false;
            byte[] sg = context.Verifiable.Sign(this.Account.GetKey());
            fSuccess |= context.AddSignature(this.Account.Contract, this.Account.GetKey().PublicKey, sg);
            return fSuccess;
        }
    }
    public class LockAssetTransactionHelper
    {
        LockAssetTransaction LAT;
        LightAccount Account;
        public LockAssetTransactionHelper(LockAssetTransaction lat, LightAccount account)
        {
            this.LAT = lat;
            this.Account = account;
        }
        public LockAssetTransaction Build()
        {
            AUXContractParametersContext context;
            try
            {
                context = new AUXContractParametersContext(this.LAT, new UInt160[] { this.Account.ScriptHash });
            }
            catch (InvalidOperationException)
            {
                return default(LockAssetTransaction);
            }
            if (Sign(context) && context.Completed)
            {
                if (context.Verifiable is LockAssetTransaction ct)
                {
                    ct.Witnesses = context.GetWitnesses();
                    return ct;
                }
            }
            return default(LockAssetTransaction);
        }
        public virtual bool Sign(AUXContractParametersContext context)
        {
            bool fSuccess = false;
            byte[] sg = context.Verifiable.Sign(this.Account.GetKey());
            fSuccess |= context.AddSignature(this.Account.Contract, this.Account.GetKey().PublicKey, sg);
            return fSuccess;
        }
    }
    public class ClaimTransactionHelper
    {
        ClaimTransaction CT;
        LightAccount Account;
        public ClaimTransactionHelper(ClaimTransaction ct, LightAccount account)
        {
            this.CT = ct;
            this.Account = account;
        }
        public ClaimTransaction Build()
        {
            AUXContractParametersContext context;
            try
            {
                context = new AUXContractParametersContext(this.CT, new UInt160[] { this.Account.ScriptHash });
            }
            catch (InvalidOperationException)
            {
                return default(ClaimTransaction);
            }
            if (Sign(context) && context.Completed)
            {
                if (context.Verifiable is ClaimTransaction ct)
                {
                    ct.Witnesses = context.GetWitnesses();
                    return ct;
                }
            }
            return default(ClaimTransaction);
        }
        public virtual bool Sign(AUXContractParametersContext context)
        {
            bool fSuccess = false;
            byte[] sg = context.Verifiable.Sign(this.Account.GetKey());
            fSuccess |= context.AddSignature(this.Account.Contract, this.Account.GetKey().PublicKey, sg);
            return fSuccess;
        }
    }
}
