namespace TwitterAwayZwei
{
    partial class SettingForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.settingTabControl = new System.Windows.Forms.TabControl();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.getListPanel = new System.Windows.Forms.Panel();
            this.checkPublicRadioButton = new System.Windows.Forms.RadioButton();
            this.checkFriendsRadioButton = new System.Windows.Forms.RadioButton();
            this.checkListLabel = new System.Windows.Forms.Label();
            this.checkTimelineIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.checkTimelineIntervalLabel = new System.Windows.Forms.Label();
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
            this.networkTabPage = new System.Windows.Forms.TabPage();
            this.proxySettingPanel = new System.Windows.Forms.Panel();
            this.proxyUseOriginalSettingRadioButton = new System.Windows.Forms.RadioButton();
            this.proxyPortTextBox = new OpenNETCF.Windows.Forms.TextBox2();
            this.proxyPortContextMenu = new System.Windows.Forms.ContextMenu();
            this.proxyPortCutMenuItem = new System.Windows.Forms.MenuItem();
            this.proxyPortCopyMenuItem = new System.Windows.Forms.MenuItem();
            this.proxyPortPasteMenuItem = new System.Windows.Forms.MenuItem();
            this.proxyUseOsSettingRadioButton = new System.Windows.Forms.RadioButton();
            this.proxyServerTextBox = new OpenNETCF.Windows.Forms.TextBox2();
            this.proxyServerContextMenu = new System.Windows.Forms.ContextMenu();
            this.proxyServerCutMenuItem = new System.Windows.Forms.MenuItem();
            this.proxyServerCopyMenuItem = new System.Windows.Forms.MenuItem();
            this.proxyServerPasteMenuItem = new System.Windows.Forms.MenuItem();
            this.proxyUnuseRadioButton = new System.Windows.Forms.RadioButton();
            this.proxyPortLabel = new System.Windows.Forms.Label();
            this.proxyServerLabel = new System.Windows.Forms.Label();
            this.checkDirectMessageIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.checkDirectMessageLabel = new System.Windows.Forms.Label();
            this.settingTabControl.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.getListPanel.SuspendLayout();
            this.networkTabPage.SuspendLayout();
            this.proxySettingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingTabControl
            // 
            this.settingTabControl.Controls.Add(this.generalTabPage);
            this.settingTabControl.Controls.Add(this.networkTabPage);
            this.settingTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingTabControl.Location = new System.Drawing.Point(0, 0);
            this.settingTabControl.Name = "settingTabControl";
            this.settingTabControl.SelectedIndex = 0;
            this.settingTabControl.Size = new System.Drawing.Size(240, 268);
            this.settingTabControl.TabIndex = 0;
            // 
            // generalTabPage
            // 
            this.generalTabPage.Controls.Add(this.checkDirectMessageIntervalNumericUpDown);
            this.generalTabPage.Controls.Add(this.checkDirectMessageLabel);
            this.generalTabPage.Controls.Add(this.getListPanel);
            this.generalTabPage.Controls.Add(this.checkTimelineIntervalNumericUpDown);
            this.generalTabPage.Controls.Add(this.checkTimelineIntervalLabel);
            this.generalTabPage.Controls.Add(this.passwordTextBox);
            this.generalTabPage.Controls.Add(this.passwordLabel);
            this.generalTabPage.Controls.Add(this.userNameTextBox);
            this.generalTabPage.Controls.Add(this.userNameLabel);
            this.generalTabPage.Location = new System.Drawing.Point(0, 0);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Size = new System.Drawing.Size(240, 245);
            this.generalTabPage.Text = "General";
            // 
            // getListPanel
            // 
            this.getListPanel.Controls.Add(this.checkPublicRadioButton);
            this.getListPanel.Controls.Add(this.checkFriendsRadioButton);
            this.getListPanel.Controls.Add(this.checkListLabel);
            this.getListPanel.Location = new System.Drawing.Point(0, 57);
            this.getListPanel.Name = "getListPanel";
            this.getListPanel.Size = new System.Drawing.Size(240, 77);
            // 
            // checkPublicRadioButton
            // 
            this.checkPublicRadioButton.Location = new System.Drawing.Point(13, 49);
            this.checkPublicRadioButton.Name = "checkPublicRadioButton";
            this.checkPublicRadioButton.Size = new System.Drawing.Size(220, 20);
            this.checkPublicRadioButton.TabIndex = 1;
            this.checkPublicRadioButton.Text = "The Public List";
            // 
            // checkFriendsRadioButton
            // 
            this.checkFriendsRadioButton.Checked = true;
            this.checkFriendsRadioButton.Location = new System.Drawing.Point(13, 23);
            this.checkFriendsRadioButton.Name = "checkFriendsRadioButton";
            this.checkFriendsRadioButton.Size = new System.Drawing.Size(220, 20);
            this.checkFriendsRadioButton.TabIndex = 0;
            this.checkFriendsRadioButton.Text = "The Friends List";
            // 
            // checkListLabel
            // 
            this.checkListLabel.Location = new System.Drawing.Point(3, 0);
            this.checkListLabel.Name = "checkListLabel";
            this.checkListLabel.Size = new System.Drawing.Size(234, 20);
            this.checkListLabel.Text = "Check for new twitter from";
            // 
            // checkTimelineIntervalNumericUpDown
            // 
            this.checkTimelineIntervalNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkTimelineIntervalNumericUpDown.Location = new System.Drawing.Point(172, 140);
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
            this.checkTimelineIntervalNumericUpDown.Size = new System.Drawing.Size(65, 22);
            this.checkTimelineIntervalNumericUpDown.TabIndex = 2;
            this.checkTimelineIntervalNumericUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // checkTimelineIntervalLabel
            // 
            this.checkTimelineIntervalLabel.Location = new System.Drawing.Point(3, 142);
            this.checkTimelineIntervalLabel.Name = "checkTimelineIntervalLabel";
            this.checkTimelineIntervalLabel.Size = new System.Drawing.Size(163, 36);
            this.checkTimelineIntervalLabel.Text = "Automatically refresh twitter (sec)";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.ContextMenu = this.passwordContextMenu;
            this.passwordTextBox.Location = new System.Drawing.Point(81, 30);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(156, 21);
            this.passwordTextBox.TabIndex = 1;
            // 
            // passwordContextMenu
            // 
            this.passwordContextMenu.MenuItems.Add(this.passwordCutMenuItem);
            this.passwordContextMenu.MenuItems.Add(this.passwordCopyMenuItem);
            this.passwordContextMenu.MenuItems.Add(this.passwordPasteMenuItem);
            // 
            // passwordCutMenuItem
            // 
            this.passwordCutMenuItem.Text = "Cu&t";
            this.passwordCutMenuItem.Click += new System.EventHandler(this.passwordCutMenuItem_Click);
            // 
            // passwordCopyMenuItem
            // 
            this.passwordCopyMenuItem.Text = "&Copy";
            this.passwordCopyMenuItem.Click += new System.EventHandler(this.passwordCopyMenuItem_Click);
            // 
            // passwordPasteMenuItem
            // 
            this.passwordPasteMenuItem.Text = "&Paste";
            this.passwordPasteMenuItem.Click += new System.EventHandler(this.passwordPasteMenuItem_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(3, 31);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(72, 20);
            this.passwordLabel.Text = "Password";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameTextBox.ContextMenu = this.userNameContextMenu;
            this.userNameTextBox.Location = new System.Drawing.Point(81, 3);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(156, 21);
            this.userNameTextBox.TabIndex = 0;
            // 
            // userNameContextMenu
            // 
            this.userNameContextMenu.MenuItems.Add(this.userNameCutMenuItem);
            this.userNameContextMenu.MenuItems.Add(this.userNameCopyMenuItem);
            this.userNameContextMenu.MenuItems.Add(this.userNamePasteMenuItem);
            // 
            // userNameCutMenuItem
            // 
            this.userNameCutMenuItem.Text = "Cu&t";
            this.userNameCutMenuItem.Click += new System.EventHandler(this.userNameCutMenuItem_Click);
            // 
            // userNameCopyMenuItem
            // 
            this.userNameCopyMenuItem.Text = "&Copy";
            this.userNameCopyMenuItem.Click += new System.EventHandler(this.userNameCopyMenuItem_Click);
            // 
            // userNamePasteMenuItem
            // 
            this.userNamePasteMenuItem.Text = "&Paste";
            this.userNamePasteMenuItem.Click += new System.EventHandler(this.userNamePasteMenuItem_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.Location = new System.Drawing.Point(3, 4);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(72, 20);
            this.userNameLabel.Text = "User name";
            // 
            // networkTabPage
            // 
            this.networkTabPage.Controls.Add(this.proxySettingPanel);
            this.networkTabPage.Location = new System.Drawing.Point(0, 0);
            this.networkTabPage.Name = "networkTabPage";
            this.networkTabPage.Size = new System.Drawing.Size(240, 245);
            this.networkTabPage.Text = "NetWork";
            // 
            // proxySettingPanel
            // 
            this.proxySettingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.proxySettingPanel.Controls.Add(this.proxyUseOriginalSettingRadioButton);
            this.proxySettingPanel.Controls.Add(this.proxyPortTextBox);
            this.proxySettingPanel.Controls.Add(this.proxyUseOsSettingRadioButton);
            this.proxySettingPanel.Controls.Add(this.proxyServerTextBox);
            this.proxySettingPanel.Controls.Add(this.proxyUnuseRadioButton);
            this.proxySettingPanel.Controls.Add(this.proxyPortLabel);
            this.proxySettingPanel.Controls.Add(this.proxyServerLabel);
            this.proxySettingPanel.Location = new System.Drawing.Point(0, 0);
            this.proxySettingPanel.Name = "proxySettingPanel";
            this.proxySettingPanel.Size = new System.Drawing.Size(240, 169);
            // 
            // proxyUseOriginalSettingRadioButton
            // 
            this.proxyUseOriginalSettingRadioButton.Location = new System.Drawing.Point(3, 55);
            this.proxyUseOriginalSettingRadioButton.Name = "proxyUseOriginalSettingRadioButton";
            this.proxyUseOriginalSettingRadioButton.Size = new System.Drawing.Size(234, 20);
            this.proxyUseOriginalSettingRadioButton.TabIndex = 2;
            this.proxyUseOriginalSettingRadioButton.Text = "Use the following proxy";
            // 
            // proxyPortTextBox
            // 
            this.proxyPortTextBox.ContextMenu = this.proxyPortContextMenu;
            this.proxyPortTextBox.Location = new System.Drawing.Point(3, 140);
            this.proxyPortTextBox.Name = "proxyPortTextBox";
            this.proxyPortTextBox.Size = new System.Drawing.Size(74, 21);
            this.proxyPortTextBox.TabIndex = 4;
            // 
            // proxyPortContextMenu
            // 
            this.proxyPortContextMenu.MenuItems.Add(this.proxyPortCutMenuItem);
            this.proxyPortContextMenu.MenuItems.Add(this.proxyPortCopyMenuItem);
            this.proxyPortContextMenu.MenuItems.Add(this.proxyPortPasteMenuItem);
            // 
            // proxyPortCutMenuItem
            // 
            this.proxyPortCutMenuItem.Text = "Cu&t";
            this.proxyPortCutMenuItem.Click += new System.EventHandler(this.proxyPortCutMenuItem_Click);
            // 
            // proxyPortCopyMenuItem
            // 
            this.proxyPortCopyMenuItem.Text = "&Copy";
            this.proxyPortCopyMenuItem.Click += new System.EventHandler(this.proxyPortCopyMenuItem_Click);
            // 
            // proxyPortPasteMenuItem
            // 
            this.proxyPortPasteMenuItem.Text = "&Paste";
            this.proxyPortPasteMenuItem.Click += new System.EventHandler(this.proxyPortPasteMenuItem_Click);
            // 
            // proxyUseOsSettingRadioButton
            // 
            this.proxyUseOsSettingRadioButton.Checked = true;
            this.proxyUseOsSettingRadioButton.Location = new System.Drawing.Point(3, 29);
            this.proxyUseOsSettingRadioButton.Name = "proxyUseOsSettingRadioButton";
            this.proxyUseOsSettingRadioButton.Size = new System.Drawing.Size(234, 20);
            this.proxyUseOsSettingRadioButton.TabIndex = 1;
            this.proxyUseOsSettingRadioButton.Text = "Use the proxy set depending on OS";
            // 
            // proxyServerTextBox
            // 
            this.proxyServerTextBox.ContextMenu = this.proxyServerContextMenu;
            this.proxyServerTextBox.Location = new System.Drawing.Point(3, 97);
            this.proxyServerTextBox.Name = "proxyServerTextBox";
            this.proxyServerTextBox.Size = new System.Drawing.Size(234, 21);
            this.proxyServerTextBox.TabIndex = 3;
            // 
            // proxyServerContextMenu
            // 
            this.proxyServerContextMenu.MenuItems.Add(this.proxyServerCutMenuItem);
            this.proxyServerContextMenu.MenuItems.Add(this.proxyServerCopyMenuItem);
            this.proxyServerContextMenu.MenuItems.Add(this.proxyServerPasteMenuItem);
            // 
            // proxyServerCutMenuItem
            // 
            this.proxyServerCutMenuItem.Text = "Cu&t";
            this.proxyServerCutMenuItem.Click += new System.EventHandler(this.proxyServerCutMenuItem_Click);
            // 
            // proxyServerCopyMenuItem
            // 
            this.proxyServerCopyMenuItem.Text = "&Copy";
            this.proxyServerCopyMenuItem.Click += new System.EventHandler(this.proxyServerCopyMenuItem_Click);
            // 
            // proxyServerPasteMenuItem
            // 
            this.proxyServerPasteMenuItem.Text = "&Paste";
            this.proxyServerPasteMenuItem.Click += new System.EventHandler(this.proxyServerPasteMenuItem_Click);
            // 
            // proxyUnuseRadioButton
            // 
            this.proxyUnuseRadioButton.Location = new System.Drawing.Point(3, 3);
            this.proxyUnuseRadioButton.Name = "proxyUnuseRadioButton";
            this.proxyUnuseRadioButton.Size = new System.Drawing.Size(234, 20);
            this.proxyUnuseRadioButton.TabIndex = 0;
            this.proxyUnuseRadioButton.Text = "Use no proxy";
            // 
            // proxyPortLabel
            // 
            this.proxyPortLabel.Location = new System.Drawing.Point(3, 121);
            this.proxyPortLabel.Name = "proxyPortLabel";
            this.proxyPortLabel.Size = new System.Drawing.Size(234, 16);
            this.proxyPortLabel.Text = "Port number (ex: 8080)";
            // 
            // proxyServerLabel
            // 
            this.proxyServerLabel.Location = new System.Drawing.Point(3, 78);
            this.proxyServerLabel.Name = "proxyServerLabel";
            this.proxyServerLabel.Size = new System.Drawing.Size(234, 16);
            this.proxyServerLabel.Text = "Proxy server (ex: proxy.example.com)";
            // 
            // checkDirectMessageIntervalNumericUpDown
            // 
            this.checkDirectMessageIntervalNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkDirectMessageIntervalNumericUpDown.Location = new System.Drawing.Point(168, 185);
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
            this.checkDirectMessageIntervalNumericUpDown.Size = new System.Drawing.Size(65, 22);
            this.checkDirectMessageIntervalNumericUpDown.TabIndex = 3;
            this.checkDirectMessageIntervalNumericUpDown.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // checkDirectMessageLabel
            // 
            this.checkDirectMessageLabel.Location = new System.Drawing.Point(3, 185);
            this.checkDirectMessageLabel.Name = "checkDirectMessageLabel";
            this.checkDirectMessageLabel.Size = new System.Drawing.Size(163, 36);
            this.checkDirectMessageLabel.Text = "Automatically refresh direct message (sec)";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.settingTabControl);
            this.Menu = this.mainMenu1;
            this.Name = "SettingForm";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.SettingForm_Closing);
            this.settingTabControl.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.getListPanel.ResumeLayout(false);
            this.networkTabPage.ResumeLayout(false);
            this.proxySettingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl settingTabControl;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.Panel getListPanel;
        private System.Windows.Forms.RadioButton checkPublicRadioButton;
        private System.Windows.Forms.RadioButton checkFriendsRadioButton;
        private System.Windows.Forms.Label checkListLabel;
        private System.Windows.Forms.NumericUpDown checkTimelineIntervalNumericUpDown;
        private System.Windows.Forms.Label checkTimelineIntervalLabel;
        private OpenNETCF.Windows.Forms.TextBox2 passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private OpenNETCF.Windows.Forms.TextBox2 userNameTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TabPage networkTabPage;
        private System.Windows.Forms.Panel proxySettingPanel;
        private System.Windows.Forms.RadioButton proxyUseOriginalSettingRadioButton;
        private OpenNETCF.Windows.Forms.TextBox2 proxyPortTextBox;
        private System.Windows.Forms.RadioButton proxyUseOsSettingRadioButton;
        private OpenNETCF.Windows.Forms.TextBox2 proxyServerTextBox;
        private System.Windows.Forms.RadioButton proxyUnuseRadioButton;
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
        private System.Windows.Forms.NumericUpDown checkDirectMessageIntervalNumericUpDown;
        private System.Windows.Forms.Label checkDirectMessageLabel;
    }
}