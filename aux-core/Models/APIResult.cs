using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AuxCore.Models
{
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
    public static class APIHelper
    {
        public static string Get(string url, string reqData)
        {

            string strUrl = new UriBuilder(url)
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
                catch (System.AggregateException ex)
                {
                    return ex.Message;
                }
                finally
                {
                    httpClient.Dispose();
                }
            }
        }
        public static string Post(string url, string reqData)
        {

            string strUrl = new UriBuilder(url)
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
                catch (System.AggregateException ex)
                {
                    return ex.Message;
                }
                finally
                {
                    httpClient.Dispose();
                }

            }
        }
    }
}
