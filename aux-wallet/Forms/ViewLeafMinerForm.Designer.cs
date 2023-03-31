using ReaLTaiizor.Controls;
using System.Windows.Forms;

namespace AuxWallet
{
    partial class ViewLeafMinerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLeafMinerForm));
            this.tb_holderAddress = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.tb_seedAddress = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.bt_close = new ReaLTaiizor.Controls.MaterialButton();
            this.bt_copyHolder = new ReaLTaiizor.Controls.MaterialButton();
            this.bt_copySeed = new ReaLTaiizor.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // tb_holderAddress
            // 
            this.tb_holderAddress.AnimateReadOnly = false;
            this.tb_holderAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_holderAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_holderAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_holderAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_holderAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_holderAddress.Depth = 0;
            this.tb_holderAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_holderAddress.HideSelection = true;
            this.tb_holderAddress.Hint = "Type here";
            this.tb_holderAddress.LeadingIcon = null;
            this.tb_holderAddress.Location = new System.Drawing.Point(66, 109);
            this.tb_holderAddress.Margin = new System.Windows.Forms.Padding(6);
            this.tb_holderAddress.MaxLength = 0;
            this.tb_holderAddress.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_holderAddress.Name = "tb_holderAddress";
            this.tb_holderAddress.PasswordChar = '\0';
            this.tb_holderAddress.PrefixSuffixText = null;
            this.tb_holderAddress.ReadOnly = true;
            this.tb_holderAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_holderAddress.SelectedText = "";
            this.tb_holderAddress.SelectionLength = 0;
            this.tb_holderAddress.SelectionStart = 0;
            this.tb_holderAddress.ShortcutsEnabled = true;
            this.tb_holderAddress.Size = new System.Drawing.Size(572, 48);
            this.tb_holderAddress.TabIndex = 71;
            this.tb_holderAddress.TabStop = false;
            this.tb_holderAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_holderAddress.TrailingIcon = null;
            this.tb_holderAddress.UseSystemPasswordChar = false;
            // 
            // tb_seedAddress
            // 
            this.tb_seedAddress.AnimateReadOnly = false;
            this.tb_seedAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_seedAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_seedAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_seedAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_seedAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_seedAddress.Depth = 0;
            this.tb_seedAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_seedAddress.HideSelection = true;
            this.tb_seedAddress.Hint = "Type here";
            this.tb_seedAddress.LeadingIcon = null;
            this.tb_seedAddress.Location = new System.Drawing.Point(66, 180);
            this.tb_seedAddress.Margin = new System.Windows.Forms.Padding(6);
            this.tb_seedAddress.MaxLength = 0;
            this.tb_seedAddress.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_seedAddress.Name = "tb_seedAddress";
            this.tb_seedAddress.PasswordChar = '\0';
            this.tb_seedAddress.PrefixSuffixText = null;
            this.tb_seedAddress.ReadOnly = true;
            this.tb_seedAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_seedAddress.SelectedText = "";
            this.tb_seedAddress.SelectionLength = 0;
            this.tb_seedAddress.SelectionStart = 0;
            this.tb_seedAddress.ShortcutsEnabled = true;
            this.tb_seedAddress.Size = new System.Drawing.Size(572, 48);
            this.tb_seedAddress.TabIndex = 77;
            this.tb_seedAddress.TabStop = false;
            this.tb_seedAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_seedAddress.TrailingIcon = null;
            this.tb_seedAddress.UseSystemPasswordChar = false;
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
            this.bt_close.Location = new System.Drawing.Point(683, 315);
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
            // bt_copyHolder
            // 
            this.bt_copyHolder.AutoSize = false;
            this.bt_copyHolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_copyHolder.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_copyHolder.Depth = 0;
            this.bt_copyHolder.HighEmphasis = false;
            this.bt_copyHolder.Icon = null;
            this.bt_copyHolder.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_copyHolder.Location = new System.Drawing.Point(683, 106);
            this.bt_copyHolder.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_copyHolder.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_copyHolder.Name = "bt_copyHolder";
            this.bt_copyHolder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_copyHolder.Size = new System.Drawing.Size(250, 51);
            this.bt_copyHolder.TabIndex = 80;
            this.bt_copyHolder.Text = "TEXT - LOW - NORMAL";
            this.bt_copyHolder.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            this.bt_copyHolder.UseAccentColor = false;
            this.bt_copyHolder.UseVisualStyleBackColor = true;
            this.bt_copyHolder.Click += new System.EventHandler(this.bt_copyHolder_Click);
            // 
            // bt_copySeed
            // 
            this.bt_copySeed.AutoSize = false;
            this.bt_copySeed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_copySeed.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_copySeed.Depth = 0;
            this.bt_copySeed.HighEmphasis = false;
            this.bt_copySeed.Icon = null;
            this.bt_copySeed.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_copySeed.Location = new System.Drawing.Point(683, 177);
            this.bt_copySeed.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_copySeed.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_copySeed.Name = "bt_copySeed";
            this.bt_copySeed.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_copySeed.Size = new System.Drawing.Size(250, 51);
            this.bt_copySeed.TabIndex = 81;
            this.bt_copySeed.Text = "TEXT - LOW - NORMAL";
            this.bt_copySeed.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            this.bt_copySeed.UseAccentColor = false;
            this.bt_copySeed.UseVisualStyleBackColor = true;
            this.bt_copySeed.Click += new System.EventHandler(this.bt_copySeed_Click);
            // 
            // ViewLeafMinerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(963, 383);
            this.Controls.Add(this.bt_copySeed);
            this.Controls.Add(this.bt_copyHolder);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.tb_seedAddress);
            this.Controls.Add(this.tb_holderAddress);
            this.DrawerShowIconsWhenHidden = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(550, 369);
            this.Name = "ViewLeafMinerForm";
            this.Padding = new System.Windows.Forms.Padding(6, 118, 6, 6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AU-X Wallet";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialTextBoxEdit tb_holderAddress;
        private MaterialTextBoxEdit tb_seedAddress;
        private MaterialButton bt_close;
        private MaterialButton bt_copyHolder;
        private MaterialButton bt_copySeed;
    }
}