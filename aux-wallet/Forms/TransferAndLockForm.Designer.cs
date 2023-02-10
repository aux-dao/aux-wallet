using ReaLTaiizor.Controls;
using System.Windows.Forms;

namespace AuxWallet
{
    partial class TransferAndLockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferAndLockForm));
            this.tb_amount = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.bt_transfer = new ReaLTaiizor.Controls.MaterialButton();
            this.tb_address = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.bt_close = new ReaLTaiizor.Controls.MaterialButton();
            this.cb_contacts = new ReaLTaiizor.Controls.MaterialComboBox();
            this.tb_expire = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.cb_selflock = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.tb_amount_lock = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.tb_pubkey = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.materialDivider2 = new ReaLTaiizor.Controls.MaterialDivider();
            this.materialDivider1 = new ReaLTaiizor.Controls.MaterialDivider();
            this.materialTabControl2 = new ReaLTaiizor.Controls.MaterialTabControl();
            this.tab_transfer = new System.Windows.Forms.TabPage();
            this.tab_lock = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new ReaLTaiizor.Controls.MaterialTabSelector();
            this.materialTabControl2.SuspendLayout();
            this.tab_transfer.SuspendLayout();
            this.tab_lock.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_amount
            // 
            this.tb_amount.AnimateReadOnly = false;
            this.tb_amount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_amount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_amount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_amount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_amount.Depth = 0;
            this.tb_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_amount.HideSelection = true;
            this.tb_amount.Hint = "Type here";
            this.tb_amount.LeadingIcon = null;
            this.tb_amount.Location = new System.Drawing.Point(33, 24);
            this.tb_amount.Margin = new System.Windows.Forms.Padding(6);
            this.tb_amount.MaxLength = 0;
            this.tb_amount.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.PasswordChar = '\0';
            this.tb_amount.PrefixSuffixText = null;
            this.tb_amount.ReadOnly = false;
            this.tb_amount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_amount.SelectedText = "";
            this.tb_amount.SelectionLength = 0;
            this.tb_amount.SelectionStart = 0;
            this.tb_amount.ShortcutsEnabled = true;
            this.tb_amount.Size = new System.Drawing.Size(844, 48);
            this.tb_amount.TabIndex = 71;
            this.tb_amount.TabStop = false;
            this.tb_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_amount.TrailingIcon = null;
            this.tb_amount.UseSystemPasswordChar = false;
            // 
            // bt_transfer
            // 
            this.bt_transfer.AutoSize = false;
            this.bt_transfer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_transfer.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_transfer.Depth = 0;
            this.bt_transfer.HighEmphasis = false;
            this.bt_transfer.Icon = null;
            this.bt_transfer.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_transfer.Location = new System.Drawing.Point(685, 393);
            this.bt_transfer.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_transfer.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_transfer.Name = "bt_transfer";
            this.bt_transfer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_transfer.Size = new System.Drawing.Size(187, 51);
            this.bt_transfer.TabIndex = 78;
            this.bt_transfer.Text = "TEXT - LOW - NORMAL";
            this.bt_transfer.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            this.bt_transfer.UseAccentColor = false;
            this.bt_transfer.UseVisualStyleBackColor = true;
            // 
            // tb_address
            // 
            this.tb_address.AnimateReadOnly = false;
            this.tb_address.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_address.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_address.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_address.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_address.Depth = 0;
            this.tb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_address.HideSelection = true;
            this.tb_address.Hint = "Type here";
            this.tb_address.LeadingIcon = null;
            this.tb_address.Location = new System.Drawing.Point(33, 96);
            this.tb_address.Margin = new System.Windows.Forms.Padding(6);
            this.tb_address.MaxLength = 0;
            this.tb_address.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_address.Name = "tb_address";
            this.tb_address.PasswordChar = '\0';
            this.tb_address.PrefixSuffixText = null;
            this.tb_address.ReadOnly = false;
            this.tb_address.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_address.SelectedText = "";
            this.tb_address.SelectionLength = 0;
            this.tb_address.SelectionStart = 0;
            this.tb_address.ShortcutsEnabled = true;
            this.tb_address.Size = new System.Drawing.Size(844, 48);
            this.tb_address.TabIndex = 72;
            this.tb_address.TabStop = false;
            this.tb_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_address.TrailingIcon = null;
            this.tb_address.UseSystemPasswordChar = false;
            // 
            // bt_close
            // 
            this.bt_close.AutoSize = false;
            this.bt_close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_close.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_close.Depth = 0;
            this.bt_close.HighEmphasis = false;
            this.bt_close.Icon = null;
            this.bt_close.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_close.Location = new System.Drawing.Point(471, 393);
            this.bt_close.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_close.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_close.Name = "bt_close";
            this.bt_close.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_close.Size = new System.Drawing.Size(187, 51);
            this.bt_close.TabIndex = 77;
            this.bt_close.Text = "TEXT - LOW - NORMAL";
            this.bt_close.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            this.bt_close.UseAccentColor = false;
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // cb_contacts
            // 
            this.cb_contacts.AutoResize = false;
            this.cb_contacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.cb_contacts.Depth = 0;
            this.cb_contacts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_contacts.DropDownHeight = 174;
            this.cb_contacts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_contacts.DropDownWidth = 121;
            this.cb_contacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_contacts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_contacts.FormattingEnabled = true;
            this.cb_contacts.Hint = "ComboBox hints!";
            this.cb_contacts.IntegralHeight = false;
            this.cb_contacts.ItemHeight = 43;
            this.cb_contacts.Location = new System.Drawing.Point(33, 168);
            this.cb_contacts.Margin = new System.Windows.Forms.Padding(6);
            this.cb_contacts.MaxDropDownItems = 4;
            this.cb_contacts.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cb_contacts.Name = "cb_contacts";
            this.cb_contacts.Size = new System.Drawing.Size(844, 49);
            this.cb_contacts.StartIndex = 0;
            this.cb_contacts.TabIndex = 73;
            this.cb_contacts.SelectedIndexChanged += new System.EventHandler(this.cb_contacts_SelectedIndexChanged);
            // 
            // tb_expire
            // 
            this.tb_expire.AnimateReadOnly = false;
            this.tb_expire.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_expire.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_expire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_expire.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_expire.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_expire.Depth = 0;
            this.tb_expire.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_expire.HideSelection = true;
            this.tb_expire.Hint = "Type here";
            this.tb_expire.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_expire.LeadingIcon = null;
            this.tb_expire.Location = new System.Drawing.Point(34, 165);
            this.tb_expire.Margin = new System.Windows.Forms.Padding(6);
            this.tb_expire.MaxLength = 0;
            this.tb_expire.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_expire.Name = "tb_expire";
            this.tb_expire.PasswordChar = '\0';
            this.tb_expire.PrefixSuffixText = null;
            this.tb_expire.ReadOnly = false;
            this.tb_expire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_expire.SelectedText = "";
            this.tb_expire.SelectionLength = 0;
            this.tb_expire.SelectionStart = 0;
            this.tb_expire.ShortcutsEnabled = true;
            this.tb_expire.Size = new System.Drawing.Size(843, 48);
            this.tb_expire.TabIndex = 76;
            this.tb_expire.TabStop = false;
            this.tb_expire.Text = "0";
            this.tb_expire.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_expire.TrailingIcon = null;
            this.tb_expire.UseSystemPasswordChar = false;
            this.tb_expire.TextChanged += new System.EventHandler(this.tb_expire_TextChanged);
            // 
            // cb_selflock
            // 
            this.cb_selflock.AutoSize = true;
            this.cb_selflock.Depth = 0;
            this.cb_selflock.Location = new System.Drawing.Point(32, 231);
            this.cb_selflock.Margin = new System.Windows.Forms.Padding(0);
            this.cb_selflock.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cb_selflock.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.cb_selflock.Name = "cb_selflock";
            this.cb_selflock.ReadOnly = false;
            this.cb_selflock.Ripple = true;
            this.cb_selflock.Size = new System.Drawing.Size(172, 37);
            this.cb_selflock.TabIndex = 80;
            this.cb_selflock.Text = "materialCheckBox1";
            this.cb_selflock.UseAccentColor = false;
            this.cb_selflock.UseVisualStyleBackColor = true;
            this.cb_selflock.CheckedChanged += new System.EventHandler(this.cb_selflock_CheckedChanged);
            // 
            // tb_amount_lock
            // 
            this.tb_amount_lock.AnimateReadOnly = false;
            this.tb_amount_lock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_amount_lock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_amount_lock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_amount_lock.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_amount_lock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_amount_lock.Depth = 0;
            this.tb_amount_lock.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_amount_lock.HideSelection = true;
            this.tb_amount_lock.Hint = "Type here";
            this.tb_amount_lock.LeadingIcon = null;
            this.tb_amount_lock.Location = new System.Drawing.Point(34, 23);
            this.tb_amount_lock.Margin = new System.Windows.Forms.Padding(6);
            this.tb_amount_lock.MaxLength = 0;
            this.tb_amount_lock.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_amount_lock.Name = "tb_amount_lock";
            this.tb_amount_lock.PasswordChar = '\0';
            this.tb_amount_lock.PrefixSuffixText = null;
            this.tb_amount_lock.ReadOnly = false;
            this.tb_amount_lock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_amount_lock.SelectedText = "";
            this.tb_amount_lock.SelectionLength = 0;
            this.tb_amount_lock.SelectionStart = 0;
            this.tb_amount_lock.ShortcutsEnabled = true;
            this.tb_amount_lock.Size = new System.Drawing.Size(843, 48);
            this.tb_amount_lock.TabIndex = 77;
            this.tb_amount_lock.TabStop = false;
            this.tb_amount_lock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_amount_lock.TrailingIcon = null;
            this.tb_amount_lock.UseSystemPasswordChar = false;
            // 
            // tb_pubkey
            // 
            this.tb_pubkey.AnimateReadOnly = false;
            this.tb_pubkey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_pubkey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_pubkey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_pubkey.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_pubkey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_pubkey.Depth = 0;
            this.tb_pubkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_pubkey.HideSelection = true;
            this.tb_pubkey.Hint = "Type here";
            this.tb_pubkey.LeadingIcon = null;
            this.tb_pubkey.Location = new System.Drawing.Point(34, 94);
            this.tb_pubkey.Margin = new System.Windows.Forms.Padding(6);
            this.tb_pubkey.MaxLength = 0;
            this.tb_pubkey.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_pubkey.Name = "tb_pubkey";
            this.tb_pubkey.PasswordChar = '\0';
            this.tb_pubkey.PrefixSuffixText = null;
            this.tb_pubkey.ReadOnly = false;
            this.tb_pubkey.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_pubkey.SelectedText = "";
            this.tb_pubkey.SelectionLength = 0;
            this.tb_pubkey.SelectionStart = 0;
            this.tb_pubkey.ShortcutsEnabled = true;
            this.tb_pubkey.Size = new System.Drawing.Size(843, 48);
            this.tb_pubkey.TabIndex = 78;
            this.tb_pubkey.TabStop = false;
            this.tb_pubkey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_pubkey.TrailingIcon = null;
            this.tb_pubkey.UseSystemPasswordChar = false;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(-9, 92);
            this.materialDivider2.Margin = new System.Windows.Forms.Padding(6);
            this.materialDivider2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(10, 535);
            this.materialDivider2.TabIndex = 83;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(901, 92);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(6);
            this.materialDivider1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(16, 535);
            this.materialDivider1.TabIndex = 82;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialTabControl2
            // 
            this.materialTabControl2.Controls.Add(this.tab_transfer);
            this.materialTabControl2.Controls.Add(this.tab_lock);
            this.materialTabControl2.Depth = 0;
            this.materialTabControl2.Location = new System.Drawing.Point(-9, 92);
            this.materialTabControl2.Margin = new System.Windows.Forms.Padding(0);
            this.materialTabControl2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialTabControl2.Multiline = true;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            this.materialTabControl2.Size = new System.Drawing.Size(923, 288);
            this.materialTabControl2.TabIndex = 80;
            this.materialTabControl2.SelectedIndexChanged += new System.EventHandler(this.materialTabControl2_SelectedIndexChanged);
            // 
            // tab_transfer
            // 
            this.tab_transfer.BackColor = System.Drawing.Color.White;
            this.tab_transfer.Controls.Add(this.tb_amount);
            this.tab_transfer.Controls.Add(this.cb_contacts);
            this.tab_transfer.Controls.Add(this.tb_address);
            this.tab_transfer.Location = new System.Drawing.Point(4, 33);
            this.tab_transfer.Margin = new System.Windows.Forms.Padding(6);
            this.tab_transfer.Name = "tab_transfer";
            this.tab_transfer.Padding = new System.Windows.Forms.Padding(6);
            this.tab_transfer.Size = new System.Drawing.Size(915, 251);
            this.tab_transfer.TabIndex = 0;
            this.tab_transfer.Text = "FirSt";
            // 
            // tab_lock
            // 
            this.tab_lock.BackColor = System.Drawing.Color.White;
            this.tab_lock.Controls.Add(this.cb_selflock);
            this.tab_lock.Controls.Add(this.tb_expire);
            this.tab_lock.Controls.Add(this.tb_pubkey);
            this.tab_lock.Controls.Add(this.tb_amount_lock);
            this.tab_lock.Location = new System.Drawing.Point(4, 33);
            this.tab_lock.Margin = new System.Windows.Forms.Padding(6);
            this.tab_lock.Name = "tab_lock";
            this.tab_lock.Padding = new System.Windows.Forms.Padding(6);
            this.tab_lock.Size = new System.Drawing.Size(915, 251);
            this.tab_lock.TabIndex = 1;
            this.tab_lock.Text = "seConD";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl2;
            this.materialTabSelector1.CharacterCasing = ReaLTaiizor.Controls.MaterialTabSelector.CustomCharacterCasing.Proper;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.HeadAlignment = ReaLTaiizor.Controls.MaterialTabSelector.Alignment.Center;
            this.materialTabSelector1.Location = new System.Drawing.Point(-9, 22);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(0);
            this.materialTabSelector1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.SelectorHideTabName = new string[0];
            this.materialTabSelector1.SelectorNonClickTabPage = new System.Windows.Forms.TabPage[0];
            this.materialTabSelector1.Size = new System.Drawing.Size(923, 70);
            this.materialTabSelector1.TabIndex = 81;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // TransferAndLockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(901, 470);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.bt_transfer);
            this.Controls.Add(this.materialTabControl2);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.bt_close);
            this.DrawerShowIconsWhenHidden = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(550, 369);
            this.Name = "TransferAndLockForm";
            this.Padding = new System.Windows.Forms.Padding(6, 118, 6, 6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AU-X Wallet";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.materialTabControl2.ResumeLayout(false);
            this.tab_transfer.ResumeLayout(false);
            this.tab_lock.ResumeLayout(false);
            this.tab_lock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialTextBoxEdit tb_amount;
        private MaterialButton bt_transfer;
        private MaterialTextBoxEdit tb_address;
        private MaterialButton bt_close;
        private MaterialComboBox cb_contacts;
        private MaterialTextBoxEdit tb_expire;
        private MaterialTextBoxEdit tb_amount_lock;
        private MaterialTextBoxEdit tb_pubkey;
        private MaterialCheckBox cb_selflock;
        private MaterialDivider materialDivider2;
        private MaterialDivider materialDivider1;
        private MaterialTabControl materialTabControl2;
        private System.Windows.Forms.TabPage tab_transfer;
        private System.Windows.Forms.TabPage tab_lock;
        private MaterialTabSelector materialTabSelector1;
    }
}