using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;
using OX;

namespace AuxCore.Models
{
    public class WalletAPI
    {
        static WalletAPI _instance;
        public static WalletAPI Instance
        {
            get
            {
                if (_instance == default) _instance = new WalletAPI();
                return _instance;
            }
        }
        WalletAPI()
        {

        }
        string GetBaseUrl()
        {
            return Locator.ApiUrls.FirstOrDefault();
        }
        public async Task<AddressBalance> GetPublicAssetBalance(string address)
        {
            HttpClient hc = new HttpClient();
            Random rd = new Random();
            string url = $"{GetBaseUrl()}/api/BalanceByAddress";
            var query = $"address={address}&r={rd.Next()}";
            var str = APIHelper.Get(url, query);
            if (str.IsNotNullAndEmpty())
            {
                var p = JsonConvert.DeserializeObject<AddressBalance>(str);
                return p;
            }
            return default;
        }
        public async Task<AddressAssetBalance> GetPrivateAssetBalances(string address)
        {
            HttpClient hc = new HttpClient();
            Random rd = new Random();
            string url = $"{GetBaseUrl()}/api/AssetBalanceByAddress";
            var query = $"address={address}&r={rd.Next()}";
            var str = APIHelper.Get(url, query);
            if (str.IsNotNullAndEmpty())
            {
                var p = JsonConvert.DeserializeObject<AddressAssetBalance>(str);
                return p;
            }
            return default;
        }
    }
}
