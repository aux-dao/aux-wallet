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

namespace AuxCore
{
    public class LightAccount
    {
        private readonly LightWallet wallet;
        public UInt160 ScriptHash { get; set; }
        private readonly string nep2key;
        private KeyPair key;
        public Contract Contract;
        public bool Decrypted => nep2key == null || key != null;
        public bool HasKey => nep2key != null;
        public LightAccount(UInt160 scriptHash)
        {
            this.ScriptHash = scriptHash;
        }
        public LightAccount(LightWallet wallet, UInt160 scriptHash, string nep2key = null)
            : this(scriptHash)
        {
            this.wallet = wallet;
            this.nep2key = nep2key;
        }

        public LightAccount(LightWallet wallet, UInt160 scriptHash, KeyPair key, string password)
            : this(wallet, scriptHash, key.Export(password, wallet.Scrypt.N, wallet.Scrypt.R, wallet.Scrypt.P))
        {
            this.key = key;
        }
        public KeyPair GetKey()
        {
            if (nep2key == null) return null;
            if (key == null)
            {
                key = wallet.DecryptKey(nep2key);
            }
            return key;
        }

        public KeyPair GetKey(string password)
        {
            if (nep2key == null) return null;
            if (key == null)
            {
                key = new KeyPair(Wallet.GetPrivateKeyFromNEP2(nep2key, password, wallet.Scrypt.N, wallet.Scrypt.R, wallet.Scrypt.P));
            }
            return key;
        }



        public bool VerifyPassword(string password)
        {
            try
            {
                Wallet.GetPrivateKeyFromNEP2(nep2key, password, wallet.Scrypt.N, wallet.Scrypt.R, wallet.Scrypt.P);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public static LightAccount FromJson(JObject json, LightWallet wallet)
        {
            return new LightAccount(wallet, json["address"].AsString().ToScriptHash(), json["key"]?.AsString())
            {
                Contract = NEP6Contract.FromJson(json["contract"])
            };
        }
        public JObject ToJson()
        {
            JObject account = new JObject();
            account["address"] = ScriptHash.ToAddress();
            account["key"] = nep2key;
            account["contract"] = ((NEP6Contract)Contract)?.ToJson();
            return account;
        }
    }
}
