using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AuxCore.Models
{
    public class VerifyServer
    {
        public string signature;
        public string pubkey;
    }
    public abstract class APIResult
    {
        public bool result;
    }
    public class AddressBalance : APIResult
    {
        public string oxs;
        public string oxc;
    }
    public class AddressAssetBalance : APIResult
    {
        public PrivateAssetBalance[] balances;
    }
    public class PrivateAssetBalance
    {
        public string amount;
        public string assetid;
        public string assetname;
    }
    public class TXRecord
    {
        public string asset { get; set; }
        public string assetId { get; set; }
        public string amount { get; set; }
        public string dt { get; set; }
        public string txid { get; set; }
    }
    public class TxMsg : APIResult
    {
        public string transaction { get; set; }
        public string signature { get; set; }
        public string pubkey { get; set; }
    }
    public class BroadcastMsg : APIResult
    {
        public string msg { get; set; }
    }
    public class ClaimMsg : APIResult
    {
        public string available { get; set; }
        public string unavailable { get; set; }
    }
    public class TxRecords : APIResult
    {
        public TXRecord[] records;
    }
    public static class APIHelper
    {
        public static string BaseUrl;
        public static event Action ChangeServer;
        public static string Get(string url, string reqData)
        {
            string strUrl = new UriBuilder(BaseUrl + url)
            {
                Query = reqData
            }.ToString();
            if (strUrl.StartsWith("https")) { System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls; }

            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    using (HttpResponseMessage response = httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, strUrl)).Result)
                    {
                        string resultStr = string.Empty;
                        if (response.IsSuccessStatusCode)
                        {
                            Task<string> t = response.Content.ReadAsStringAsync();
                            resultStr = t.Result;
                        }
                        response.Dispose();
                        return resultStr;
                    }
                }
                catch (System.AggregateException ae)
                {
                    ChangeServer?.Invoke();
                    return string.Empty;
                }
                finally
                {
                    httpClient.Dispose();
                }
            }
        }
        public static string Post(string url, string reqData)
        {
            string strUrl = new UriBuilder(BaseUrl + url)
            {
                Query = reqData
            }.ToString();
            if (strUrl.StartsWith("https")) { System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls; }

            using (HttpClient httpClient = new HttpClient())
            {
                try
                {

                    using (HttpResponseMessage response = httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Post, strUrl)).Result)
                    {
                        string resultStr = string.Empty;
                        if (response.IsSuccessStatusCode)
                        {
                            Task<string> t = response.Content.ReadAsStringAsync();
                            resultStr = t.Result;
                        }
                        response.Dispose();
                        return resultStr;
                    }
                }
                catch (System.AggregateException ae)
                {
                    ChangeServer?.Invoke();
                    return string.Empty;
                }
                finally
                {
                    httpClient.Dispose();
                }

            }
        }
    }
}
