using OX;
using OX.IO.Json;
using OX.Ledger;
using OX.Persistence;
using OX.SmartContract;
using OX.Wallets;
using OX.Wallets.NEP6;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AuxCore
{
    public class LightWallet
    {
        protected readonly string path;
        public readonly ScryptParameters Scrypt;
        protected string password;
        protected JObject wallet;
        public readonly Dictionary<UInt160, LightAccount> accounts;
        public readonly Dictionary<UInt160, LightContact> contacts;
        public LightWallet(string walletPath)
        {
            this.path = walletPath;
            this.Scrypt = ScryptParameters.Default;
            this.accounts = new Dictionary<UInt160, LightAccount>();
            this.contacts = new Dictionary<UInt160, LightContact>();
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    wallet = JObject.Parse(reader);
                }
                this.Scrypt = ScryptParameters.FromJson(wallet["scrypt"]);
                this.accounts = ((JArray)wallet["accounts"]).Select(p => LightAccount.FromJson(p, this)).ToDictionary(p => p.ScriptHash);
                var w = wallet["contacts"];
                if (w.IsNotNull())
                {
                    this.contacts = ((JArray)w).Select(p => LightContact.FromJson(p)).ToDictionary(p => p.Address);
                }
            }
        }
        public LightAccount CreateAccount()
        {
            byte[] privateKey = new byte[32];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(privateKey);
            }
            LightAccount account = CreateAccount(privateKey);
            Array.Clear(privateKey, 0, privateKey.Length);
            return account;
        }
        public LightAccount CreateAccount(byte[] privateKey)
        {
            KeyPair key = new KeyPair(privateKey);
            NEP6Contract contract = new NEP6Contract
            {
                Script = Contract.CreateSignatureRedeemScript(key.PublicKey),
                ParameterList = new[] { ContractParameterType.Signature },
                ParameterNames = new[] { "signature" },
                Deployed = false
            };
            LightAccount account = new LightAccount(this, contract.ScriptHash, key, password)
            {
                Contract = contract
            };
            AddAccount(account, false);
            return account;
        }
        public LightAccount Import(string wif)
        {
            KeyPair key = new KeyPair(Wallet.GetPrivateKeyFromWIF(wif));
            NEP6Contract contract = new NEP6Contract
            {
                Script = Contract.CreateSignatureRedeemScript(key.PublicKey),
                ParameterList = new[] { ContractParameterType.Signature },
                ParameterNames = new[] { "signature" },
                Deployed = false
            };
            LightAccount account = new LightAccount(this, contract.ScriptHash, key, password)
            {
                Contract = contract
            };
            AddAccount(account, true);
            return account;
        }
        private void AddAccount(LightAccount account, bool is_import)
        {
            lock (accounts)
            {
                //bool ok = false;
                if (accounts.TryGetValue(account.ScriptHash, out LightAccount account_old))
                {
                    if (account.Contract == null)
                    {
                        account.Contract = account_old.Contract;
                    }
                    else
                    {
                        NEP6Contract contract_old = (NEP6Contract)account_old.Contract;
                        if (contract_old != null)
                        {
                            NEP6Contract contract = (NEP6Contract)account.Contract;
                            contract.ParameterNames = contract_old.ParameterNames;
                            contract.Deployed = contract_old.Deployed;
                        }
                    }
                }
                accounts[account.ScriptHash] = account;
            }
        }
        public virtual bool AddContact(LightContact contact)
        {
            lock (contacts)
            {
                if (!contacts.ContainsKey(contact.Address))
                {
                    contacts[contact.Address] = contact;
                    return true;
                }
                return false;
            }
        }
        public virtual bool DeleteContact(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
                return false;
            UInt160 sh = default;
            try
            {
                sh = OX.Wallets.Wallet.ToScriptHash(address);
            }
            catch
            {
                return false;
            }
            return contacts.Remove(sh);
        }
        public virtual KeyPair DecryptKey(string nep2key)
        {
            return new KeyPair(Wallet.GetPrivateKeyFromNEP2(nep2key, password, Scrypt.N, Scrypt.R, Scrypt.P));
        }
        public virtual void Save()
        {
            wallet = new JObject();
            wallet["scrypt"] = Scrypt.ToJson();
            wallet["accounts"] = new JArray(accounts.Values.Select(p => p.ToJson()));
            wallet["contacts"] = new JArray(contacts.Values.Select(p => p.ToJson()));
            File.WriteAllText(path, wallet.ToString());
        }
        public virtual bool Unlock(string password)
        {
            if (!VerifyPassword(password))
                return false;
            this.password = password;
            return true;
        }
        public bool VerifyPassword(string password)
        {
            lock (accounts)
            {
                LightAccount account = accounts.Values.FirstOrDefault(p => !p.Decrypted);
                if (account == null)
                {
                    account = accounts.Values.FirstOrDefault(p => p.HasKey);
                }
                if (account == null) return true;
                if (account.Decrypted)
                {
                    return account.VerifyPassword(password);
                }
                else
                {
                    try
                    {
                        account.GetKey(password);
                        return true;
                    }
                    catch (FormatException)
                    {
                        return false;
                    }
                }
            }
        }
    }
}
