using AuxCore;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Material;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OX;
using OX.Wallets;
using AuxCore.Models;
using ReaLTaiizor.Child.Material;
using OX.Ledger;
using OX.Cryptography.ECC;
using OX.SmartContract;
using System.Security.Cryptography.X509Certificates;
using OX.Cryptography;
using OX.IO;
using System.Security.Cryptography.Xml;
using OX.Network.P2P.Payloads;
using OX.Network.P2P;
using System.IO;

namespace AuxWallet
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public LightWallet Wallet;
        public LightAccount Account;
        public string Address;
        public string PubKey;
        public VerifyForm VerifyForm;
        public string StandbyApi;

        public MainForm(VerifyForm verifyForm, LightWallet wallet)
        {
            this.VerifyForm = verifyForm;
            this.Wallet = wallet;
            this.Account = this.Wallet.accounts.Values?.FirstOrDefault();
            this.PubKey = this.Account.GetKey().PublicKey.EncodePoint(true).ToHexString();
            this.Address = this.Account.ScriptHash.ToAddress();
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;

            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            //materialSkinManager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Indigo500, MaterialPrimary.Indigo700, MaterialPrimary.Indigo100, MaterialAccent.Pink200, MaterialTextShade.WHITE);



        }
        void Init()
        {
            this.Text = this.Address;
            DrawerUseColors = true;
            DrawerHighlightWithAccent = true;
            DrawerBackgroundWithAccent = true;
            DrawerShowIconsWhenHidden = true;
            DrawerAutoShow = true;
            this.tabAsset.Text = Locator.Case("Assets", "资产");
            this.tabLockAsset.Text = Locator.Case("Lock Assets", "锁仓资产");
            this.tabContacts.Text = Locator.Case("Contacts", "联系人");
            this.tabInHistory.Text = Locator.Case("In History", "转入记录");
            this.tabOutHistory.Text = Locator.Case("Out History", "转出记录");
            this.tabSignature.Text = Locator.Case("Signature", "数据签名");
            this.tabSetting.Text = Locator.Case("Setting", "设置");

            this.bt_changeTheme.Text = Locator.Case("Change Theme", "更换主题");
            this.bt_signout.Text = Locator.Case("Close Wallet", "关闭钱包");
            this.lb_baseurl.Text = Locator.Case("Standby API Base Url", "备用API基地址");
            this.tb_backupapiurl.Hint = Locator.Case("Base Url", "基地址");
            this.bt_saveApiUrl.Text = Locator.Case("Save Standby API Base Url", "保存备用API基地址");

            this.tb_pwd.Hint = Locator.Case("Wallet Password", "钱包密码");
            this.lb_viewKey.Text = Locator.Case("View Private Key", "查看私钥");
            this.bt_viewKey.Text = Locator.Case("View", "查看");
            this.tb_Address.Hint = Locator.Case("Wallet Address", "钱包地址");
            this.tb_publicKey.Hint = Locator.Case("Wallet Public Key", "钱包公钥");
            this.tb_privateKey.Hint = Locator.Case("Wallet Private Key", "钱包私钥");

            this.bt_queryAsset.Text = Locator.Case("Query Assets", "查询资产");
            this.bt_RefreshLockAsset.Text = Locator.Case("Query Lock Assets", "查询锁仓资产");
            this.bt_claim.Text = Locator.Case("Claim Asset", "提取资产");
            this.bt_copyAddress.Text = Locator.Case("Copy Account Address", "复制账户地址");
            this.bt_queryInHistory.Text = Locator.Case("Query In History", "查询转入记录");
            this.bt_queryOutHistory.Text = Locator.Case("Query Out History", "查询转出记录");
            this.bt_addContact.Text = Locator.Case("Add Contact", "添加联系人");
            this.lb_title_available.Text = Locator.Case("Available:", "可提取:");
            this.lb_title_unavailable.Text = Locator.Case("unavailable:", "不可提取:");
            this.bt_dig.Text = Locator.Case("Dig", "打卡");
            this.rb_text.Text = "Text";
            this.rb_hex.Text = "Hex";
            this.bt_signature.Text = Locator.Case("Signature", "签名");
            this.bt_copy.Text = Locator.Case("Copy Output", "复制签名");

            StandbyApi = Settings.Default.ExtAPI;
            this.tb_backupapiurl.Text = StandbyApi;
            APIHelper.ChangeServer += APIHelper_ChangeServer;
            APIHelper.BaseUrl = Settings.Default.CurrentAPIUrl;
            if (APIHelper.BaseUrl.IsNullOrEmpty())
            {
                APIHelper_ChangeServer();
            }
            if (this.Wallet.contacts.IsNotNullAndEmpty())
                foreach (var contact in this.Wallet.contacts.Values)
                {
                    this.lb_contacts.Items.Add(new MaterialListBoxItem { Text = $"{contact.Name}({contact.Remark})", SecondaryText = contact.Address.ToAddress(), Tag = contact });
                }
        }

        private void APIHelper_ChangeServer()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() =>
                {
                    APIHelper.BaseUrl = changeServer();
                    Settings.Default.CurrentAPIUrl = APIHelper.BaseUrl;
                    Settings.Default.Save();
                }));
            }
            else
            {
                APIHelper.BaseUrl = changeServer();
                Settings.Default.CurrentAPIUrl = APIHelper.BaseUrl;
                Settings.Default.Save();
            }
        }
        string changeServer()
        {
            var l = Locator.ApiUrls.ToList();
            var extUrl = Settings.Default.ExtAPI;
            if (extUrl.IsNotNullAndEmpty())
            {
                l.Add(extUrl);
            }
            var c = l.Count;
            Random rd = new Random();
            var index = rd.Next(0, c);
            return l[index];
        }

        private int colorSchemeIndex;

        private void ColorScheme_Click(object sender, EventArgs e)
        {
            colorSchemeIndex++;
            if (colorSchemeIndex > 2)
            {
                colorSchemeIndex = 0;
            }

            UpdateColor();
        }

        private void UpdateColor()
        {
            //These are just example color schemes
            switch (colorSchemeIndex)
            {
                case 0:
                    materialSkinManager.ColorScheme = new MaterialColorScheme(
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialPrimary.Teal500 : MaterialPrimary.Indigo500,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialPrimary.Teal700 : MaterialPrimary.Indigo700,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialPrimary.Teal200 : MaterialPrimary.Indigo100,
                        MaterialAccent.Pink200,
                        MaterialTextShade.WHITE);
                    break;

                case 1:
                    materialSkinManager.ColorScheme = new MaterialColorScheme(
                        MaterialPrimary.Green600,
                        MaterialPrimary.Green700,
                        MaterialPrimary.Green200,
                        MaterialAccent.Red100,
                        MaterialTextShade.WHITE);
                    break;

                case 2:
                    materialSkinManager.ColorScheme = new MaterialColorScheme(
                        MaterialPrimary.BlueGrey800,
                        MaterialPrimary.BlueGrey900,
                        MaterialPrimary.BlueGrey500,
                        MaterialAccent.LightBlue200,
                        MaterialTextShade.WHITE);
                    break;
            }
            Invalidate();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void materialButton7_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
            UpdateColor();
        }

        private void bt_signout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.VerifyForm.Show();
        }

        private void bt_saveApiUrl_Click(object sender, EventArgs e)
        {
            var baseUrl = this.tb_backupapiurl.Text;
            var oldBaseUrl = APIHelper.BaseUrl;
            APIHelper.BaseUrl = baseUrl;
            var dt = DateTime.Now;
            Random rd = new Random();
            string str = $"{dt.Year}{dt.Month}{dt.Day}{rd.Next()}{rd.Next()}";
            var m = System.Text.Encoding.UTF8.GetBytes(str);
            var rds = m.ToHexString();
            var vs = WalletAPI.Instance.GetVerirySPV(rds);
            bool returnUrl = true;
            if (vs.IsNotNull() && Locator.spvlidators.Contains(vs.pubkey))
            {
                var pubkey = ECPoint.DecodePoint(vs.pubkey.HexToBytes(), ECCurve.Secp256r1);
                var ok = Crypto.Default.VerifySignature(m, vs.signature.HexToBytes(), pubkey.EncodePoint(true));
                if (ok)
                {
                    Settings.Default.ExtAPI = baseUrl;
                    Settings.Default.Save();
                    returnUrl = false;
                }
            }
            if (returnUrl)
            {
                this.tb_backupapiurl.Text = Settings.Default.ExtAPI;
            }
            APIHelper.BaseUrl = oldBaseUrl;
        }

        private void bt_viewKey_Click(object sender, EventArgs e)
        {
            if (this.Wallet.VerifyPassword(this.tb_pwd.Text))
            {
                this.tb_Address.Text = this.Account.ScriptHash.ToAddress();
                this.tb_publicKey.Text = this.Account.GetKey().PublicKey.EncodePoint(true).ToHexString();
                this.tb_privateKey.Text = this.Account.GetKey().Export();
            }
        }

        private void bt_queryAsset_Click(object sender, EventArgs e)
        {
            var balance = WalletAPI.Instance.GetPublicAssetBalance(this.Address);
            var assetbalances = WalletAPI.Instance.GetPrivateAssetBalances(this.Address);
            this.lb_assets.Items.Clear();
            if (balance.IsNotNull())
            {
                this.lb_assets.Items.Add(new MaterialListBoxItem { Text = $"OXS            {balance.oxs}", SecondaryText = Blockchain.OXS.ToString(), Tag = Blockchain.OXS.ToString() });
                this.lb_assets.Items.Add(new MaterialListBoxItem { Text = $"OXC            {balance.oxc}", SecondaryText = Blockchain.OXC.ToString(), Tag = Blockchain.OXC.ToString() });
            }

            if (assetbalances.IsNotNull() && assetbalances.result)
                foreach (var assetBalance in assetbalances.balances)
                {
                    this.lb_assets.Items.Add(new MaterialListBoxItem { Text = $"{assetBalance.assetname}            {assetBalance.amount}", SecondaryText = assetBalance.assetid, Tag = assetBalance.assetid });
                }
            var claimMsg = WalletAPI.Instance.QueryClaim(this.Address);
            if (claimMsg.IsNotNull())
            {
                this.lb_available.Text = claimMsg.available;
                this.lb_unavailable.Text = claimMsg.unavailable;
            }
        }

        private void bt_queryOutHistory_Click(object sender, EventArgs e)
        {
            this.lb_outHistory.Items.Clear();
            var outRecords = WalletAPI.Instance.GetOutTxRecords(this.Address, 0, 10000);
            if (outRecords.IsNotNull() && outRecords.result)
                foreach (var record in outRecords.records.OrderByDescending(m => DateTime.Parse(m.dt)))
                {
                    this.lb_outHistory.Items.Add(new MaterialListBoxItem { Text = $"{record.dt}            {record.amount}", SecondaryText = record.assetId ?? string.Empty });
                }
        }

        private void bt_queryInHistory_Click(object sender, EventArgs e)
        {
            this.lb_inHistory.Items.Clear();
            var inRecords = WalletAPI.Instance.GetInTxRecords(this.Address, 0, 10000);
            if (inRecords.IsNotNull() && inRecords.result)
                foreach (var record in inRecords.records.OrderByDescending(m => DateTime.Parse(m.dt)))
                {
                    this.lb_inHistory.Items.Add(new MaterialListBoxItem { Text = $"{record.dt}            {record.amount}", SecondaryText = record.assetId ?? string.Empty });
                }
        }

        private void bt_addContact_Click(object sender, EventArgs e)
        {
            using (var dialog = new CreateContactForm())
            {
                if (dialog.ShowDialog() != DialogResult.OK) return;
                var addr = dialog.Address;
                var name = dialog.ContactName;
                var remark = dialog.Remark;
                try
                {
                    var sh = addr.ToScriptHash();
                    LightContact contact = new LightContact(sh, name, remark);
                    bool ok = this.Wallet.AddContact(contact);
                    if (ok)
                    {
                        this.Wallet.Save();
                        this.lb_contacts.Items.Add(new MaterialListBoxItem { Text = $"{contact.Name}({contact.Remark})", SecondaryText = contact.Address.ToAddress(), Tag = contact });
                    }
                }
                catch
                {
                    return;
                }
            }
        }

        private void lb_contacts_DoubleClick(object sender, EventArgs e)
        {

        }

        private void lb_contacts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var obj = this.lb_contacts.SelectedItem;
            if (obj.IsNotNull())
            {
                var contact = obj.Tag as LightContact;
                MaterialDialog materialDialog = new(this, Locator.Case("Remove Contact", "删除联系人"), Locator.Case($"Are you sure remove contact {contact.Address.ToAddress()}  ?", $"确定要删除联系人 {contact.Address.ToAddress()}  ？"), Locator.Case("Delete", "删除"), true, Locator.Case("Cancel", "取消"));
                if (materialDialog.ShowDialog(this) == DialogResult.OK)
                {
                    this.Wallet.DeleteContact(contact.Address.ToAddress());
                    this.Wallet.Save();
                    this.lb_contacts.Items.Remove(obj);
                    MaterialSnackBar SnackBarMessage = new(Locator.Case("Remove Completed", "删除成功"), 750);
                    SnackBarMessage.Show(this);
                }
            }
        }

        private void lb_assets_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var obj = this.lb_assets.SelectedItem;
            if (obj.IsNotNull())
            {
                var assetId = obj.Tag as string;
                using (var dialog = new TransferForm(this.Wallet, assetId))
                {
                    if (dialog.ShowDialog() != DialogResult.OK) return;
                    try
                    {
                        var addr = dialog.Address.ToScriptHash();
                        var amt = Fixed8.Parse(dialog.Amount);
                        int assetKind = 0;
                        if (assetId == Blockchain.OXS.ToString())
                        {
                            assetKind = 1;
                        }
                        else if (assetId == Blockchain.OXC.ToString())
                        {
                            assetKind = 2;
                        }
                        TxMsg txMsg;
                        if (assetKind == 0)
                        {
                            txMsg = WalletAPI.Instance.BuildAssetTransfer(this.Address, addr.ToAddress(), assetId, dialog.Amount);
                        }
                        else
                        {
                            txMsg = WalletAPI.Instance.BuildTransfer(this.Address, addr.ToAddress(), assetKind, dialog.Amount);
                        }
                        if (txMsg.IsNotNull() && txMsg.result && Locator.spvlidators.Contains(txMsg.pubkey))
                        {
                            var pubkey = ECPoint.DecodePoint(txMsg.pubkey.HexToBytes(), ECCurve.Secp256r1);
                            var txData = txMsg.transaction.HexToBytes();
                            var ok = Crypto.Default.VerifySignature(txData, txMsg.signature.HexToBytes(), pubkey.EncodePoint(true));
                            if (ok)
                            {
                                ContractTransaction ct = new ContractTransaction()
                                {
                                    Attributes = new TransactionAttribute[0],
                                    Witnesses = new Witness[0]
                                };
                                using (MemoryStream ms = new MemoryStream(txData, false))
                                using (BinaryReader reader = new BinaryReader(ms, Encoding.UTF8))
                                {
                                    IVerifiable verifiable = ct as IVerifiable;
                                    verifiable.DeserializeUnsigned(reader);
                                }
                                //var ct = txData.DeserilizeTransaction((byte)TransactionType.ContractTransaction) as ContractTransaction;
                                if (ct.IsNotNull())
                                {
                                    ct = new ContractTransactionHelper(ct, this.Account).Build();
                                    var data = ct.ToArray();
                                    var signature = data.Sign(this.Account.GetKey()).ToHexString();
                                    var pk = this.Account.GetKey().PublicKey.EncodePoint(true).ToHexString();
                                    var bm = WalletAPI.Instance.BroadcastTransaction(128, pk, signature, data.ToHexString());
                                    if (bm.result)
                                    {
                                        MaterialSnackBar SnackBarMessage = new(Locator.Case("post transaction broadcast request", "交易广播请求已提交"), 750);
                                        SnackBarMessage.Show(this);
                                    }
                                }
                            }
                        }
                    }
                    catch
                    {
                        return;
                    }
                }
            }
        }

        private void bt_copyAddress_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.Address);
            MaterialSnackBar SnackBarMessage = new(Locator.Case($"address  {this.Address}   copied", $"地址  {this.Address}   已复制"), 750);
            SnackBarMessage.Show(this);
        }

        private void bt_claim_Click(object sender, EventArgs e)
        {
            var mypubkey = this.Account.GetKey().PublicKey.EncodePoint(true).ToHexString();
            var txMsg = WalletAPI.Instance.BuildClaim(mypubkey);
            if (txMsg.IsNotNull() && txMsg.result && Locator.spvlidators.Contains(txMsg.pubkey))
            {
                var pubkey = ECPoint.DecodePoint(txMsg.pubkey.HexToBytes(), ECCurve.Secp256r1);
                var txData = txMsg.transaction.HexToBytes();
                var ok = Crypto.Default.VerifySignature(txData, txMsg.signature.HexToBytes(), pubkey.EncodePoint(true));
                if (ok)
                {
                    ClaimTransaction ct = new ClaimTransaction()
                    {
                        Attributes = new TransactionAttribute[0],
                        Witnesses = new Witness[0],
                        Claims = new CoinReference[0]
                    };
                    using (MemoryStream ms = new MemoryStream(txData, false))
                    using (BinaryReader reader = new BinaryReader(ms, Encoding.UTF8))
                    {
                        IVerifiable verifiable = ct as IVerifiable;
                        verifiable.DeserializeUnsigned(reader);
                    }
                    if (ct.IsNotNull())
                    {
                        ct = new ClaimTransactionHelper(ct, this.Account).Build();
                        var data = ct.ToArray();
                        var signature = data.Sign(this.Account.GetKey()).ToHexString();
                        var pk = this.Account.GetKey().PublicKey.EncodePoint(true).ToHexString();
                        var bm = WalletAPI.Instance.BroadcastTransaction(2, pk, signature, data.ToHexString());
                        if (bm.result)
                        {
                            MaterialSnackBar SnackBarMessage = new(Locator.Case("post transaction broadcast request", "交易广播请求已提交"), 750);
                            SnackBarMessage.Show(this);
                        }
                    }
                }
            }
        }

        private void bt_dig_Click(object sender, EventArgs e)
        {
            var ts = DateTime.Now.ToUniversalTime().Date.ToTimestamp();
            var data = BitConverter.GetBytes(ts);
            var signature = data.Sign(this.Account.GetKey()).ToHexString();
            var pk = this.Account.GetKey().PublicKey.EncodePoint(true).ToHexString();
            var bm = WalletAPI.Instance.Dig(ts, pk, signature);
            if (bm.result)
            {
                MaterialSnackBar SnackBarMessage = new(Locator.Case("post dig request", "打卡已请求"), 750);
                SnackBarMessage.Show(this);
            }
        }

        private void bt_signature_Click(object sender, EventArgs e)
        {
            var intput = this.tb_input.Text;
            if (intput.IsNullOrEmpty()) return;

            byte[] raw, signedData = null;
            try
            {
                if (rb_hex.Checked)
                {
                    raw = intput.HexToBytes();
                }
                else
                {
                    raw = Encoding.UTF8.GetBytes(intput);
                }
            }
            catch (Exception err)
            {
                MaterialSnackBar SnackBarMessage = new(err.Message, 750);
                SnackBarMessage.Show(this);
                return;
            }
            var keys = this.Account.GetKey();
            try
            {
                signedData = Crypto.Default.Sign(raw, keys.PrivateKey, keys.PublicKey.EncodePoint(false).Skip(1).ToArray());
            }
            catch (Exception err)
            {
                MaterialSnackBar SnackBarMessage = new(err.Message, 750);
                SnackBarMessage.Show(this);
                return;
            }
            this.tb_output.Text = signedData?.ToHexString();
            MaterialSnackBar msg = new(Locator.Case("signature success,please copy it", "签名成功，请复制"), 750);
            msg.Show(this);
        }

        private void bt_copy_Click(object sender, EventArgs e)
        {
            var str = this.tb_output.Text;
            if (str.IsNotNullAndEmpty())
            {
                Clipboard.SetText(str);
                MaterialSnackBar msg = new(Locator.Case("signature data copied", "签名已复制"), 750);
                msg.Show(this);
            }
        }

        private void bt_RefreshLockAsset_Click(object sender, EventArgs e)
        {
            this.lb_assets.Items.Clear();
            var records = WalletAPI.Instance.GetLockAssets(this.Address, 0, 10000).records;
            if (records.IsNotNull())
                foreach (var asset in records)
                {
                    var lockType = string.Empty;
                    var le = asset.LockExpiration.ToString();
                    if (asset.IsTimeLock == 1)
                    {
                        lockType = Locator.Case("Time Lock", "时间锁定");
                        le = ((uint)asset.LockExpiration).ToDateTime().ToString("yyyy-MM-dd HH:mm:ss");
                    }
                    else
                    {
                        lockType = Locator.Case("Block Lock", "区块锁定");
                    }
                    this.lb_assets.Items.Add(new MaterialListBoxItem
                    {
                        Text = $"{asset.AssetName}    {new Fixed8(asset.Value)}",
                        SecondaryText = $"{lockType}:  {le}  {Locator.Case("expire", "到期")}"
                    });
                }
        }
    }
}