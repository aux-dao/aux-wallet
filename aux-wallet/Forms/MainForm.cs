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
using OX.Wallets;
using AuxCore.Models;

namespace AuxWallet
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public LightWallet Wallet;
        public VerifyForm VerifyForm;
        public MainForm(VerifyForm verifyForm, LightWallet wallet)
        {
            this.VerifyForm = verifyForm;
            this.Wallet = wallet;
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
            this.Text = this.Wallet.accounts.Keys?.FirstOrDefault()?.ToAddress();
            DrawerUseColors = true;
            DrawerHighlightWithAccent = true;
            DrawerBackgroundWithAccent = true;
            DrawerShowIconsWhenHidden = true;
            DrawerAutoShow = true;
            this.tabAsset.Text = Locator.Case("Assets", "资产");
            this.tabContacts.Text = Locator.Case("Contacts", "联系人");
            this.tabHistory.Text = Locator.Case("History", "交易历史");
            this.tabSetting.Text = Locator.Case("Setting", "设置");

            this.bt_changeTheme.Text = Locator.Case("Change Theme", "更换主题");
            this.bt_signout.Text = Locator.Case("Close Wallet", "关闭钱包");
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
    }
}