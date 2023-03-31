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
    public partial class ViewLeafMinerForm : MaterialForm
    {

        private readonly MaterialSkinManager materialSkinManager;
        MinerInfo MinerInfo;
        public ViewLeafMinerForm(MinerInfo info)
        {
            this.MinerInfo = info;
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
            this.tb_holderAddress.Hint = Locator.Case("Holder Address", "矿机持有者");
            this.tb_seedAddress.Hint = Locator.Case("Seed Address", "矿机种子地址");
            this.bt_close.Text = Locator.Case("Close", "关闭");
            this.bt_copyHolder.Text = Locator.Case("Copy Holder", "复制持有者地址");
            this.bt_copySeed.Text = Locator.Case("Copy Seed", "复制种子地址");

            this.tb_holderAddress.Text = this.MinerInfo.HolderAddress;
            this.tb_seedAddress.Text = this.MinerInfo.SeedAddress;
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

        private void bt_copyHolder_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.MinerInfo.HolderAddress);
            MaterialSnackBar SnackBarMessage = new(Locator.Case($"{this.MinerInfo.HolderAddress}   copied", $"{this.MinerInfo.HolderAddress}   已复制"), 750);
            SnackBarMessage.Show(this);
        }

        private void bt_copySeed_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.MinerInfo.SeedAddress);
            MaterialSnackBar SnackBarMessage = new(Locator.Case($"{this.MinerInfo.SeedAddress}   copied", $"{this.MinerInfo.SeedAddress}   已复制"), 750);
            SnackBarMessage.Show(this);
        }
    }
}