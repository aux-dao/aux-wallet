using ReaLTaiizor.Controls;
using System.Windows.Forms;

namespace AuxWallet
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            this.tabAsset = new System.Windows.Forms.TabPage();
            this.tabContacts = new System.Windows.Forms.TabPage();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.materialButton7 = new ReaLTaiizor.Controls.MaterialButton();
            this.materialTabControl1.SuspendLayout();
            this.tabSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabAsset);
            this.materialTabControl1.Controls.Add(this.tabContacts);
            this.materialTabControl1.Controls.Add(this.tabHistory);
            this.materialTabControl1.Controls.Add(this.tabSetting);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(6, 118);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1407, 1093);
            this.materialTabControl1.TabIndex = 18;
            // 
            // tabAsset
            // 
            this.tabAsset.BackColor = System.Drawing.Color.White;
            this.tabAsset.ImageKey = "round_assessment_white_24dp.png";
            this.tabAsset.Location = new System.Drawing.Point(4, 33);
            this.tabAsset.Margin = new System.Windows.Forms.Padding(6);
            this.tabAsset.Name = "tabAsset";
            this.tabAsset.Size = new System.Drawing.Size(1399, 1056);
            this.tabAsset.TabIndex = 0;
            this.tabAsset.Text = "Asset";
            // 
            // tabContacts
            // 
            this.tabContacts.BackColor = System.Drawing.Color.White;
            this.tabContacts.ImageKey = "round_gps_fixed_white_24dp.png";
            this.tabContacts.Location = new System.Drawing.Point(4, 33);
            this.tabContacts.Margin = new System.Windows.Forms.Padding(6);
            this.tabContacts.Name = "tabContacts";
            this.tabContacts.Padding = new System.Windows.Forms.Padding(6);
            this.tabContacts.Size = new System.Drawing.Size(1399, 1056);
            this.tabContacts.TabIndex = 6;
            this.tabContacts.Text = "Contacts";
            // 
            // tabHistory
            // 
            this.tabHistory.BackColor = System.Drawing.Color.White;
            this.tabHistory.ImageKey = "round_bluetooth_white_24dp.png";
            this.tabHistory.Location = new System.Drawing.Point(4, 33);
            this.tabHistory.Margin = new System.Windows.Forms.Padding(6);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(6);
            this.tabHistory.Size = new System.Drawing.Size(1399, 1056);
            this.tabHistory.TabIndex = 1;
            this.tabHistory.Text = "History";
            // 
            // tabSetting
            // 
            this.tabSetting.BackColor = System.Drawing.Color.White;
            this.tabSetting.Controls.Add(this.materialButton7);
            this.tabSetting.ImageKey = "round_build_white_24dp.png";
            this.tabSetting.Location = new System.Drawing.Point(4, 33);
            this.tabSetting.Margin = new System.Windows.Forms.Padding(6);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Padding = new System.Windows.Forms.Padding(6);
            this.tabSetting.Size = new System.Drawing.Size(1399, 1056);
            this.tabSetting.TabIndex = 2;
            this.tabSetting.Text = "Setting";
            // 
            // materialButton7
            // 
            this.materialButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton7.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton7.Depth = 0;
            this.materialButton7.HighEmphasis = true;
            this.materialButton7.Icon = null;
            this.materialButton7.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton7.Location = new System.Drawing.Point(117, 69);
            this.materialButton7.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.materialButton7.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton7.Name = "materialButton7";
            this.materialButton7.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton7.Size = new System.Drawing.Size(133, 36);
            this.materialButton7.TabIndex = 1;
            this.materialButton7.Text = "Change Theme";
            this.materialButton7.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton7.UseAccentColor = false;
            this.materialButton7.UseVisualStyleBackColor = true;
            this.materialButton7.Click += new System.EventHandler(this.materialButton7_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1419, 1217);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(550, 369);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(6, 118, 6, 6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AU-X Wallet";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabSetting.ResumeLayout(false);
            this.tabSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabAsset;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.TabPage tabSetting;
        private System.Windows.Forms.TabPage tabContacts;
        private MaterialButton materialButton7;
    }
}