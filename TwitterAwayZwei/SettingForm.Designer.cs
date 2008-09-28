namespace TwitterAwayZwei
{
    partial class SettingForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.settingTabControl = new System.Windows.Forms.TabControl();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.timelineListFontSizeLabel = new System.Windows.Forms.Label();
            this.timelineListFontSizeDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.userTabPage = new System.Windows.Forms.TabPage();
            this.passwordTextBox = new OpenNETCF.Windows.Forms.TextBox2();
            this.passwordContextMenu = new System.Windows.Forms.ContextMenu();
            this.passwordCutMenuItem = new System.Windows.Forms.MenuItem();
            this.passwordCopyMenuItem = new System.Windows.Forms.MenuItem();
            this.passwordPasteMenuItem = new System.Windows.Forms.MenuItem();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new OpenNETCF.Windows.Forms.TextBox2();
            this.userNameContextMenu = new System.Windows.Forms.ContextMenu();
            this.userNameCutMenuItem = new System.Windows.Forms.MenuItem();
            this.userNameCopyMenuItem = new System.Windows.Forms.MenuItem();
            this.userNamePasteMenuItem = new System.Windows.Forms.MenuItem();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.timelineTabPage = new System.Windows.Forms.TabPage();
            this.fetchProfileIconsCheckBox = new System.Windows.Forms.CheckBox();
            this.checkDirectMessageIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.checkDirectMessageLabel = new System.Windows.Forms.Label();
            this.getListPanel = new System.Windows.Forms.Panel();
            this.checkPublicRadioButton = new System.Windows.Forms.RadioButton();
            this.checkFriendsRadioButton = new System.Windows.Forms.RadioButton();
            this.checkListLabel = new System.Windows.Forms.Label();
            this.checkTimelineIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.checkTimelineIntervalLabel = new System.Windows.Forms.Label();
            this.networkTabPage = new System.Windows.Forms.TabPage();
            this.proxySettingPanel = new System.Windows.Forms.Panel();
            this.manualProxySettingRadioButton = new System.Windows.Forms.RadioButton();
            this.proxyPortTextBox = new OpenNETCF.Windows.Forms.TextBox2();
            this.proxyPortContextMenu = new System.Windows.Forms.ContextMenu();
            this.proxyPortCutMenuItem = new System.Windows.Forms.MenuItem();
            this.proxyPortCopyMenuItem = new System.Windows.Forms.MenuItem();
            this.proxyPortPasteMenuItem = new System.Windows.Forms.MenuItem();
            this.autoDetectProxySettingRadioButton = new System.Windows.Forms.RadioButton();
            this.proxyServerTextBox = new OpenNETCF.Windows.Forms.TextBox2();
            this.proxyServerContextMenu = new System.Windows.Forms.ContextMenu();
            this.proxyServerCutMenuItem = new System.Windows.Forms.MenuItem();
            this.proxyServerCopyMenuItem = new System.Windows.Forms.MenuItem();
            this.proxyServerPasteMenuItem = new System.Windows.Forms.MenuItem();
            this.proxyNoUseRadioButton = new System.Windows.Forms.RadioButton();
            this.proxyPortLabel = new System.Windows.Forms.Label();
            this.proxyServerLabel = new System.Windows.Forms.Label();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.settingTabControl.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.userTabPage.SuspendLayout();
            this.timelineTabPage.SuspendLayout();
            this.getListPanel.SuspendLayout();
            this.networkTabPage.SuspendLayout();
            this.proxySettingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingTabControl
            // 
            this.settingTabControl.Controls.Add(this.generalTabPage);
            this.settingTabControl.Controls.Add(this.userTabPage);
            this.settingTabControl.Controls.Add(this.timelineTabPage);
            this.settingTabControl.Controls.Add(this.networkTabPage);
            resources.ApplyResources(this.settingTabControl, "settingTabControl");
            this.settingTabControl.Name = "settingTabControl";
            this.settingTabControl.SelectedIndex = 0;
            // 
            // generalTabPage
            // 
            this.generalTabPage.Controls.Add(this.timelineListFontSizeLabel);
            this.generalTabPage.Controls.Add(this.timelineListFontSizeDomainUpDown);
            resources.ApplyResources(this.generalTabPage, "generalTabPage");
            this.generalTabPage.Name = "generalTabPage";
            // 
            // timelineListFontSizeLabel
            // 
            resources.ApplyResources(this.timelineListFontSizeLabel, "timelineListFontSizeLabel");
            this.timelineListFontSizeLabel.Name = "timelineListFontSizeLabel";
            // 
            // timelineListFontSizeDomainUpDown
            // 
            resources.ApplyResources(this.timelineListFontSizeDomainUpDown, "timelineListFontSizeDomainUpDown");
            this.timelineListFontSizeDomainUpDown.Items.Add(resources.GetString("timelineListFontSizeDomainUpDown.Items"));
            this.timelineListFontSizeDomainUpDown.Items.Add(resources.GetString("timelineListFontSizeDomainUpDown.Items1"));
            this.timelineListFontSizeDomainUpDown.Items.Add(resources.GetString("timelineListFontSizeDomainUpDown.Items2"));
            this.timelineListFontSizeDomainUpDown.Items.Add(resources.GetString("timelineListFontSizeDomainUpDown.Items3"));
            this.timelineListFontSizeDomainUpDown.Items.Add(resources.GetString("timelineListFontSizeDomainUpDown.Items4"));
            this.timelineListFontSizeDomainUpDown.Items.Add(resources.GetString("timelineListFontSizeDomainUpDown.Items5"));
            this.timelineListFontSizeDomainUpDown.Items.Add(resources.GetString("timelineListFontSizeDomainUpDown.Items6"));
            this.timelineListFontSizeDomainUpDown.Items.Add(resources.GetString("timelineListFontSizeDomainUpDown.Items7"));
            this.timelineListFontSizeDomainUpDown.Items.Add(resources.GetString("timelineListFontSizeDomainUpDown.Items8"));
            this.timelineListFontSizeDomainUpDown.Items.Add(resources.GetString("timelineListFontSizeDomainUpDown.Items9"));
            this.timelineListFontSizeDomainUpDown.Items.Add(resources.GetString("timelineListFontSizeDomainUpDown.Items10"));
            this.timelineListFontSizeDomainUpDown.Items.Add(resources.GetString("timelineListFontSizeDomainUpDown.Items11"));
            this.timelineListFontSizeDomainUpDown.Items.Add(resources.GetString("timelineListFontSizeDomainUpDown.Items12"));
            this.timelineListFontSizeDomainUpDown.Items.Add(resources.GetString("timelineListFontSizeDomainUpDown.Items13"));
            this.timelineListFontSizeDomainUpDown.Items.Add(resources.GetString("timelineListFontSizeDomainUpDown.Items14"));
            this.timelineListFontSizeDomainUpDown.Items.Add(resources.GetString("timelineListFontSizeDomainUpDown.Items15"));
            this.timelineListFontSizeDomainUpDown.Name = "timelineListFontSizeDomainUpDown";
            this.timelineListFontSizeDomainUpDown.ReadOnly = true;
            // 
            // userTabPage
            // 
            this.userTabPage.Controls.Add(this.passwordTextBox);
            this.userTabPage.Controls.Add(this.passwordLabel);
            this.userTabPage.Controls.Add(this.userNameTextBox);
            this.userTabPage.Controls.Add(this.userNameLabel);
            resources.ApplyResources(this.userTabPage, "userTabPage");
            this.userTabPage.Name = "userTabPage";
            // 
            // passwordTextBox
            // 
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            this.passwordTextBox.ContextMenu = this.passwordContextMenu;
            this.passwordTextBox.Name = "passwordTextBox";
            // 
            // passwordContextMenu
            // 
            this.passwordContextMenu.MenuItems.Add(this.passwordCutMenuItem);
            this.passwordContextMenu.MenuItems.Add(this.passwordCopyMenuItem);
            this.passwordContextMenu.MenuItems.Add(this.passwordPasteMenuItem);
            // 
            // passwordCutMenuItem
            // 
            resources.ApplyResources(this.passwordCutMenuItem, "passwordCutMenuItem");
            this.passwordCutMenuItem.Click += new System.EventHandler(this.passwordCutMenuItem_Click);
            // 
            // passwordCopyMenuItem
            // 
            resources.ApplyResources(this.passwordCopyMenuItem, "passwordCopyMenuItem");
            this.passwordCopyMenuItem.Click += new System.EventHandler(this.passwordCopyMenuItem_Click);
            // 
            // passwordPasteMenuItem
            // 
            resources.ApplyResources(this.passwordPasteMenuItem, "passwordPasteMenuItem");
            this.passwordPasteMenuItem.Click += new System.EventHandler(this.passwordPasteMenuItem_Click);
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.Name = "passwordLabel";
            // 
            // userNameTextBox
            // 
            resources.ApplyResources(this.userNameTextBox, "userNameTextBox");
            this.userNameTextBox.ContextMenu = this.userNameContextMenu;
            this.userNameTextBox.Name = "userNameTextBox";
            // 
            // userNameContextMenu
            // 
            this.userNameContextMenu.MenuItems.Add(this.userNameCutMenuItem);
            this.userNameContextMenu.MenuItems.Add(this.userNameCopyMenuItem);
            this.userNameContextMenu.MenuItems.Add(this.userNamePasteMenuItem);
            // 
            // userNameCutMenuItem
            // 
            resources.ApplyResources(this.userNameCutMenuItem, "userNameCutMenuItem");
            this.userNameCutMenuItem.Click += new System.EventHandler(this.userNameCutMenuItem_Click);
            // 
            // userNameCopyMenuItem
            // 
            resources.ApplyResources(this.userNameCopyMenuItem, "userNameCopyMenuItem");
            this.userNameCopyMenuItem.Click += new System.EventHandler(this.userNameCopyMenuItem_Click);
            // 
            // userNamePasteMenuItem
            // 
            resources.ApplyResources(this.userNamePasteMenuItem, "userNamePasteMenuItem");
            this.userNamePasteMenuItem.Click += new System.EventHandler(this.userNamePasteMenuItem_Click);
            // 
            // userNameLabel
            // 
            resources.ApplyResources(this.userNameLabel, "userNameLabel");
            this.userNameLabel.Name = "userNameLabel";
            // 
            // timelineTabPage
            // 
            this.timelineTabPage.Controls.Add(this.fetchProfileIconsCheckBox);
            this.timelineTabPage.Controls.Add(this.checkDirectMessageIntervalNumericUpDown);
            this.timelineTabPage.Controls.Add(this.checkDirectMessageLabel);
            this.timelineTabPage.Controls.Add(this.getListPanel);
            this.timelineTabPage.Controls.Add(this.checkTimelineIntervalNumericUpDown);
            this.timelineTabPage.Controls.Add(this.checkTimelineIntervalLabel);
            resources.ApplyResources(this.timelineTabPage, "timelineTabPage");
            this.timelineTabPage.Name = "timelineTabPage";
            // 
            // fetchProfileIconsCheckBox
            // 
            resources.ApplyResources(this.fetchProfileIconsCheckBox, "fetchProfileIconsCheckBox");
            this.fetchProfileIconsCheckBox.Name = "fetchProfileIconsCheckBox";
            // 
            // checkDirectMessageIntervalNumericUpDown
            // 
            resources.ApplyResources(this.checkDirectMessageIntervalNumericUpDown, "checkDirectMessageIntervalNumericUpDown");
            this.checkDirectMessageIntervalNumericUpDown.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.checkDirectMessageIntervalNumericUpDown.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.checkDirectMessageIntervalNumericUpDown.Name = "checkDirectMessageIntervalNumericUpDown";
            this.checkDirectMessageIntervalNumericUpDown.ReadOnly = true;
            this.checkDirectMessageIntervalNumericUpDown.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // checkDirectMessageLabel
            // 
            resources.ApplyResources(this.checkDirectMessageLabel, "checkDirectMessageLabel");
            this.checkDirectMessageLabel.Name = "checkDirectMessageLabel";
            // 
            // getListPanel
            // 
            this.getListPanel.Controls.Add(this.checkPublicRadioButton);
            this.getListPanel.Controls.Add(this.checkFriendsRadioButton);
            this.getListPanel.Controls.Add(this.checkListLabel);
            resources.ApplyResources(this.getListPanel, "getListPanel");
            this.getListPanel.Name = "getListPanel";
            // 
            // checkPublicRadioButton
            // 
            resources.ApplyResources(this.checkPublicRadioButton, "checkPublicRadioButton");
            this.checkPublicRadioButton.Name = "checkPublicRadioButton";
            // 
            // checkFriendsRadioButton
            // 
            this.checkFriendsRadioButton.Checked = true;
            resources.ApplyResources(this.checkFriendsRadioButton, "checkFriendsRadioButton");
            this.checkFriendsRadioButton.Name = "checkFriendsRadioButton";
            // 
            // checkListLabel
            // 
            resources.ApplyResources(this.checkListLabel, "checkListLabel");
            this.checkListLabel.Name = "checkListLabel";
            // 
            // checkTimelineIntervalNumericUpDown
            // 
            resources.ApplyResources(this.checkTimelineIntervalNumericUpDown, "checkTimelineIntervalNumericUpDown");
            this.checkTimelineIntervalNumericUpDown.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.checkTimelineIntervalNumericUpDown.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.checkTimelineIntervalNumericUpDown.Name = "checkTimelineIntervalNumericUpDown";
            this.checkTimelineIntervalNumericUpDown.ReadOnly = true;
            this.checkTimelineIntervalNumericUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // checkTimelineIntervalLabel
            // 
            resources.ApplyResources(this.checkTimelineIntervalLabel, "checkTimelineIntervalLabel");
            this.checkTimelineIntervalLabel.Name = "checkTimelineIntervalLabel";
            // 
            // networkTabPage
            // 
            this.networkTabPage.Controls.Add(this.proxySettingPanel);
            resources.ApplyResources(this.networkTabPage, "networkTabPage");
            this.networkTabPage.Name = "networkTabPage";
            // 
            // proxySettingPanel
            // 
            resources.ApplyResources(this.proxySettingPanel, "proxySettingPanel");
            this.proxySettingPanel.Controls.Add(this.manualProxySettingRadioButton);
            this.proxySettingPanel.Controls.Add(this.proxyPortTextBox);
            this.proxySettingPanel.Controls.Add(this.autoDetectProxySettingRadioButton);
            this.proxySettingPanel.Controls.Add(this.proxyServerTextBox);
            this.proxySettingPanel.Controls.Add(this.proxyNoUseRadioButton);
            this.proxySettingPanel.Controls.Add(this.proxyPortLabel);
            this.proxySettingPanel.Controls.Add(this.proxyServerLabel);
            this.proxySettingPanel.Name = "proxySettingPanel";
            // 
            // manualProxySettingRadioButton
            // 
            resources.ApplyResources(this.manualProxySettingRadioButton, "manualProxySettingRadioButton");
            this.manualProxySettingRadioButton.Name = "manualProxySettingRadioButton";
            // 
            // proxyPortTextBox
            // 
            this.proxyPortTextBox.ContextMenu = this.proxyPortContextMenu;
            resources.ApplyResources(this.proxyPortTextBox, "proxyPortTextBox");
            this.proxyPortTextBox.Name = "proxyPortTextBox";
            // 
            // proxyPortContextMenu
            // 
            this.proxyPortContextMenu.MenuItems.Add(this.proxyPortCutMenuItem);
            this.proxyPortContextMenu.MenuItems.Add(this.proxyPortCopyMenuItem);
            this.proxyPortContextMenu.MenuItems.Add(this.proxyPortPasteMenuItem);
            // 
            // proxyPortCutMenuItem
            // 
            resources.ApplyResources(this.proxyPortCutMenuItem, "proxyPortCutMenuItem");
            this.proxyPortCutMenuItem.Click += new System.EventHandler(this.proxyPortCutMenuItem_Click);
            // 
            // proxyPortCopyMenuItem
            // 
            resources.ApplyResources(this.proxyPortCopyMenuItem, "proxyPortCopyMenuItem");
            this.proxyPortCopyMenuItem.Click += new System.EventHandler(this.proxyPortCopyMenuItem_Click);
            // 
            // proxyPortPasteMenuItem
            // 
            resources.ApplyResources(this.proxyPortPasteMenuItem, "proxyPortPasteMenuItem");
            this.proxyPortPasteMenuItem.Click += new System.EventHandler(this.proxyPortPasteMenuItem_Click);
            // 
            // autoDetectProxySettingRadioButton
            // 
            this.autoDetectProxySettingRadioButton.Checked = true;
            resources.ApplyResources(this.autoDetectProxySettingRadioButton, "autoDetectProxySettingRadioButton");
            this.autoDetectProxySettingRadioButton.Name = "autoDetectProxySettingRadioButton";
            // 
            // proxyServerTextBox
            // 
            this.proxyServerTextBox.ContextMenu = this.proxyServerContextMenu;
            resources.ApplyResources(this.proxyServerTextBox, "proxyServerTextBox");
            this.proxyServerTextBox.Name = "proxyServerTextBox";
            // 
            // proxyServerContextMenu
            // 
            this.proxyServerContextMenu.MenuItems.Add(this.proxyServerCutMenuItem);
            this.proxyServerContextMenu.MenuItems.Add(this.proxyServerCopyMenuItem);
            this.proxyServerContextMenu.MenuItems.Add(this.proxyServerPasteMenuItem);
            // 
            // proxyServerCutMenuItem
            // 
            resources.ApplyResources(this.proxyServerCutMenuItem, "proxyServerCutMenuItem");
            this.proxyServerCutMenuItem.Click += new System.EventHandler(this.proxyServerCutMenuItem_Click);
            // 
            // proxyServerCopyMenuItem
            // 
            resources.ApplyResources(this.proxyServerCopyMenuItem, "proxyServerCopyMenuItem");
            this.proxyServerCopyMenuItem.Click += new System.EventHandler(this.proxyServerCopyMenuItem_Click);
            // 
            // proxyServerPasteMenuItem
            // 
            resources.ApplyResources(this.proxyServerPasteMenuItem, "proxyServerPasteMenuItem");
            this.proxyServerPasteMenuItem.Click += new System.EventHandler(this.proxyServerPasteMenuItem_Click);
            // 
            // proxyNoUseRadioButton
            // 
            resources.ApplyResources(this.proxyNoUseRadioButton, "proxyNoUseRadioButton");
            this.proxyNoUseRadioButton.Name = "proxyNoUseRadioButton";
            // 
            // proxyPortLabel
            // 
            resources.ApplyResources(this.proxyPortLabel, "proxyPortLabel");
            this.proxyPortLabel.Name = "proxyPortLabel";
            // 
            // proxyServerLabel
            // 
            resources.ApplyResources(this.proxyServerLabel, "proxyServerLabel");
            this.proxyServerLabel.Name = "proxyServerLabel";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.settingTabControl);
            this.Menu = this.mainMenu1;
            this.Name = "SettingForm";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.SettingForm_Closing);
            this.settingTabControl.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.userTabPage.ResumeLayout(false);
            this.timelineTabPage.ResumeLayout(false);
            this.getListPanel.ResumeLayout(false);
            this.networkTabPage.ResumeLayout(false);
            this.proxySettingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl settingTabControl;
        private System.Windows.Forms.TabPage userTabPage;
        private OpenNETCF.Windows.Forms.TextBox2 passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private OpenNETCF.Windows.Forms.TextBox2 userNameTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TabPage networkTabPage;
        private System.Windows.Forms.Panel proxySettingPanel;
        private System.Windows.Forms.RadioButton manualProxySettingRadioButton;
        private OpenNETCF.Windows.Forms.TextBox2 proxyPortTextBox;
        private System.Windows.Forms.RadioButton autoDetectProxySettingRadioButton;
        private OpenNETCF.Windows.Forms.TextBox2 proxyServerTextBox;
        private System.Windows.Forms.RadioButton proxyNoUseRadioButton;
        private System.Windows.Forms.Label proxyPortLabel;
        private System.Windows.Forms.Label proxyServerLabel;
        private System.Windows.Forms.ContextMenu userNameContextMenu;
        private System.Windows.Forms.MenuItem userNameCutMenuItem;
        private System.Windows.Forms.MenuItem userNameCopyMenuItem;
        private System.Windows.Forms.MenuItem userNamePasteMenuItem;
        private System.Windows.Forms.ContextMenu passwordContextMenu;
        private System.Windows.Forms.MenuItem passwordCutMenuItem;
        private System.Windows.Forms.MenuItem passwordCopyMenuItem;
        private System.Windows.Forms.MenuItem passwordPasteMenuItem;
        private System.Windows.Forms.ContextMenu proxyServerContextMenu;
        private System.Windows.Forms.MenuItem proxyServerCutMenuItem;
        private System.Windows.Forms.MenuItem proxyServerCopyMenuItem;
        private System.Windows.Forms.MenuItem proxyServerPasteMenuItem;
        private System.Windows.Forms.ContextMenu proxyPortContextMenu;
        private System.Windows.Forms.MenuItem proxyPortCutMenuItem;
        private System.Windows.Forms.MenuItem proxyPortCopyMenuItem;
        private System.Windows.Forms.MenuItem proxyPortPasteMenuItem;
        private System.Windows.Forms.TabPage timelineTabPage;
        private System.Windows.Forms.NumericUpDown checkDirectMessageIntervalNumericUpDown;
        private System.Windows.Forms.Label checkDirectMessageLabel;
        private System.Windows.Forms.Panel getListPanel;
        private System.Windows.Forms.RadioButton checkPublicRadioButton;
        private System.Windows.Forms.RadioButton checkFriendsRadioButton;
        private System.Windows.Forms.Label checkListLabel;
        private System.Windows.Forms.NumericUpDown checkTimelineIntervalNumericUpDown;
        private System.Windows.Forms.Label checkTimelineIntervalLabel;
        private System.Windows.Forms.CheckBox fetchProfileIconsCheckBox;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.DomainUpDown timelineListFontSizeDomainUpDown;
        private System.Windows.Forms.Label timelineListFontSizeLabel;
        private System.Windows.Forms.MainMenu mainMenu1;
    }
}