using ReaLTaiizor.Controls;
using System.Windows.Forms;

namespace AuxWallet
{
    partial class VerifyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerifyForm));
            this.lb_title = new ReaLTaiizor.Controls.MaterialLabel();
            this.tb_pwd = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.tf_walletpath = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.bt_select = new ReaLTaiizor.Controls.MaterialButton();
            this.bt_open = new ReaLTaiizor.Controls.MaterialButton();
            this.bt_new = new ReaLTaiizor.Controls.MaterialButton();
            this.bt_close = new ReaLTaiizor.Controls.MaterialButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bt_import = new ReaLTaiizor.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_title.AutoSize = true;
            this.lb_title.Depth = 0;
            this.lb_title.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_title.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H3;
            this.lb_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_title.Location = new System.Drawing.Point(330, 158);
            this.lb_title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_title.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(217, 58);
            this.lb_title.TabIndex = 70;
            this.lb_title.Text = "Heading 3";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tb_pwd.Location = new System.Drawing.Point(66, 237);
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
            this.tb_pwd.TabIndex = 72;
            this.tb_pwd.TabStop = false;
            this.tb_pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_pwd.TrailingIcon = null;
            this.tb_pwd.UseSystemPasswordChar = true;
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
            this.tf_walletpath.Location = new System.Drawing.Point(66, 168);
            this.tf_walletpath.Margin = new System.Windows.Forms.Padding(6);
            this.tf_walletpath.MaxLength = 50;
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
            // bt_select
            // 
            this.bt_select.AutoSize = false;
            this.bt_select.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_select.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_select.Depth = 0;
            this.bt_select.HighEmphasis = false;
            this.bt_select.Icon = null;
            this.bt_select.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_select.Location = new System.Drawing.Point(636, 168);
            this.bt_select.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_select.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_select.Name = "bt_select";
            this.bt_select.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_select.Size = new System.Drawing.Size(186, 48);
            this.bt_select.TabIndex = 73;
            this.bt_select.Text = "CONT - LOW - NORMAL";
            this.bt_select.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bt_select.UseAccentColor = false;
            this.bt_select.UseVisualStyleBackColor = true;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // bt_open
            // 
            this.bt_open.AutoSize = false;
            this.bt_open.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_open.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_open.Depth = 0;
            this.bt_open.HighEmphasis = false;
            this.bt_open.Icon = null;
            this.bt_open.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_open.Location = new System.Drawing.Point(636, 237);
            this.bt_open.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_open.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_open.Name = "bt_open";
            this.bt_open.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_open.Size = new System.Drawing.Size(186, 48);
            this.bt_open.TabIndex = 74;
            this.bt_open.Text = "CONT - LOW - NORMAL";
            this.bt_open.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bt_open.UseAccentColor = false;
            this.bt_open.UseVisualStyleBackColor = true;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
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
            this.bt_new.Location = new System.Drawing.Point(250, 315);
            this.bt_new.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_new.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_new.Name = "bt_new";
            this.bt_new.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_new.Size = new System.Drawing.Size(138, 37);
            this.bt_new.TabIndex = 75;
            this.bt_new.Text = "TEXT - LOW - NORMAL";
            this.bt_new.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            this.bt_new.UseAccentColor = false;
            this.bt_new.UseVisualStyleBackColor = true;
            this.bt_new.Click += new System.EventHandler(this.bt_new_Click);
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
            this.bt_close.Location = new System.Drawing.Point(431, 315);
            this.bt_close.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_close.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_close.Name = "bt_close";
            this.bt_close.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_close.Size = new System.Drawing.Size(138, 37);
            this.bt_close.TabIndex = 76;
            this.bt_close.Text = "TEXT - LOW - NORMAL";
            this.bt_close.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            this.bt_close.UseAccentColor = false;
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bt_import
            // 
            this.bt_import.AutoSize = false;
            this.bt_import.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_import.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_import.Depth = 0;
            this.bt_import.HighEmphasis = false;
            this.bt_import.Icon = null;
            this.bt_import.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_import.Location = new System.Drawing.Point(66, 315);
            this.bt_import.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_import.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_import.Name = "bt_import";
            this.bt_import.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_import.Size = new System.Drawing.Size(138, 37);
            this.bt_import.TabIndex = 77;
            this.bt_import.Text = "TEXT - LOW - NORMAL";
            this.bt_import.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            this.bt_import.UseAccentColor = false;
            this.bt_import.UseVisualStyleBackColor = true;
            this.bt_import.Click += new System.EventHandler(this.bt_import_Click);
            // 
            // VerifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 369);
            this.Controls.Add(this.bt_import);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_new);
            this.Controls.Add(this.bt_open);
            this.Controls.Add(this.bt_select);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.tf_walletpath);
            this.Controls.Add(this.lb_title);
            this.DrawerShowIconsWhenHidden = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(550, 369);
            this.Name = "VerifyForm";
            this.Padding = new System.Windows.Forms.Padding(6, 118, 6, 6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AU-X Wallet";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialLabel lb_title;
        private MaterialTextBoxEdit tb_pwd;
        private MaterialTextBoxEdit tf_walletpath;
        private MaterialButton bt_select;
        private MaterialButton bt_open;
        private MaterialButton bt_new;
        private MaterialButton bt_close;
        private OpenFileDialog openFileDialog1;
        private MaterialButton bt_import;
    }
}