using Blazored.SessionStorage;
using Blazored.LocalStorage;
using System.Threading.Tasks;
using OX;
using OX.Wallets;
using System;
using OX.Wallets.NEP6;
using System.Security.Cryptography;
using OX.SmartContract;

namespace auxchrome.Models
{
    public static class StorageHelper
    {
        public const string ACCOUNTSTATEKEY = "org.au-x.wallet.chrome.accountstate";
        public const string ACCOUNNEP2KEYKEY = "org.au-x.wallet.chrome.nep2key";
        public const string ACCOUNTENCRYPTEDDATAKEY = "org.au-x.wallet.chrome.accountencrypteddata";

        public static string GetAccountState(this ISyncSessionStorageService sessionStorage)
        {
            return sessionStorage.GetItem<string>(ACCOUNTSTATEKEY);
        }
        public static string GetAccountNep2Key(this ISyncSessionStorageService sessionStorage)
        {
            return sessionStorage.GetItem<string>(ACCOUNNEP2KEYKEY);
        }
        public static ChromeWallet GetWallet(this ISyncSessionStorageService sessionStorage)
        {
            var hex = sessionStorage.GetAccountState();
            var nep2key = sessionStorage.GetAccountNep2Key();
            if (hex.IsNullOrEmpty() || nep2key.IsNullOrEmpty()) return default;
            try
            {
                var privateKey = hex.HexToBytes();
                var key = new KeyPair(privateKey);
                return new ChromeWallet(privateKey, key, nep2key);
            }
            catch
            {
                return default;
            }
        }
        public static void SaveWallet(this ISyncSessionStorageService sessionStorage, ChromeWallet wallet)
        {
            var hex = wallet.PrivateKey.ToHexString();
            sessionStorage.SetItem(ACCOUNTSTATEKEY, hex);
            sessionStorage.SetItem(ACCOUNNEP2KEYKEY, wallet.Account.Nep2Key);
        }
        public static string GetEncryptedAccountData(this ISyncLocalStorageService localStorage)
        {
            return localStorage.GetItem<string>(ACCOUNTENCRYPTEDDATAKEY);
        }
        public static ChromeWallet OpenWallet(this ISyncLocalStorageService localStorage, string password)
        {
            var nep2key = localStorage.GetEncryptedAccountData();
            if (nep2key.IsNullOrEmpty()) return default;
            try
            {
                var scryptParameters = ScryptParameters.Default;
                var privateKey = Wallet.GetPrivateKeyFromNEP2(nep2key, password, scryptParameters.N, scryptParameters.R, scryptParameters.P);
                var key = new KeyPair(privateKey);
                return new ChromeWallet(privateKey, key, nep2key);
            }
            catch (FormatException)
            {
                return default;
            }
        }
        public static ChromeWallet CreateWallet(this ISyncLocalStorageService localStorage, string password)
        {
            byte[] privateKey = new byte[32];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                var scryptParameters = ScryptParameters.Default;
                rng.GetBytes(privateKey);
                var key = new KeyPair(privateKey);
                var nep2key = key.Export(password, scryptParameters.N, scryptParameters.R, scryptParameters.P);
                var wallet = new ChromeWallet(privateKey, key, nep2key);
                if (wallet.IsNotNull())
                {
                    localStorage.SaveWallet(wallet);
                }
                return wallet;
            }
        }
        public static ChromeWallet ImportWallet(this ISyncLocalStorageService localStorage, string wif, string password)
        {
            var scryptParameters = ScryptParameters.Default;
            var privateKey = Wallet.GetPrivateKeyFromWIF(wif);
            KeyPair key = new KeyPair(privateKey);
            var nep2key = key.Export(password, scryptParameters.N, scryptParameters.R, scryptParameters.P);
            var wallet = new ChromeWallet(privateKey, key, nep2key);
            if (wallet.IsNotNull())
            {
                localStorage.SaveWallet(wallet);
            }
            return wallet;
        }
        public static void SaveWallet(this ISyncLocalStorageService localStorage, ChromeWallet wallet)
        {
            if (wallet.IsNotNull() && wallet.Account.IsNotNull() && wallet.Account.Nep2Key.IsNotNullAndEmpty())
            {
                localStorage.SetItem(ACCOUNTENCRYPTEDDATAKEY, wallet.Account.Nep2Key);
            }
        }
    }
}
