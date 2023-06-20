using OX.Ledger;
using OX.Network.P2P.Payloads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OX.IO;
using OX;
using OX.Cryptography.ECC;
using OX.SmartContract;
using System.Runtime.CompilerServices;
using System.Security;

namespace AuxCore.Invest
{

    public static class MutualLockHelper
    {
        public const string InvestMasterPubKey = "02a829c4171ff79c581097abd1f6de90223a7f053f955e16d8f0749d4fe4440aa4";
        public static ECPoint MasterAccountPubKey = ECPoint.DecodePoint(InvestMasterPubKey.HexToBytes(), ECCurve.Secp256r1);
        public static UInt160 MasterAccountAddress = Contract.CreateSignatureRedeemScript(MasterAccountPubKey).ToScriptHash();

        public const string LockMiningPubkeyString = "02ea34b278a3812ee869ba7e06a815ab4a6e2b9c33c1bad6b91ef914f0f22a920e";
        public static ECPoint LockMiningAccountPubKey = ECPoint.DecodePoint(LockMiningPubkeyString.HexToBytes(), ECCurve.Secp256r1);
        public static UInt160 LockMiningAAccountAddress = Contract.CreateSignatureRedeemScript(LockMiningAccountPubKey).ToScriptHash();

        static UInt160 genesisSeedAddress;
        public static UInt160 GenesisSeed()
        {
            if (genesisSeedAddress.IsNull())
            {
                genesisSeedAddress = MasterAccountAddress.GetMutualLockSeed();
            }
            return genesisSeedAddress;
        }
        public static UInt160 GetMutualLockSeed(this UInt160 sh)
        {
            return new SideTransaction()
            {
                Recipient = LockMiningAccountPubKey,
                SideType = SideType.ScriptHash,
                Data = sh.ToArray(),
                Flag = 1,//1标记代表种子
                 AuthContract =Blockchain.SideAssetContractScriptHash,
                Attributes = new TransactionAttribute[0],
                Outputs = new TransactionOutput[0],
                Inputs = new CoinReference[0]
            }.GetContract().ScriptHash;
        }
        public static bool VerifyMutualLockNodeRegister(this TransactionOutput output)
        {
            if (output.Value >= Fixed8.One * 100 && output.AssetId.Equals(Blockchain.OXC))
            {
                return true;
            }
            return false;
        }      
    }
}
