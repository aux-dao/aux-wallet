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
    public partial class TransferForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        bool isImport;
        public TransferForm(bool import = false)
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
            this.AcceptButton = this.bt_Add;
            this.CancelButton = this.bt_Add;
            this.bt_Add.DialogResult = DialogResult.OK;
        }
        public string Address
        {
            get
            {
                return this.tb_addr.Text;
            }
        }

        public string ContactName
        {
            get
            {
                return tb_name.Text;
            }
        }
        public string Remark
        {
            get
            {
                return tb_remark.Text;
            }
        }
        void Init()
        {
            this.tb_addr.Hint = Locator.Case("Contact Address", "联系人地址");
            this.tb_name.Hint = Locator.Case("Contact Name", "联系人名称");
            this.tb_remark.Hint = Locator.Case("Contact Remark", "联系人备注");
            this.bt_Add.Text = Locator.Case("Add Now", "马上添加");
            this.bt_close.Text = Locator.Case("Close", "关闭");
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