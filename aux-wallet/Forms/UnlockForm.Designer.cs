using ReaLTaiizor.Controls;
using System.Windows.Forms;

namespace AuxWallet
{
    partial class UnlockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnlockForm));
            this.tb_amount = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.bt_transfer = new ReaLTaiizor.Controls.MaterialButton();
            this.tb_assetname = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.bt_close = new ReaLTaiizor.Controls.MaterialButton();
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
            this.tb_amount.ReadOnly = true;
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
            this.bt_transfer.Location = new System.Drawing.Point(569, 315);
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
            // tb_assetname
            // 
            this.tb_assetname.AnimateReadOnly = false;
            this.tb_assetname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_assetname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_assetname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_assetname.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_assetname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_assetname.Depth = 0;
            this.tb_assetname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_assetname.HideSelection = true;
            this.tb_assetname.Hint = "Type here";
            this.tb_assetname.LeadingIcon = null;
            this.tb_assetname.Location = new System.Drawing.Point(66, 180);
            this.tb_assetname.Margin = new System.Windows.Forms.Padding(6);
            this.tb_assetname.MaxLength = 0;
            this.tb_assetname.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_assetname.Name = "tb_assetname";
            this.tb_assetname.PasswordChar = '\0';
            this.tb_assetname.PrefixSuffixText = null;
            this.tb_assetname.ReadOnly = true;
            this.tb_assetname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_assetname.SelectedText = "";
            this.tb_assetname.SelectionLength = 0;
            this.tb_assetname.SelectionStart = 0;
            this.tb_assetname.ShortcutsEnabled = true;
            this.tb_assetname.Size = new System.Drawing.Size(766, 48);
            this.tb_assetname.TabIndex = 77;
            this.tb_assetname.TabStop = false;
            this.tb_assetname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_assetname.TrailingIcon = null;
            this.tb_assetname.UseSystemPasswordChar = false;
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
            this.bt_close.Location = new System.Drawing.Point(295, 315);
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
            // UnlockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 383);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.tb_assetname);
            this.Controls.Add(this.bt_transfer);
            this.Controls.Add(this.tb_amount);
            this.DrawerShowIconsWhenHidden = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(550, 369);
            this.Name = "UnlockForm";
            this.Padding = new System.Windows.Forms.Padding(6, 118, 6, 6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AU-X Wallet";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialTextBoxEdit tb_amount;
        private MaterialButton bt_transfer;
        private MaterialTextBoxEdit tb_assetname;
        private MaterialButton bt_close;
    }
}