using AuxCore.Models;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Material;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using AuxCore;
using OX;
using OX.Wallets;

namespace AuxWallet
{
    public partial class UnlockForm : MaterialForm
    {

        private readonly MaterialSkinManager materialSkinManager;
        LightAccount Account;
        public LockAsset Asset { get; private set; }
        public UnlockForm(LightAccount accout, LockAsset asset)
        {
            this.Account = accout;
            this.Asset = asset;
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
            this.AcceptButton = this.bt_transfer;
            this.CancelButton = this.bt_transfer;
            this.bt_transfer.DialogResult = DialogResult.OK;
        }
        void Init()
        {
            this.tb_amount.Hint = Locator.Case("Amount", "金额");
            this.tb_assetname.Hint = Locator.Case("Asset Name", "资产名");
            this.bt_transfer.Text = Locator.Case("Unlock Now", "马上解锁");
            this.bt_close.Text = Locator.Case("Close", "关闭");
            this.tb_amount.Text = new Fixed8(this.Asset.Value).ToString();
            this.tb_assetname.Text = this.Asset.AssetName;
            DrawerUseColors = true;
            DrawerHighlightWithAccent = true;
            DrawerBackgroundWithAccent = true;
            DrawerShowIconsWhenHidden = true;
            DrawerAutoShow = true;
            this.FormStyle = FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;


        }





        private void MainForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}