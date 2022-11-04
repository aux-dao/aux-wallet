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
    public partial class TransferForm : MaterialForm
    {
        public class contactItem
        {
            public LightContact contact;
            public override string ToString()
            {
                return $"{contact.Name}    /      {contact.Address.ToAddress()}";
            }
        }
        private readonly MaterialSkinManager materialSkinManager;
        LightWallet Wallet;
        public string AssetId { get; private set; }
        public TransferForm(LightWallet wallet, string assetId)
        {
            this.Wallet = wallet;
            this.AssetId = assetId;
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
        public string Amount
        {
            get
            {
                return this.tb_amount.Text;
            }
        }

        public string Address
        {
            get
            {
                return tb_address.Text;
            }
        }

        void Init()
        {
            this.tb_amount.Hint = Locator.Case("Amount", "金额");
            this.tb_address.Hint = Locator.Case("Address", "地址");
            this.bt_transfer.Text = Locator.Case("Transfer Now", "马上转帐");
            this.bt_close.Text = Locator.Case("Close", "关闭");
            this.cb_contacts.Hint = Locator.Case("Select Contact", "选择联系人");
            DrawerUseColors = true;
            DrawerHighlightWithAccent = true;
            DrawerBackgroundWithAccent = true;
            DrawerShowIconsWhenHidden = true;
            DrawerAutoShow = true;
            this.FormStyle = FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //this.cb_contacts.Items.Add(new contactItem { contact = contact });
            if (this.Wallet.contacts.IsNotNullAndEmpty())
                foreach (var contact in this.Wallet.contacts.Values)
                {
                    this.cb_contacts.Items.Add(new contactItem { contact = contact });
                }
        }





        private void MainForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_contacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = this.cb_contacts.SelectedItem;
            if (obj.IsNotNull())
            {
                var ct = obj as contactItem;
                this.tb_address.Text = ct.contact.Address.ToAddress();
            }
        }
    }
}