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
            this.rb_nolock = new ReaLTaiizor.Controls.MetroRadioButton();
            this.rb_blocklock = new ReaLTaiizor.Controls.MetroRadioButton();
            this.tb_expire = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            this.tb_amount.Location = new System.Drawing.Point(66, 109);
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
            this.tb_amount.Size = new System.Drawing.Size(766, 48);
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
            this.bt_transfer.Location = new System.Drawing.Point(582, 391);
            this.bt_transfer.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_transfer.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_transfer.Name = "bt_transfer";
            this.bt_transfer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_transfer.Size = new System.Drawing.Size(250, 51);
            this.bt_transfer.TabIndex = 76;
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
            this.tb_address.Location = new System.Drawing.Point(66, 180);
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
            this.tb_address.Size = new System.Drawing.Size(766, 48);
            this.tb_address.TabIndex = 77;
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
            this.bt_close.Location = new System.Drawing.Point(308, 391);
            this.bt_close.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_close.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_close.Name = "bt_close";
            this.bt_close.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_close.Size = new System.Drawing.Size(250, 51);
            this.bt_close.TabIndex = 79;
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
            this.cb_contacts.Location = new System.Drawing.Point(66, 249);
            this.cb_contacts.Margin = new System.Windows.Forms.Padding(6);
            this.cb_contacts.MaxDropDownItems = 4;
            this.cb_contacts.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cb_contacts.Name = "cb_contacts";
            this.cb_contacts.Size = new System.Drawing.Size(766, 49);
            this.cb_contacts.StartIndex = 0;
            this.cb_contacts.TabIndex = 80;
            this.cb_contacts.SelectedIndexChanged += new System.EventHandler(this.cb_contacts_SelectedIndexChanged);
            // 
            // rb_nolock
            // 
            this.rb_nolock.BackgroundColor = System.Drawing.Color.White;
            this.rb_nolock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.rb_nolock.Checked = true;
            this.rb_nolock.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.rb_nolock.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Checked;
            this.rb_nolock.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.rb_nolock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_nolock.Group = 0;
            this.rb_nolock.IsDerivedStyle = true;
            this.rb_nolock.Location = new System.Drawing.Point(66, 323);
            this.rb_nolock.Name = "rb_nolock";
            this.rb_nolock.Size = new System.Drawing.Size(112, 17);
            this.rb_nolock.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.rb_nolock.StyleManager = null;
            this.rb_nolock.TabIndex = 81;
            this.rb_nolock.Text = "metroRadioButton1";
            this.rb_nolock.ThemeAuthor = "Taiizor";
            this.rb_nolock.ThemeName = "MetroLight";
            this.rb_nolock.CheckedChanged += new ReaLTaiizor.Controls.MetroRadioButton.CheckedChangedEventHandler(this.rb_nolock_CheckedChanged);
            // 
            // rb_blocklock
            // 
            this.rb_blocklock.BackgroundColor = System.Drawing.Color.White;
            this.rb_blocklock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.rb_blocklock.Checked = false;
            this.rb_blocklock.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.rb_blocklock.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.rb_blocklock.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.rb_blocklock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_blocklock.Group = 0;
            this.rb_blocklock.IsDerivedStyle = true;
            this.rb_blocklock.Location = new System.Drawing.Point(258, 323);
            this.rb_blocklock.Name = "rb_blocklock";
            this.rb_blocklock.Size = new System.Drawing.Size(112, 17);
            this.rb_blocklock.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.rb_blocklock.StyleManager = null;
            this.rb_blocklock.TabIndex = 82;
            this.rb_blocklock.Text = "metroRadioButton1";
            this.rb_blocklock.ThemeAuthor = "Taiizor";
            this.rb_blocklock.ThemeName = "MetroLight";
            this.rb_blocklock.CheckedChanged += new ReaLTaiizor.Controls.MetroRadioButton.CheckedChangedEventHandler(this.rb_nolock_CheckedChanged);
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
            this.tb_expire.Location = new System.Drawing.Point(418, 310);
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
            this.tb_expire.Size = new System.Drawing.Size(414, 48);
            this.tb_expire.TabIndex = 83;
            this.tb_expire.TabStop = false;
            this.tb_expire.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_expire.TrailingIcon = null;
            this.tb_expire.UseSystemPasswordChar = false;
            this.tb_expire.TextChanged += new System.EventHandler(this.tb_expire_TextChanged);
            // 
            // TransferAndLockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 475);
            this.Controls.Add(this.tb_expire);
            this.Controls.Add(this.rb_blocklock);
            this.Controls.Add(this.rb_nolock);
            this.Controls.Add(this.cb_contacts);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.bt_transfer);
            this.Controls.Add(this.tb_amount);
            this.DrawerShowIconsWhenHidden = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(550, 369);
            this.Name = "TransferAndLockForm";
            this.Padding = new System.Windows.Forms.Padding(6, 118, 6, 6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AU-X Wallet";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialTextBoxEdit tb_amount;
        private MaterialButton bt_transfer;
        private MaterialTextBoxEdit tb_address;
        private MaterialButton bt_close;
        private MaterialComboBox cb_contacts;
        private MetroRadioButton rb_nolock;
        private MetroRadioButton rb_blocklock;
        private MaterialTextBoxEdit tb_expire;
    }
}