namespace TwitterAwayZwei
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu;

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
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.menuMenuItem = new System.Windows.Forms.MenuItem();
            this.settingMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.aboutMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.exitMenuItem = new System.Windows.Forms.MenuItem();
            this.topPanel = new System.Windows.Forms.Panel();
            this.doingInfomationTextLabel = new System.Windows.Forms.Label();
            this.twitterIconPictureBox = new System.Windows.Forms.PictureBox();
            this.mainSplitter = new System.Windows.Forms.Splitter();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.mainStatusBar = new System.Windows.Forms.StatusBar();
            this.twitterInfomationTabControl = new System.Windows.Forms.TabControl();
            this.timelineTabPage = new System.Windows.Forms.TabPage();
            this.timilineTwitterListView = new System.Windows.Forms.ListView();
            this.timelineScreenNameColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.doingColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.timelineDateColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.timelineContextMenu = new System.Windows.Forms.ContextMenu();
            this.replyMenuItem = new System.Windows.Forms.MenuItem();
            this.directMessageMenuItem = new System.Windows.Forms.MenuItem();
            this.directMessageTabPage = new System.Windows.Forms.TabPage();
            this.messageTwitterListView = new System.Windows.Forms.ListView();
            this.messageScreenNameColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.messageColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.messageDateColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.updateButton = new System.Windows.Forms.Button();
            this.dowingTextBox = new OpenNETCF.Windows.Forms.TextBox2();
            this.doingContextMenu = new System.Windows.Forms.ContextMenu();
            this.cutMenuItem = new System.Windows.Forms.MenuItem();
            this.copyMenuItem = new System.Windows.Forms.MenuItem();
            this.pasteMenuItem = new System.Windows.Forms.MenuItem();
            this.fetchTimelineBackgroundWorker = new OpenNETCF.ComponentModel.BackgroundWorker();
            this.fetchTimelineTimer = new System.Windows.Forms.Timer();
            this.updateTwitterBackgroundWorker = new OpenNETCF.ComponentModel.BackgroundWorker();
            this.fetchDirectMessageBackgroundWorker = new OpenNETCF.ComponentModel.BackgroundWorker();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.twitterInfomationTabControl.SuspendLayout();
            this.timelineTabPage.SuspendLayout();
            this.directMessageTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.menuMenuItem);
            // 
            // menuMenuItem
            // 
            this.menuMenuItem.MenuItems.Add(this.settingMenuItem);
            this.menuMenuItem.MenuItems.Add(this.menuItem2);
            this.menuMenuItem.MenuItems.Add(this.aboutMenuItem);
            this.menuMenuItem.MenuItems.Add(this.menuItem1);
            this.menuMenuItem.MenuItems.Add(this.exitMenuItem);
            this.menuMenuItem.Text = "&Menu";
            // 
            // settingMenuItem
            // 
            this.settingMenuItem.Text = "&Setting";
            this.settingMenuItem.Click += new System.EventHandler(this.settingMenuItem_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "-";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Text = "&About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "-";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Text = "E&xit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.doingInfomationTextLabel);
            this.topPanel.Controls.Add(this.twitterIconPictureBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(240, 60);
            // 
            // doingInfomationTextLabel
            // 
            this.doingInfomationTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.doingInfomationTextLabel.Location = new System.Drawing.Point(53, 3);
            this.doingInfomationTextLabel.Name = "doingInfomationTextLabel";
            this.doingInfomationTextLabel.Size = new System.Drawing.Size(184, 54);
            // 
            // twitterIconPictureBox
            // 
            this.twitterIconPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.twitterIconPictureBox.Location = new System.Drawing.Point(3, 8);
            this.twitterIconPictureBox.Name = "twitterIconPictureBox";
            this.twitterIconPictureBox.Size = new System.Drawing.Size(44, 44);
            this.twitterIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // mainSplitter
            // 
            this.mainSplitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainSplitter.Location = new System.Drawing.Point(0, 60);
            this.mainSplitter.Name = "mainSplitter";
            this.mainSplitter.Size = new System.Drawing.Size(240, 3);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.mainStatusBar);
            this.bottomPanel.Controls.Add(this.twitterInfomationTabControl);
            this.bottomPanel.Controls.Add(this.updateButton);
            this.bottomPanel.Controls.Add(this.dowingTextBox);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(0, 63);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(240, 205);
            // 
            // mainStatusBar
            // 
            this.mainStatusBar.Location = new System.Drawing.Point(0, 183);
            this.mainStatusBar.Name = "mainStatusBar";
            this.mainStatusBar.Size = new System.Drawing.Size(240, 22);
            // 
            // twitterInfomationTabControl
            // 
            this.twitterInfomationTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.twitterInfomationTabControl.Controls.Add(this.timelineTabPage);
            this.twitterInfomationTabControl.Controls.Add(this.directMessageTabPage);
            this.twitterInfomationTabControl.Dock = System.Windows.Forms.DockStyle.None;
            this.twitterInfomationTabControl.Location = new System.Drawing.Point(0, 0);
            this.twitterInfomationTabControl.Name = "twitterInfomationTabControl";
            this.twitterInfomationTabControl.SelectedIndex = 0;
            this.twitterInfomationTabControl.Size = new System.Drawing.Size(240, 151);
            this.twitterInfomationTabControl.TabIndex = 3;
            // 
            // timelineTabPage
            // 
            this.timelineTabPage.Controls.Add(this.timilineTwitterListView);
            this.timelineTabPage.Location = new System.Drawing.Point(0, 0);
            this.timelineTabPage.Name = "timelineTabPage";
            this.timelineTabPage.Size = new System.Drawing.Size(240, 128);
            this.timelineTabPage.Text = "Timeline";
            // 
            // timilineTwitterListView
            // 
            this.timilineTwitterListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.timilineTwitterListView.Columns.Add(this.timelineScreenNameColumnHeader);
            this.timilineTwitterListView.Columns.Add(this.doingColumnHeader);
            this.timilineTwitterListView.Columns.Add(this.timelineDateColumnHeader);
            this.timilineTwitterListView.ContextMenu = this.timelineContextMenu;
            this.timilineTwitterListView.Location = new System.Drawing.Point(3, 3);
            this.timilineTwitterListView.Name = "timilineTwitterListView";
            this.timilineTwitterListView.Size = new System.Drawing.Size(234, 122);
            this.timilineTwitterListView.TabIndex = 0;
            this.timilineTwitterListView.View = System.Windows.Forms.View.Details;
            this.timilineTwitterListView.SelectedIndexChanged += new System.EventHandler(this.twitterListView_SelectedIndexChanged);
            // 
            // timelineScreenNameColumnHeader
            // 
            this.timelineScreenNameColumnHeader.Text = "Name";
            this.timelineScreenNameColumnHeader.Width = 60;
            // 
            // doingColumnHeader
            // 
            this.doingColumnHeader.Text = "What are you doing?";
            this.doingColumnHeader.Width = 120;
            // 
            // timelineDateColumnHeader
            // 
            this.timelineDateColumnHeader.Text = "Date";
            this.timelineDateColumnHeader.Width = 50;
            // 
            // timelineContextMenu
            // 
            this.timelineContextMenu.MenuItems.Add(this.replyMenuItem);
            this.timelineContextMenu.MenuItems.Add(this.directMessageMenuItem);
            // 
            // replyMenuItem
            // 
            this.replyMenuItem.Text = "&Reply";
            this.replyMenuItem.Click += new System.EventHandler(this.replyMenuItem_Click);
            // 
            // directMessageMenuItem
            // 
            this.directMessageMenuItem.Text = "&Direct message";
            this.directMessageMenuItem.Click += new System.EventHandler(this.directMessageMenuItem_Click);
            // 
            // directMessageTabPage
            // 
            this.directMessageTabPage.Controls.Add(this.messageTwitterListView);
            this.directMessageTabPage.Location = new System.Drawing.Point(0, 0);
            this.directMessageTabPage.Name = "directMessageTabPage";
            this.directMessageTabPage.Size = new System.Drawing.Size(232, 125);
            this.directMessageTabPage.Text = "Messages";
            // 
            // messageTwitterListView
            // 
            this.messageTwitterListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTwitterListView.Columns.Add(this.messageScreenNameColumnHeader);
            this.messageTwitterListView.Columns.Add(this.messageColumnHeader);
            this.messageTwitterListView.Columns.Add(this.messageDateColumnHeader);
            this.messageTwitterListView.Location = new System.Drawing.Point(3, 3);
            this.messageTwitterListView.Name = "messageTwitterListView";
            this.messageTwitterListView.Size = new System.Drawing.Size(226, 119);
            this.messageTwitterListView.TabIndex = 1;
            this.messageTwitterListView.View = System.Windows.Forms.View.Details;
            this.messageTwitterListView.SelectedIndexChanged += new System.EventHandler(this.messageTwitterListView_SelectedIndexChanged);
            // 
            // messageScreenNameColumnHeader
            // 
            this.messageScreenNameColumnHeader.Text = "Name";
            this.messageScreenNameColumnHeader.Width = 60;
            // 
            // messageColumnHeader
            // 
            this.messageColumnHeader.Text = "Message";
            this.messageColumnHeader.Width = 120;
            // 
            // messageDateColumnHeader
            // 
            this.messageDateColumnHeader.Text = "Date";
            this.messageDateColumnHeader.Width = 50;
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.Location = new System.Drawing.Point(173, 157);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(64, 20);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "&Update";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // dowingTextBox
            // 
            this.dowingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dowingTextBox.ContextMenu = this.doingContextMenu;
            this.dowingTextBox.Location = new System.Drawing.Point(3, 157);
            this.dowingTextBox.Name = "dowingTextBox";
            this.dowingTextBox.Size = new System.Drawing.Size(164, 21);
            this.dowingTextBox.TabIndex = 0;
            // 
            // doingContextMenu
            // 
            this.doingContextMenu.MenuItems.Add(this.cutMenuItem);
            this.doingContextMenu.MenuItems.Add(this.copyMenuItem);
            this.doingContextMenu.MenuItems.Add(this.pasteMenuItem);
            // 
            // cutMenuItem
            // 
            this.cutMenuItem.Text = "Cu&t";
            this.cutMenuItem.Click += new System.EventHandler(this.cutMenuItem_Click);
            // 
            // copyMenuItem
            // 
            this.copyMenuItem.Text = "&Copy";
            this.copyMenuItem.Click += new System.EventHandler(this.copyMenuItem_Click);
            // 
            // pasteMenuItem
            // 
            this.pasteMenuItem.Text = "&Paste";
            this.pasteMenuItem.Click += new System.EventHandler(this.pasteMenuItem_Click);
            // 
            // fetchTimelineBackgroundWorker
            // 
            this.fetchTimelineBackgroundWorker.WorkerReportsProgress = false;
            this.fetchTimelineBackgroundWorker.WorkerSupportsCancellation = false;
            this.fetchTimelineBackgroundWorker.DoWork += new OpenNETCF.ComponentModel.DoWorkEventHandler(this.fetchTimelineTwitterBackgroundWorker_DoWork);
            this.fetchTimelineBackgroundWorker.RunWorkerCompleted += new OpenNETCF.ComponentModel.RunWorkerCompletedEventHandler(this.fetchTimelineTwitterBackgroundWorker_RunWorkerCompleted);
            this.fetchTimelineBackgroundWorker.ProgressChanged += new OpenNETCF.ComponentModel.ProgressChangedEventHandler(this.fetchTimelineBackgroundWorker_ProgressChanged);
            // 
            // fetchTimelineTimer
            // 
            this.fetchTimelineTimer.Interval = 1000;
            this.fetchTimelineTimer.Tick += new System.EventHandler(this.fetchTimelineTimer_Tick);
            // 
            // updateTwitterBackgroundWorker
            // 
            this.updateTwitterBackgroundWorker.WorkerReportsProgress = false;
            this.updateTwitterBackgroundWorker.WorkerSupportsCancellation = false;
            this.updateTwitterBackgroundWorker.DoWork += new OpenNETCF.ComponentModel.DoWorkEventHandler(this.updateTwitterBackgroundWorker_DoWork);
            this.updateTwitterBackgroundWorker.RunWorkerCompleted += new OpenNETCF.ComponentModel.RunWorkerCompletedEventHandler(this.updateTwitterBackgroundWorker_RunWorkerCompleted);
            this.updateTwitterBackgroundWorker.ProgressChanged += new OpenNETCF.ComponentModel.ProgressChangedEventHandler(this.updateTwitterBackgroundWorker_ProgressChanged);
            // 
            // fetchDirectMessageBackgroundWorker
            // 
            this.fetchDirectMessageBackgroundWorker.WorkerReportsProgress = false;
            this.fetchDirectMessageBackgroundWorker.WorkerSupportsCancellation = false;
            this.fetchDirectMessageBackgroundWorker.DoWork += new OpenNETCF.ComponentModel.DoWorkEventHandler(this.fetchDirectMessageBackgroundWorker_DoWork);
            this.fetchDirectMessageBackgroundWorker.RunWorkerCompleted += new OpenNETCF.ComponentModel.RunWorkerCompletedEventHandler(this.fetchDirectMessageBackgroundWorker_RunWorkerCompleted);
            this.fetchDirectMessageBackgroundWorker.ProgressChanged += new OpenNETCF.ComponentModel.ProgressChangedEventHandler(this.fetchDirectMessageBackgroundWorker_ProgressChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.mainSplitter);
            this.Controls.Add(this.topPanel);
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            this.topPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.twitterInfomationTabControl.ResumeLayout(false);
            this.timelineTabPage.ResumeLayout(false);
            this.directMessageTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Splitter mainSplitter;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label doingInfomationTextLabel;
        private System.Windows.Forms.PictureBox twitterIconPictureBox;
        private System.Windows.Forms.Button updateButton;
        private OpenNETCF.Windows.Forms.TextBox2 dowingTextBox;
        private System.Windows.Forms.ListView timilineTwitterListView;
        private System.Windows.Forms.ColumnHeader timelineScreenNameColumnHeader;
        private System.Windows.Forms.ColumnHeader doingColumnHeader;
        private System.Windows.Forms.ColumnHeader timelineDateColumnHeader;
        private OpenNETCF.ComponentModel.BackgroundWorker fetchTimelineBackgroundWorker;
        private System.Windows.Forms.Timer fetchTimelineTimer;
        private System.Windows.Forms.TabControl twitterInfomationTabControl;
        private System.Windows.Forms.TabPage timelineTabPage;
        private System.Windows.Forms.StatusBar mainStatusBar;
        private System.Windows.Forms.MenuItem menuMenuItem;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem aboutMenuItem;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem exitMenuItem;
        private System.Windows.Forms.MenuItem settingMenuItem;
        private OpenNETCF.ComponentModel.BackgroundWorker updateTwitterBackgroundWorker;
        private System.Windows.Forms.ContextMenu doingContextMenu;
        private System.Windows.Forms.MenuItem copyMenuItem;
        private System.Windows.Forms.MenuItem cutMenuItem;
        private System.Windows.Forms.MenuItem pasteMenuItem;
        private System.Windows.Forms.ContextMenu timelineContextMenu;
        private System.Windows.Forms.MenuItem replyMenuItem;
        private System.Windows.Forms.MenuItem directMessageMenuItem;
        private System.Windows.Forms.TabPage directMessageTabPage;
        private System.Windows.Forms.ListView messageTwitterListView;
        private System.Windows.Forms.ColumnHeader messageScreenNameColumnHeader;
        private System.Windows.Forms.ColumnHeader messageColumnHeader;
        private System.Windows.Forms.ColumnHeader messageDateColumnHeader;
        private OpenNETCF.ComponentModel.BackgroundWorker fetchDirectMessageBackgroundWorker;


    }
}

