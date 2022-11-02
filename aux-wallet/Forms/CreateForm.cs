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

namespace AuxWallet
{
    public partial class CreateForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        bool isImport;
        public CreateForm(bool import = false)
        {
            this.isImport = import;
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
            this.AcceptButton = this.bt_new;
            this.CancelButton = this.bt_close;
            this.bt_new.DialogResult = DialogResult.OK;
            this.bt_close.DialogResult = DialogResult.Cancel;
        }
        public string Password
        {
            get
            {
                return this.tb_pwd.Text;
            }
        }

        public string WalletPath
        {
            get
            {
                return tf_walletpath.Text;
            }
        }
        public string PrivateKey
        {
            get
            {
                return tb_privateKey.Text;
            }
        }
        void Init()
        {
            this.tf_walletpath.Hint = Locator.Case("Wallet Path", "钱包路径");
            this.tb_pwd.Hint = Locator.Case("Wallet Password", "钱包密码");
            this.tb_privateKey.Hint = Locator.Case("Private Key", "钱包私钥");
            this.bt_new.Text = Locator.Case("Create", "创建");
            this.bt_close.Text = Locator.Case("Close", "关闭");
            this.bt_select.Text = Locator.Case("Select", "选择");
            DrawerUseColors = true;
            DrawerHighlightWithAccent = true;
            DrawerBackgroundWithAccent = true;
            DrawerShowIconsWhenHidden = true;
            DrawerAutoShow = true;
            this.FormStyle = FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            if (!isImport)
            {
                this.tb_privateKey.Visible = false;
            }
            this.saveFileDialog1.DefaultExt = "json";
            this.saveFileDialog1.Filter = "Wallet File|*.json";

        }





        private void MainForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void bt_select_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.tf_walletpath.Text = saveFileDialog1.FileName;
            }
        }


    }
}