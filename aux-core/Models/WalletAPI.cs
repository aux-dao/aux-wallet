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

        public Height Height()
        {
            Random rd = new Random();
            string url = $"/api/Height";
            var query = $"rd={rd.Next()}";
            var str = APIHelper.Get(url, query);
            if (str.IsNotNullAndEmpty())
            {
                var p = JsonConvert.DeserializeObject<Height>(str);
                return p;
            }
            return default;
        }
        public VerifyServer GetVerirySPV(string rd)
        {
            string url = $"/api/VerifySpv";
            var query = $"rd={rd}";
            var str = APIHelper.Get(url, query);
            if (str.IsNotNullAndEmpty())
            {
                var p = JsonConvert.DeserializeObject<VerifyServer>(str);
                return p;
            }
            return default;
        }
        public AddressBalance GetPublicAssetBalance(string address)
        {
            Random rd = new Random();
            string url = $"/api/BalanceByAddress";
            var query = $"address={address}&r={rd.Next()}";
            var str = APIHelper.Get(url, query);
            if (str.IsNotNullAndEmpty())
            {
                var p = JsonConvert.DeserializeObject<AddressBalance>(str);
                return p;
            }
            return default;
        }
        public AddressAssetBalance GetPrivateAssetBalances(string address)
        {
            Random rd = new Random();
            string url = $"/api/AssetBalanceByAddress";
            var query = $"address={address}&r={rd.Next()}";
            var str = APIHelper.Get(url, query);
            if (str.IsNotNullAndEmpty())
            {
                var p = JsonConvert.DeserializeObject<AddressAssetBalance>(str);
                return p;
            }
            return default;
        }
        public TxRecords GetInTxRecords(string address, int pageIndex, int pageSize)
        {
            Random rd = new Random();
            string url = $"/api/QueryTxIn";
            var query = $"address={address}&pageindex={pageIndex}&pagesize={pageSize}&r={rd.Next()}";
            var str = APIHelper.Get(url, query);
            if (str.IsNotNullAndEmpty())
            {
                var p = JsonConvert.DeserializeObject<TxRecords>(str);
                return p;
            }
            return default;
        }
        public TxRecords GetOutTxRecords(string address, int pageIndex, int pageSize)
        {
            Random rd = new Random();
            string url = $"/api/QueryTxOut";
            var query = $"address={address}&pageindex={pageIndex}&pagesize={pageSize}&r={rd.Next()}";
            var str = APIHelper.Get(url, query);
            if (str.IsNotNullAndEmpty())
            {
                var p = JsonConvert.DeserializeObject<TxRecords>(str);
                return p;
            }
            return default;
        }
        public LockAssets GetLockAssets(string address, int pageIndex, int pageSize)
        {
            Random rd = new Random();
            string url = $"/api/QueryLockAsset";
            var query = $"address={address}&pageindex={pageIndex}&pagesize={pageSize}&r={rd.Next()}";
            var str = APIHelper.Get(url, query);
            if (str.IsNotNullAndEmpty())
            {
                var p = JsonConvert.DeserializeObject<LockAssets>(str);
                return p;
            }
            return default;
        }
        public TxMsg BuildTransfer(string sourceAddress, string desAddress, int assetKind, string amount)
        {
            Random rd = new Random();
            string url = $"/api/Transfer";
            var query = $"source={sourceAddress}&assetId={assetKind}&dests={desAddress}&amounts={amount}&r={rd.Next()}";
            var str = APIHelper.Get(url, query);
            if (str.IsNotNullAndEmpty())
            {
                var p = JsonConvert.DeserializeObject<TxMsg>(str);
                return p;
            }
            return default;
        }
        public TxMsg BuildLock(string sourceAddress, string destPubkey, int assetKind, string amount, uint experation)
        {
            Random rd = new Random();
            string url = $"/api/Lock";
            var query = $"source={sourceAddress}&assetId={assetKind}&destPubkey={destPubkey}&amounts={amount}&isTimeLock=0&expiration={experation}&r={rd.Next()}";
            var str = APIHelper.Get(url, query);
            if (str.IsNotNullAndEmpty())
            {
                var p = JsonConvert.DeserializeObject<TxMsg>(str);
                return p;
            }
            return default;
        }
        public TxMsg BuildAssetTransfer(string sourceAddress, string desAddress, string assetId, string amount)
        {
            Random rd = new Random();
            string url = $"/api/TransferAsset";
            var query = $"source={sourceAddress}&assetId={assetId}&dests={desAddress}&amounts={amount}&r={rd.Next()}";
            var str = APIHelper.Get(url, query);
            if (str.IsNotNullAndEmpty())
            {
                var p = JsonConvert.DeserializeObject<TxMsg>(str);
                return p;
            }
            return default;
        }
        public TxMsg BuildAssetLock(string sourceAddress, string desPubkey, string assetId, string amount, uint experation)
        {
            Random rd = new Random();
            string url = $"/api/LockAsset";
            var query = $"source={sourceAddress}&assetId={assetId}&destPubkey={desPubkey}&amounts={amount}&isTimeLock=0&expiration={experation}&r={rd.Next()}";
            var str = APIHelper.Get(url, query);
            if (str.IsNotNullAndEmpty())
            {
                var p = JsonConvert.DeserializeObject<TxMsg>(str);
                return p;
            }
            return default;
        }
        public BroadcastMsg BroadcastTransaction(int txkind, string publicKey, string signature, string transaction)
        {
            Random rd = new Random();
            string url = $"/api/Broadcast";
            var query = $"txkind={txkind}&publicKey={publicKey}&signature={signature}&transaction={transaction}&r={rd.Next()}";
            var str = APIHelper.Post(url, query);
            if (str.IsNotNullAndEmpty())
            {
                var p = JsonConvert.DeserializeObject<BroadcastMsg>(str);
                return p;
            }
            return default;
        }
        public BroadcastMsg BroadcastLockTransaction(int txkind, string publicKey, string signature, string transaction)
        {
            Random rd = new Random();
            string url = $"/api/BroadcastLock";
            var query = $"txkind={txkind}&publicKey={publicKey}&signature={signature}&transaction={transaction}&r={rd.Next()}";
            var str = APIHelper.Post(url, query);
            if (str.IsNotNullAndEmpty())
            {
                var p = JsonConvert.DeserializeObject<BroadcastMsg>(str);
                return p;
            }
            return default;
        }

        public ClaimMsg QueryClaim(string address)
        {
            Random rd = new Random();
            string url = $"/api/Claim";
            var query = $"id={address}&r={rd.Next()}";
            var str = APIHelper.Get(url, query);
            if (str.IsNotNullAndEmpty())
            {
                var p = JsonConvert.DeserializeObject<ClaimMsg>(str);
                return p;
            }
            return default;
        }
        public TxMsg BuildClaim(string pubkey)
        {
            Random rd = new Random();
            string url = $"/api/Gas";
            var query = $"publicKey={pubkey}&r={rd.Next()}";
            var str = APIHelper.Post(url, query);
            if (str.IsNotNullAndEmpty())
            {
                var p = JsonConvert.DeserializeObject<TxMsg>(str);
                return p;
            }
            return default;
        }
        public DigMsg Dig(uint dateTs, string publicKey, string signature)
        {
            Random rd = new Random();
            string url = $"/api/Dig";
            var query = $"dateTs={dateTs}&publicKey={publicKey}&signature={signature}&r={rd.Next()}";
            var str = APIHelper.Get(url, query);
            if (str.IsNotNullAndEmpty())
            {
                var p = JsonConvert.DeserializeObject<DigMsg>(str);
                return p;
            }
            return default;
        }
        public MinerInfoRecords QueryLeafMiners(string seedaddress)
        {
            Random rd = new Random();
            string url = $"/api/QueryLeafMiners";
            var query = $"parentseedaddress={seedaddress}&r={rd.Next()}";
            var str = APIHelper.Get(url, query);
            if (str.IsNotNullAndEmpty())
            {
                var p = JsonConvert.DeserializeObject<MinerInfoRecords>(str);
                return p;
            }
            return default;
        }
    }
}
