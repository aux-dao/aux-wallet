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
using AuxCore;

namespace AuxWallet
{
    public partial class VerifyForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public VerifyForm()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;

            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Indigo500, MaterialPrimary.Indigo700, MaterialPrimary.Indigo100, MaterialAccent.Pink200, MaterialTextShade.WHITE);
            this.AcceptButton = this.bt_open;
            this.CancelButton = this.bt_close;
            this.bt_open.DialogResult = DialogResult.OK;
            this.bt_close.DialogResult = DialogResult.Cancel;
        }
        void Init()
        {
            this.lb_title.Text = Locator.Case("Wallet", "钱包");
            this.tf_walletpath.Hint = Locator.Case("Wallet Path", "钱包路径");
            this.tb_pwd.Hint = Locator.Case("Wallet Password", "钱包密码");
            this.bt_select.Text = Locator.Case("Select", "选择");
            this.bt_open.Text = Locator.Case("Open Wallet", "打开钱包");
            this.bt_new.Text = Locator.Case("New", "新建");
            this.bt_close.Text = Locator.Case("Close", "关闭");
            this.bt_import.Text = Locator.Case("Import", "导入");
            DrawerUseColors = true;
            DrawerHighlightWithAccent = true;
            DrawerBackgroundWithAccent = true;
            DrawerShowIconsWhenHidden = true;
            DrawerAutoShow = true;
            this.FormStyle = FormStyles.StatusAndActionBar_None;


            if (File.Exists(Settings.Default.LastWalletPath))
            {
                this.tf_walletpath.Text = Settings.Default.LastWalletPath;
                this.tb_pwd.Focus();
                this.ActiveControl = this.tb_pwd;
            }
        }





        private void MainForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void bt_select_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.tf_walletpath.Text = openFileDialog1.FileName;
            }
        }

        private void bt_open_Click(object sender, EventArgs e)
        {
            var path = this.tf_walletpath.Text;
            var pwd = this.tb_pwd.Text;
            LightWallet wallet = new LightWallet(path);
            if (wallet.Unlock(pwd))
            {
                Settings.Default.LastWalletPath = path;
                Settings.Default.Save();
                this.tb_pwd.Clear();
                this.Hide();
                new MainForm(this, wallet).Show();
            }
            else
            {
                this.tb_pwd.Focus();
                MaterialSnackBar SnackBarMessage = new(Locator.Case("Invalid password", "密码无效"), Locator.Case("OK", "确定"), true);
                SnackBarMessage.Show(this);
            }
        }

        private void bt_close_Click(object sender, EventArgs e)
        {

        }

        private void bt_new_Click(object sender, EventArgs e)
        {
            using (CreateForm dialog = new CreateForm())
            {
                if (dialog.ShowDialog() != DialogResult.OK) return;
                var path = dialog.WalletPath;
                var pwd = dialog.Password;
                LightWallet wallet = new LightWallet(path);
                wallet.Unlock(pwd);
                wallet.CreateAccount();
                wallet.Save();
                Settings.Default.LastWalletPath = path;
                Settings.Default.Save();
                this.tf_walletpath.Text = path;
            }
        }

        private void bt_import_Click(object sender, EventArgs e)
        {
            using (CreateForm dialog = new CreateForm(true))
            {
                if (dialog.ShowDialog() != DialogResult.OK) return;
                var path = dialog.WalletPath;
                var pwd = dialog.Password;
                var privateKey = dialog.PrivateKey;
                LightWallet wallet = new LightWallet(path);
                wallet.Unlock(pwd);
                wallet.Import(privateKey);
                wallet.Save();
                Settings.Default.LastWalletPath = path;
                Settings.Default.Save();
                this.tf_walletpath.Text = path;
            }
        }
    }
}