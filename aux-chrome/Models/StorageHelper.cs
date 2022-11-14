using Blazored.SessionStorage;
using Blazored.LocalStorage;
using System.Threading.Tasks;

namespace auxchrome.Models
{
    public static class StorageHelper
    {
        public const string ACCOUNTSTATEKEY = "org.au-x.wallet.chrome.accountstate";
        public const string ACCOUNTENCRYPTEDDATAKEY = "org.au-x.wallet.chrome.accountencrypteddata";

        public static string GetAccountState(this ISyncSessionStorageService sessionStorage)
        {
            //sessionStorage.SetItem(ACCOUNTSTATEKEY, "tttt");
            return sessionStorage.GetItem<string>(ACCOUNTSTATEKEY);
        }
        public static string GetEncryptedAccountData(this ISyncLocalStorageService localStorage)
        {
            //localStorage.SetItem(ACCOUNTENCRYPTEDDATAKEY, "");
            return localStorage.GetItem<string>(ACCOUNTENCRYPTEDDATAKEY);
        }
    }
}
