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
    public partial class TransferAndLockForm : MaterialForm
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
        LightAccount Account;
        public string AssetId { get; private set; }
        public TransferAndLockForm(LightWallet wallet, LightAccount account, string assetId)
        {
            this.Wallet = wallet;
            this.Account = account;
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

        public uint Expire
        {
            get
            {
                uint h = 0;
                uint.TryParse(this.tb_expire.Text, out h);
                return h;
            }
        }
        void Init()
        {
            this.tab_transfer.Text = Locator.Case("Transfer", "转帐");
            this.tab_lock.Text = Locator.Case("Lock", "锁仓");
            this.tb_amount.Hint = Locator.Case("Amount", "金额");
            this.tb_address.Hint = Locator.Case("Address", "地址");
            this.bt_transfer.Text = Locator.Case("Transfer Now", "马上转帐");
            this.bt_lock.Text = Locator.Case("Lock Now", "马上锁仓");
            this.bt_close.Text = Locator.Case("Close", "关闭");
            this.cb_contacts.Hint = Locator.Case("Select Contact", "选择联系人");
            this.tb_amount_lock.Hint = Locator.Case("Lock Amount", "锁仓金额");
            this.tb_pubkey.Hint = Locator.Case("Unlock Public Key", "解锁账户公钥");
            this.tb_expire.Hint = Locator.Case("Unlock block height", "解锁的区块高度");
            this.cb_selflock.Text = Locator.Case("Self Lock", "自主锁仓");
            this.tb_expire.Enabled = false;
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



        private void tb_expire_TextChanged(object sender, EventArgs e)
        {

            if (!uint.TryParse(this.tb_expire.Text, out uint index))
            {
                var s = this.tb_expire.Text;
                if (s.Length > 0)
                {
                    s = s.Substring(0, s.Length - 1);
                    this.tb_expire.Clear();
                    this.tb_expire.Text = s;
                    this.tb_expire.SelectionStart = s.Length;
                }
            }
        }

        private void cb_selflock_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cb_selflock.Checked)
            {
                this.tb_pubkey.Clear();
                this.tb_pubkey.Text = this.Account.GetKey().PublicKey.ToString();
                this.tb_pubkey.ReadOnly = true;
            }
            else
            {
                this.tb_pubkey.Clear();
                this.tb_pubkey.ReadOnly = false;
            }
        }
    }
}