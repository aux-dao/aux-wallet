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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            this.tabAsset = new System.Windows.Forms.TabPage();
            this.lb_assets = new ReaLTaiizor.Controls.MaterialListBox();
            this.tabContacts = new System.Windows.Forms.TabPage();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.bt_signout = new ReaLTaiizor.Controls.MaterialButton();
            this.bt_changeTheme = new ReaLTaiizor.Controls.MaterialButton();
            this.menuIconList = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabAsset.SuspendLayout();
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
            this.materialTabControl1.ImageList = this.menuIconList;
            this.materialTabControl1.Location = new System.Drawing.Point(6, 118);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(992, 659);
            this.materialTabControl1.TabIndex = 18;
            // 
            // tabAsset
            // 
            this.tabAsset.BackColor = System.Drawing.Color.White;
            this.tabAsset.Controls.Add(this.lb_assets);
            this.tabAsset.ImageKey = "round_assessment_white_24dp.png";
            this.tabAsset.Location = new System.Drawing.Point(4, 33);
            this.tabAsset.Margin = new System.Windows.Forms.Padding(6);
            this.tabAsset.Name = "tabAsset";
            this.tabAsset.Size = new System.Drawing.Size(984, 622);
            this.tabAsset.TabIndex = 0;
            this.tabAsset.Text = "Asset";
            // 
            // lb_assets
            // 
            this.lb_assets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_assets.BackColor = System.Drawing.Color.White;
            this.lb_assets.BorderColor = System.Drawing.Color.LightGray;
            this.lb_assets.Depth = 0;
            this.lb_assets.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_assets.Location = new System.Drawing.Point(6, 31);
            this.lb_assets.Margin = new System.Windows.Forms.Padding(6);
            this.lb_assets.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lb_assets.Name = "lb_assets";
            this.lb_assets.SelectedIndex = -1;
            this.lb_assets.SelectedItem = null;
            this.lb_assets.Size = new System.Drawing.Size(972, 585);
            this.lb_assets.Style = ReaLTaiizor.Controls.MaterialListBox.ListBoxStyle.ThreeLine;
            this.lb_assets.TabIndex = 3;
            // 
            // tabContacts
            // 
            this.tabContacts.BackColor = System.Drawing.Color.White;
            this.tabContacts.ImageKey = "round_person_black_24dp.png";
            this.tabContacts.Location = new System.Drawing.Point(4, 33);
            this.tabContacts.Margin = new System.Windows.Forms.Padding(6);
            this.tabContacts.Name = "tabContacts";
            this.tabContacts.Padding = new System.Windows.Forms.Padding(6);
            this.tabContacts.Size = new System.Drawing.Size(984, 622);
            this.tabContacts.TabIndex = 6;
            this.tabContacts.Text = "Contacts";
            // 
            // tabHistory
            // 
            this.tabHistory.BackColor = System.Drawing.Color.White;
            this.tabHistory.ImageKey = "round_swap_vert_white_24dp.png";
            this.tabHistory.Location = new System.Drawing.Point(4, 33);
            this.tabHistory.Margin = new System.Windows.Forms.Padding(6);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(6);
            this.tabHistory.Size = new System.Drawing.Size(984, 622);
            this.tabHistory.TabIndex = 1;
            this.tabHistory.Text = "History";
            // 
            // tabSetting
            // 
            this.tabSetting.BackColor = System.Drawing.Color.White;
            this.tabSetting.Controls.Add(this.bt_signout);
            this.tabSetting.Controls.Add(this.bt_changeTheme);
            this.tabSetting.ImageKey = "round_build_white_24dp.png";
            this.tabSetting.Location = new System.Drawing.Point(4, 33);
            this.tabSetting.Margin = new System.Windows.Forms.Padding(6);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Padding = new System.Windows.Forms.Padding(6);
            this.tabSetting.Size = new System.Drawing.Size(984, 622);
            this.tabSetting.TabIndex = 2;
            this.tabSetting.Text = "Setting";
            // 
            // bt_signout
            // 
            this.bt_signout.AutoSize = false;
            this.bt_signout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_signout.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_signout.Depth = 0;
            this.bt_signout.HighEmphasis = true;
            this.bt_signout.Icon = null;
            this.bt_signout.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_signout.Location = new System.Drawing.Point(446, 11);
            this.bt_signout.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_signout.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_signout.Name = "bt_signout";
            this.bt_signout.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_signout.Size = new System.Drawing.Size(346, 53);
            this.bt_signout.TabIndex = 16;
            this.bt_signout.Text = "OUTLINE - HIGH - NORMAL";
            this.bt_signout.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.bt_signout.UseAccentColor = false;
            this.bt_signout.UseVisualStyleBackColor = true;
            this.bt_signout.Click += new System.EventHandler(this.bt_signout_Click);
            // 
            // bt_changeTheme
            // 
            this.bt_changeTheme.AutoSize = false;
            this.bt_changeTheme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_changeTheme.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_changeTheme.Depth = 0;
            this.bt_changeTheme.HighEmphasis = true;
            this.bt_changeTheme.Icon = null;
            this.bt_changeTheme.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.bt_changeTheme.Location = new System.Drawing.Point(51, 11);
            this.bt_changeTheme.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.bt_changeTheme.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.bt_changeTheme.Name = "bt_changeTheme";
            this.bt_changeTheme.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_changeTheme.Size = new System.Drawing.Size(346, 53);
            this.bt_changeTheme.TabIndex = 15;
            this.bt_changeTheme.Text = "OUTLINE - HIGH - NORMAL";
            this.bt_changeTheme.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.bt_changeTheme.UseAccentColor = false;
            this.bt_changeTheme.UseVisualStyleBackColor = true;
            this.bt_changeTheme.Click += new System.EventHandler(this.materialButton7_Click);
            // 
            // menuIconList
            // 
            this.menuIconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.menuIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuIconList.ImageStream")));
            this.menuIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.menuIconList.Images.SetKeyName(0, "round_assessment_white_24dp.png");
            this.menuIconList.Images.SetKeyName(1, "round_backup_white_24dp.png");
            this.menuIconList.Images.SetKeyName(2, "round_bluetooth_white_24dp.png");
            this.menuIconList.Images.SetKeyName(3, "round_bookmark_white_24dp.png");
            this.menuIconList.Images.SetKeyName(4, "round_build_white_24dp.png");
            this.menuIconList.Images.SetKeyName(5, "round_gps_fixed_white_24dp.png");
            this.menuIconList.Images.SetKeyName(6, "round_http_white_24dp.png");
            this.menuIconList.Images.SetKeyName(7, "round_report_problem_white_24dp.png");
            this.menuIconList.Images.SetKeyName(8, "round_swap_vert_white_24dp.png");
            this.menuIconList.Images.SetKeyName(9, "round_phone_black_24dp.png");
            this.menuIconList.Images.SetKeyName(10, "round_push_pin_black_24dp.png");
            this.menuIconList.Images.SetKeyName(11, "round_mail_outline_black_24dp.png");
            this.menuIconList.Images.SetKeyName(12, "round_person_black_24dp.png");
            this.menuIconList.Images.SetKeyName(13, "round_add_a_photo_black_24dp.png");
            this.menuIconList.Images.SetKeyName(14, "round_alternate_email_black_24dp.png");
            this.menuIconList.Images.SetKeyName(15, "round_cancel_black_24dp.png");
            this.menuIconList.Images.SetKeyName(16, "round_error_black_24dp.png");
            this.menuIconList.Images.SetKeyName(17, "round_event_black_24dp.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 783);
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
            this.tabAsset.ResumeLayout(false);
            this.tabSetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabAsset;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.TabPage tabSetting;
        private System.Windows.Forms.TabPage tabContacts;
        private ImageList menuIconList;
        private MaterialListBox lb_assets;
        private MaterialButton bt_changeTheme;
        private MaterialButton bt_signout;
    }
}