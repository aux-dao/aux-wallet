using AuxCore;
using OX;
using OX.IO.Json;
using OX.Network.P2P.Payloads;
using OX.Wallets;
using OX.Wallets.NEP6;
using OX.SmartContract;
using System;
using OX.IO;
using System.IO;

namespace auxchrome.Models
{
    public class ChromeAccount 
    {
        public KeyPair Key { get; private set; }
        public string Nep2Key { get; private set; }
        public Contract Contract { get; private set; }
        public UInt160 ScriptHash { get; private set; }
        public ChromeAccount(KeyPair key, string nep2key, Contract contract)
        {
            this.Key = key;
            this.Nep2Key = nep2key;
            this.Contract = contract;
            this.ScriptHash = contract.ScriptHash;
        }       

    }
}
