using ReaLTaiizor.Controls;
using System.Windows.Forms;

namespace AuxWallet
{
    partial class CreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForm));
            this.tf_walletpath = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.bt_new = new ReaLTaiizor.Controls.MaterialButton();
            this.bt_close = new ReaLTaiizor.Controls.MaterialButton();
            this.bt_select = new ReaLTaiizor.Controls.MaterialButton();
            this.tb_privateKey = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.tb_pwd = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // tf_walletpath
            // 
            this.tf_walletpath.AnimateReadOnly = false;
            this.tf_walletpath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tf_walletpath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tf_walletpath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tf_walletpath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tf_walletpath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tf_walletpath.Depth = 0;
            this.tf_walletpath.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tf_walletpath.HideSelection = true;
            this.tf_walletpath.Hint = "Type here";
            this.tf_walletpath.LeadingIcon = null;
            this.tf_walletpath.Location = new System.Drawing.Point(66, 109);
            this.tf_walletpath.Margin = new System.Windows.Forms.Padding(6);
            this.tf_walletpath.MaxLength = 0;
            this.tf_walletpath.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tf_walletpath.Name = "tf_walletpath";
            this.tf_walletpath.PasswordChar = '\0';
            this.tf_walletpath.PrefixSuffixText = null;
            this.tf_walletpath.ReadOnly = true;
            this.tf_walletpath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tf_walletpath.SelectedText = "";
            this.tf_walletpath.SelectionLength = 0;
            this.tf_walletpath.SelectionStart = 0;
            this.tf_walletpath.ShortcutsEnabled = true;
            this.tf_walletpath.Size = new System.Drawing.Size(503, 48);
            this.tf_walletpath.TabIndex = 71;
            this.tf_walletpath.TabStop = false;
            this.tf_walletpath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tf_walletpath.TrailingIcon = null;
            this.tf_walletpath.UseSystemPasswordChar = false;
            // 
            // bt_new
            // 
            this.bt_new.AutoSize = false;
            this.bt_new.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_new.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_new.Depth = 0;
            this.bt_new.HighEmphasis = false;
            this.bt_new.Icon = null;
            this.bt_new.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_new.Location = new System.Drawing.Point(305, 315);
            this.bt_new.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_new.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_new.Name = "bt_new";
            this.bt_new.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_new.Size = new System.Drawing.Size(250, 37);
            this.bt_new.TabIndex = 75;
            this.bt_new.Text = "TEXT - LOW - NORMAL";
            this.bt_new.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            this.bt_new.UseAccentColor = false;
            this.bt_new.UseVisualStyleBackColor = true;
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
            this.bt_close.Location = new System.Drawing.Point(569, 315);
            this.bt_close.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_close.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_close.Name = "bt_close";
            this.bt_close.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_close.Size = new System.Drawing.Size(250, 37);
            this.bt_close.TabIndex = 76;
            this.bt_close.Text = "TEXT - LOW - NORMAL";
            this.bt_close.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            this.bt_close.UseAccentColor = false;
            this.bt_close.UseVisualStyleBackColor = true;
            // 
            // bt_select
            // 
            this.bt_select.AutoSize = false;
            this.bt_select.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_select.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_select.Depth = 0;
            this.bt_select.HighEmphasis = false;
            this.bt_select.Icon = null;
            this.bt_select.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_select.Location = new System.Drawing.Point(633, 109);
            this.bt_select.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_select.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_select.Name = "bt_select";
            this.bt_select.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_select.Size = new System.Drawing.Size(186, 48);
            this.bt_select.TabIndex = 78;
            this.bt_select.Text = "CONT - LOW - NORMAL";
            this.bt_select.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bt_select.UseAccentColor = false;
            this.bt_select.UseVisualStyleBackColor = true;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // tb_privateKey
            // 
            this.tb_privateKey.AnimateReadOnly = false;
            this.tb_privateKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_privateKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_privateKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_privateKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_privateKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_privateKey.Depth = 0;
            this.tb_privateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_privateKey.HideSelection = true;
            this.tb_privateKey.Hint = "Type here";
            this.tb_privateKey.LeadingIcon = null;
            this.tb_privateKey.Location = new System.Drawing.Point(66, 238);
            this.tb_privateKey.Margin = new System.Windows.Forms.Padding(6);
            this.tb_privateKey.MaxLength = 0;
            this.tb_privateKey.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_privateKey.Name = "tb_privateKey";
            this.tb_privateKey.PasswordChar = '\0';
            this.tb_privateKey.PrefixSuffixText = null;
            this.tb_privateKey.ReadOnly = false;
            this.tb_privateKey.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_privateKey.SelectedText = "";
            this.tb_privateKey.SelectionLength = 0;
            this.tb_privateKey.SelectionStart = 0;
            this.tb_privateKey.ShortcutsEnabled = true;
            this.tb_privateKey.Size = new System.Drawing.Size(753, 48);
            this.tb_privateKey.TabIndex = 79;
            this.tb_privateKey.TabStop = false;
            this.tb_privateKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_privateKey.TrailingIcon = null;
            this.tb_privateKey.UseSystemPasswordChar = false;
            // 
            // tb_pwd
            // 
            this.tb_pwd.AnimateReadOnly = false;
            this.tb_pwd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_pwd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_pwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_pwd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_pwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_pwd.Depth = 0;
            this.tb_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_pwd.HideSelection = true;
            this.tb_pwd.Hint = "Password";
            this.tb_pwd.LeadingIcon = null;
            this.tb_pwd.Location = new System.Drawing.Point(66, 178);
            this.tb_pwd.Margin = new System.Windows.Forms.Padding(6);
            this.tb_pwd.MaxLength = 50;
            this.tb_pwd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '●';
            this.tb_pwd.PrefixSuffixText = null;
            this.tb_pwd.ReadOnly = false;
            this.tb_pwd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_pwd.SelectedText = "";
            this.tb_pwd.SelectionLength = 0;
            this.tb_pwd.SelectionStart = 0;
            this.tb_pwd.ShortcutsEnabled = true;
            this.tb_pwd.Size = new System.Drawing.Size(503, 48);
            this.tb_pwd.TabIndex = 80;
            this.tb_pwd.TabStop = false;
            this.tb_pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_pwd.TrailingIcon = null;
            this.tb_pwd.UseSystemPasswordChar = true;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 369);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.tb_privateKey);
            this.Controls.Add(this.bt_select);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_new);
            this.Controls.Add(this.tf_walletpath);
            this.DrawerShowIconsWhenHidden = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(550, 369);
            this.Name = "CreateForm";
            this.Padding = new System.Windows.Forms.Padding(6, 118, 6, 6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AU-X Wallet";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialTextBoxEdit tf_walletpath;
        private MaterialButton bt_new;
        private MaterialButton bt_close;
        private MaterialButton bt_select;
        private MaterialTextBoxEdit tb_privateKey;
        private MaterialTextBoxEdit tb_pwd;
        private SaveFileDialog saveFileDialog1;
    }
}