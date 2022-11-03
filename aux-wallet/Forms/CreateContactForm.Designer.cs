using ReaLTaiizor.Controls;
using System.Windows.Forms;

namespace AuxWallet
{
    partial class CreateContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateContactForm));
            this.tb_addr = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.bt_Add = new ReaLTaiizor.Controls.MaterialButton();
            this.tb_name = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.tb_remark = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.SuspendLayout();
            // 
            // tb_addr
            // 
            this.tb_addr.AnimateReadOnly = false;
            this.tb_addr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_addr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_addr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_addr.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_addr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_addr.Depth = 0;
            this.tb_addr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_addr.HideSelection = true;
            this.tb_addr.Hint = "Type here";
            this.tb_addr.LeadingIcon = null;
            this.tb_addr.Location = new System.Drawing.Point(66, 109);
            this.tb_addr.Margin = new System.Windows.Forms.Padding(6);
            this.tb_addr.MaxLength = 0;
            this.tb_addr.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_addr.Name = "tb_addr";
            this.tb_addr.PasswordChar = '\0';
            this.tb_addr.PrefixSuffixText = null;
            this.tb_addr.ReadOnly = false;
            this.tb_addr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_addr.SelectedText = "";
            this.tb_addr.SelectionLength = 0;
            this.tb_addr.SelectionStart = 0;
            this.tb_addr.ShortcutsEnabled = true;
            this.tb_addr.Size = new System.Drawing.Size(766, 48);
            this.tb_addr.TabIndex = 71;
            this.tb_addr.TabStop = false;
            this.tb_addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_addr.TrailingIcon = null;
            this.tb_addr.UseSystemPasswordChar = false;
            // 
            // bt_Add
            // 
            this.bt_Add.AutoSize = false;
            this.bt_Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_Add.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_Add.Depth = 0;
            this.bt_Add.HighEmphasis = false;
            this.bt_Add.Icon = null;
            this.bt_Add.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_Add.Location = new System.Drawing.Point(569, 315);
            this.bt_Add.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_Add.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_Add.Size = new System.Drawing.Size(250, 51);
            this.bt_Add.TabIndex = 76;
            this.bt_Add.Text = "TEXT - LOW - NORMAL";
            this.bt_Add.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            this.bt_Add.UseAccentColor = false;
            this.bt_Add.UseVisualStyleBackColor = true;
            // 
            // bt_name
            // 
            this.tb_name.AnimateReadOnly = false;
            this.tb_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_name.Depth = 0;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_name.HideSelection = true;
            this.tb_name.Hint = "Type here";
            this.tb_name.LeadingIcon = null;
            this.tb_name.Location = new System.Drawing.Point(66, 180);
            this.tb_name.Margin = new System.Windows.Forms.Padding(6);
            this.tb_name.MaxLength = 0;
            this.tb_name.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_name.Name = "bt_name";
            this.tb_name.PasswordChar = '\0';
            this.tb_name.PrefixSuffixText = null;
            this.tb_name.ReadOnly = false;
            this.tb_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_name.SelectedText = "";
            this.tb_name.SelectionLength = 0;
            this.tb_name.SelectionStart = 0;
            this.tb_name.ShortcutsEnabled = true;
            this.tb_name.Size = new System.Drawing.Size(766, 48);
            this.tb_name.TabIndex = 77;
            this.tb_name.TabStop = false;
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_name.TrailingIcon = null;
            this.tb_name.UseSystemPasswordChar = false;
            // 
            // bt_remark
            // 
            this.tb_remark.AnimateReadOnly = false;
            this.tb_remark.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_remark.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_remark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_remark.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_remark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_remark.Depth = 0;
            this.tb_remark.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_remark.HideSelection = true;
            this.tb_remark.Hint = "Type here";
            this.tb_remark.LeadingIcon = null;
            this.tb_remark.Location = new System.Drawing.Point(66, 250);
            this.tb_remark.Margin = new System.Windows.Forms.Padding(6);
            this.tb_remark.MaxLength = 0;
            this.tb_remark.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.tb_remark.Name = "bt_remark";
            this.tb_remark.PasswordChar = '\0';
            this.tb_remark.PrefixSuffixText = null;
            this.tb_remark.ReadOnly = false;
            this.tb_remark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_remark.SelectedText = "";
            this.tb_remark.SelectionLength = 0;
            this.tb_remark.SelectionStart = 0;
            this.tb_remark.ShortcutsEnabled = true;
            this.tb_remark.Size = new System.Drawing.Size(766, 48);
            this.tb_remark.TabIndex = 78;
            this.tb_remark.TabStop = false;
            this.tb_remark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_remark.TrailingIcon = null;
            this.tb_remark.UseSystemPasswordChar = false;
            // 
            // CreateContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 383);
            this.Controls.Add(this.tb_remark);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.tb_addr);
            this.DrawerShowIconsWhenHidden = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(550, 369);
            this.Name = "CreateContactForm";
            this.Padding = new System.Windows.Forms.Padding(6, 118, 6, 6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AU-X Wallet";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialTextBoxEdit tb_addr;
        private MaterialButton bt_Add;
        private MaterialTextBoxEdit tb_name;
        private MaterialTextBoxEdit tb_remark;
    }
}