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
            this.tabContacts.Text = Locator.Case("Contacts", "联系人");
            this.tabInHistory.Text = Locator.Case("In History", "转入记录");
            this.tabOutHistory.Text = Locator.Case("Out History", "转出记录");
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
            this.bt_queryInHistory.Text = Locator.Case("Query In History", "查询转入记录");
            this.bt_queryOutHistory.Text = Locator.Case("Query Out History", "查询转出记录");

            StandbyApi = Settings.Default.ExtAPI;
            this.tb_backupapiurl.Text = StandbyApi;
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
            Settings.Default.ExtAPI = this.tb_backupapiurl.Text;
            Settings.Default.Save();
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
            this.lb_assets.Items.Add(new MaterialListBoxItem { Text = $"OXS            {balance.oxs}", SecondaryText = Blockchain.OXS.ToString() });
            this.lb_assets.Items.Add(new MaterialListBoxItem { Text = $"OXC            {balance.oxc}", SecondaryText = Blockchain.OXC.ToString() });
            if (assetbalances.result)
                foreach (var assetBalance in assetbalances.balances)
                {
                    this.lb_assets.Items.Add(new MaterialListBoxItem { Text = $"{assetBalance.assetname}            {assetBalance.amount}", SecondaryText = assetBalance.assetid });
                }
        }

        private void bt_queryOutHistory_Click(object sender, EventArgs e)
        {
            this.lb_outHistory.Items.Clear();
            var outRecords = WalletAPI.Instance.GetOutTxRecords(this.Address, 0, 10000);
            if (outRecords.result)
                foreach (var record in outRecords.records.OrderByDescending(m => DateTime.Parse(m.dt)))
                {
                    //var name = record.asset.ToLower();
                    //if (name != "oxs" && name != "oxc")
                    //    name = string.Empty;
                    this.lb_outHistory.Items.Add(new MaterialListBoxItem { Text = $"{record.dt}            {record.amount}", SecondaryText = record.assetId ?? string.Empty });
                }
        }

        private void bt_queryInHistory_Click(object sender, EventArgs e)
        {
            this.lb_inHistory.Items.Clear();
            var inRecords = WalletAPI.Instance.GetInTxRecords(this.Address, 0, 10000);
            if (inRecords.result)
                foreach (var record in inRecords.records.OrderByDescending(m => DateTime.Parse(m.dt)))
                {
                    //var name = record.asset.ToLower();
                    //if (name != "oxs" && name != "oxc")
                    //    name = string.Empty;
                    this.lb_inHistory.Items.Add(new MaterialListBoxItem { Text = $"{record.dt}            {record.amount}", SecondaryText = record.assetId ?? string.Empty });
                }
        }
    }
}