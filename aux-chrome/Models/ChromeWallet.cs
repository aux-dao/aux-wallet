using AuxCore;
using OX;
using OX.IO.Json;
using OX.Network.P2P.Payloads;
using OX.Wallets;
using OX.Wallets.NEP6;
using OX.SmartContract;
using System;
using Blazored.LocalStorage;

namespace auxchrome.Models
{
    public class ChromeWallet
    {
        public byte[] PrivateKey { get; private set; }
        public ChromeAccount Account { get; private set; }
        public ChromeWallet(byte[] privateKey, KeyPair key, string nep2key)
        {
            this.PrivateKey = privateKey;
            NEP6Contract contract = new NEP6Contract
            {
                Script = Contract.CreateSignatureRedeemScript(key.PublicKey),
                ParameterList = new[] { ContractParameterType.Signature },
                ParameterNames = new[] { "signature" },
                Deployed = false
            };
            this.Account = new ChromeAccount(key, nep2key, contract);
        }
    }
}
