﻿namespace TwitterAwayZwei
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.menuMenuItem = new System.Windows.Forms.MenuItem();
            this.automaticaryUpdateMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.settingMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.aboutMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.exitMenuItem = new System.Windows.Forms.MenuItem();
            this.updateMenuItem = new System.Windows.Forms.MenuItem();
            this.topPanel = new System.Windows.Forms.Panel();
            this.doingInfomationTextLabel = new System.Windows.Forms.Label();
            this.twitterIconPictureBox = new System.Windows.Forms.PictureBox();
            this.mainSplitter = new System.Windows.Forms.Splitter();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.mainStatusBar = new System.Windows.Forms.StatusBar();
            this.twitterInfomationTabControl = new System.Windows.Forms.TabControl();
            this.timelineTabPage = new System.Windows.Forms.TabPage();
            this.timelineTwitterListView = new System.Windows.Forms.ListView();
            this.timelineScreenNameColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.doingColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.timelineDateColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.timelineContextMenu = new System.Windows.Forms.ContextMenu();
            this.timelineReplyMenuItem = new System.Windows.Forms.MenuItem();
            this.timelineDirectMessageMenuItem = new System.Windows.Forms.MenuItem();
            this.directMessageTabPage = new System.Windows.Forms.TabPage();
            this.messageTwitterListView = new System.Windows.Forms.ListView();
            this.messageScreenNameColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.messageColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.messageDateColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.messagesContextMenu = new System.Windows.Forms.ContextMenu();
            this.messagesReplayMenuItem = new System.Windows.Forms.MenuItem();
            this.messagesDirectMessageMenuItem = new System.Windows.Forms.MenuItem();
            this.twitButton = new System.Windows.Forms.Button();
            this.doingTextBox = new OpenNETCF.Windows.Forms.TextBox2();
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
            this.mainMenu.MenuItems.Add(this.updateMenuItem);
            // 
            // menuMenuItem
            // 
            this.menuMenuItem.MenuItems.Add(this.automaticaryUpdateMenuItem);
            this.menuMenuItem.MenuItems.Add(this.menuItem3);
            this.menuMenuItem.MenuItems.Add(this.settingMenuItem);
            this.menuMenuItem.MenuItems.Add(this.menuItem2);
            this.menuMenuItem.MenuItems.Add(this.aboutMenuItem);
            this.menuMenuItem.MenuItems.Add(this.menuItem1);
            this.menuMenuItem.MenuItems.Add(this.exitMenuItem);
            resources.ApplyResources(this.menuMenuItem, "menuMenuItem");
            // 
            // automaticaryUpdateMenuItem
            // 
            resources.ApplyResources(this.automaticaryUpdateMenuItem, "automaticaryUpdateMenuItem");
            this.automaticaryUpdateMenuItem.Click += new System.EventHandler(this.automaticaryUpdateMenuItem_Click);
            // 
            // menuItem3
            // 
            resources.ApplyResources(this.menuItem3, "menuItem3");
            // 
            // settingMenuItem
            // 
            resources.ApplyResources(this.settingMenuItem, "settingMenuItem");
            this.settingMenuItem.Click += new System.EventHandler(this.settingMenuItem_Click);
            // 
            // menuItem2
            // 
            resources.ApplyResources(this.menuItem2, "menuItem2");
            // 
            // aboutMenuItem
            // 
            resources.ApplyResources(this.aboutMenuItem, "aboutMenuItem");
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // menuItem1
            // 
            resources.ApplyResources(this.menuItem1, "menuItem1");
            // 
            // exitMenuItem
            // 
            resources.ApplyResources(this.exitMenuItem, "exitMenuItem");
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // updateMenuItem
            // 
            resources.ApplyResources(this.updateMenuItem, "updateMenuItem");
            this.updateMenuItem.Click += new System.EventHandler(this.updateMenuItem_Click);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.doingInfomationTextLabel);
            this.topPanel.Controls.Add(this.twitterIconPictureBox);
            resources.ApplyResources(this.topPanel, "topPanel");
            this.topPanel.Name = "topPanel";
            // 
            // doingInfomationTextLabel
            // 
            resources.ApplyResources(this.doingInfomationTextLabel, "doingInfomationTextLabel");
            this.doingInfomationTextLabel.Name = "doingInfomationTextLabel";
            // 
            // twitterIconPictureBox
            // 
            resources.ApplyResources(this.twitterIconPictureBox, "twitterIconPictureBox");
            this.twitterIconPictureBox.Name = "twitterIconPictureBox";
            // 
            // mainSplitter
            // 
            resources.ApplyResources(this.mainSplitter, "mainSplitter");
            this.mainSplitter.Name = "mainSplitter";
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.mainStatusBar);
            this.bottomPanel.Controls.Add(this.twitterInfomationTabControl);
            this.bottomPanel.Controls.Add(this.twitButton);
            this.bottomPanel.Controls.Add(this.doingTextBox);
            resources.ApplyResources(this.bottomPanel, "bottomPanel");
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bottomPanel_Paint);
            // 
            // mainStatusBar
            // 
            resources.ApplyResources(this.mainStatusBar, "mainStatusBar");
            this.mainStatusBar.Name = "mainStatusBar";
            // 
            // twitterInfomationTabControl
            // 
            resources.ApplyResources(this.twitterInfomationTabControl, "twitterInfomationTabControl");
            this.twitterInfomationTabControl.Controls.Add(this.timelineTabPage);
            this.twitterInfomationTabControl.Controls.Add(this.directMessageTabPage);
            this.twitterInfomationTabControl.Name = "twitterInfomationTabControl";
            this.twitterInfomationTabControl.SelectedIndex = 0;
            // 
            // timelineTabPage
            // 
            this.timelineTabPage.Controls.Add(this.timelineTwitterListView);
            resources.ApplyResources(this.timelineTabPage, "timelineTabPage");
            this.timelineTabPage.Name = "timelineTabPage";
            // 
            // timelineTwitterListView
            // 
            resources.ApplyResources(this.timelineTwitterListView, "timelineTwitterListView");
            this.timelineTwitterListView.Columns.Add(this.timelineScreenNameColumnHeader);
            this.timelineTwitterListView.Columns.Add(this.doingColumnHeader);
            this.timelineTwitterListView.Columns.Add(this.timelineDateColumnHeader);
            this.timelineTwitterListView.ContextMenu = this.timelineContextMenu;
            this.timelineTwitterListView.Name = "timelineTwitterListView";
            this.timelineTwitterListView.View = System.Windows.Forms.View.Details;
            this.timelineTwitterListView.SelectedIndexChanged += new System.EventHandler(this.twitterListView_SelectedIndexChanged);
            // 
            // timelineScreenNameColumnHeader
            // 
            resources.ApplyResources(this.timelineScreenNameColumnHeader, "timelineScreenNameColumnHeader");
            // 
            // doingColumnHeader
            // 
            resources.ApplyResources(this.doingColumnHeader, "doingColumnHeader");
            // 
            // timelineDateColumnHeader
            // 
            resources.ApplyResources(this.timelineDateColumnHeader, "timelineDateColumnHeader");
            // 
            // timelineContextMenu
            // 
            this.timelineContextMenu.MenuItems.Add(this.timelineReplyMenuItem);
            this.timelineContextMenu.MenuItems.Add(this.timelineDirectMessageMenuItem);
            this.timelineContextMenu.Popup += new System.EventHandler(this.timelineContextMenu_Popup);
            // 
            // timelineReplyMenuItem
            // 
            resources.ApplyResources(this.timelineReplyMenuItem, "timelineReplyMenuItem");
            this.timelineReplyMenuItem.Click += new System.EventHandler(this.timelineReplyMenuItem_Click);
            // 
            // timelineDirectMessageMenuItem
            // 
            resources.ApplyResources(this.timelineDirectMessageMenuItem, "timelineDirectMessageMenuItem");
            this.timelineDirectMessageMenuItem.Click += new System.EventHandler(this.timelineDirectMessageMenuItem_Click);
            // 
            // directMessageTabPage
            // 
            this.directMessageTabPage.Controls.Add(this.messageTwitterListView);
            resources.ApplyResources(this.directMessageTabPage, "directMessageTabPage");
            this.directMessageTabPage.Name = "directMessageTabPage";
            // 
            // messageTwitterListView
            // 
            resources.ApplyResources(this.messageTwitterListView, "messageTwitterListView");
            this.messageTwitterListView.Columns.Add(this.messageScreenNameColumnHeader);
            this.messageTwitterListView.Columns.Add(this.messageColumnHeader);
            this.messageTwitterListView.Columns.Add(this.messageDateColumnHeader);
            this.messageTwitterListView.ContextMenu = this.messagesContextMenu;
            this.messageTwitterListView.Name = "messageTwitterListView";
            this.messageTwitterListView.View = System.Windows.Forms.View.Details;
            this.messageTwitterListView.SelectedIndexChanged += new System.EventHandler(this.messageTwitterListView_SelectedIndexChanged);
            // 
            // messageScreenNameColumnHeader
            // 
            resources.ApplyResources(this.messageScreenNameColumnHeader, "messageScreenNameColumnHeader");
            // 
            // messageColumnHeader
            // 
            resources.ApplyResources(this.messageColumnHeader, "messageColumnHeader");
            // 
            // messageDateColumnHeader
            // 
            resources.ApplyResources(this.messageDateColumnHeader, "messageDateColumnHeader");
            // 
            // messagesContextMenu
            // 
            this.messagesContextMenu.MenuItems.Add(this.messagesReplayMenuItem);
            this.messagesContextMenu.MenuItems.Add(this.messagesDirectMessageMenuItem);
            this.messagesContextMenu.Popup += new System.EventHandler(this.messagesContextMenu_Popup);
            // 
            // messagesReplayMenuItem
            // 
            resources.ApplyResources(this.messagesReplayMenuItem, "messagesReplayMenuItem");
            this.messagesReplayMenuItem.Click += new System.EventHandler(this.messagesReplayMenuItem_Click);
            // 
            // messagesDirectMessageMenuItem
            // 
            resources.ApplyResources(this.messagesDirectMessageMenuItem, "messagesDirectMessageMenuItem");
            this.messagesDirectMessageMenuItem.Click += new System.EventHandler(this.messagesDirectMessageMenuItem_Click);
            // 
            // twitButton
            // 
            resources.ApplyResources(this.twitButton, "twitButton");
            this.twitButton.Name = "twitButton";
            this.twitButton.Click += new System.EventHandler(this.twitButton_Click);
            // 
            // doingTextBox
            // 
            resources.ApplyResources(this.doingTextBox, "doingTextBox");
            this.doingTextBox.ContextMenu = this.doingContextMenu;
            this.doingTextBox.Name = "doingTextBox";
            this.doingTextBox.TextChanged += new System.EventHandler(this.doingTextBox_TextChanged);
            // 
            // doingContextMenu
            // 
            this.doingContextMenu.MenuItems.Add(this.cutMenuItem);
            this.doingContextMenu.MenuItems.Add(this.copyMenuItem);
            this.doingContextMenu.MenuItems.Add(this.pasteMenuItem);
            // 
            // cutMenuItem
            // 
            resources.ApplyResources(this.cutMenuItem, "cutMenuItem");
            this.cutMenuItem.Click += new System.EventHandler(this.cutMenuItem_Click);
            // 
            // copyMenuItem
            // 
            resources.ApplyResources(this.copyMenuItem, "copyMenuItem");
            this.copyMenuItem.Click += new System.EventHandler(this.copyMenuItem_Click);
            // 
            // pasteMenuItem
            // 
            resources.ApplyResources(this.pasteMenuItem, "pasteMenuItem");
            this.pasteMenuItem.Click += new System.EventHandler(this.pasteMenuItem_Click);
            // 
            // fetchTimelineBackgroundWorker
            // 
            this.fetchTimelineBackgroundWorker.WorkerReportsProgress = true;
            this.fetchTimelineBackgroundWorker.WorkerSupportsCancellation = true;
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
            this.updateTwitterBackgroundWorker.WorkerReportsProgress = true;
            this.updateTwitterBackgroundWorker.WorkerSupportsCancellation = true;
            this.updateTwitterBackgroundWorker.DoWork += new OpenNETCF.ComponentModel.DoWorkEventHandler(this.updateTwitterBackgroundWorker_DoWork);
            this.updateTwitterBackgroundWorker.RunWorkerCompleted += new OpenNETCF.ComponentModel.RunWorkerCompletedEventHandler(this.updateTwitterBackgroundWorker_RunWorkerCompleted);
            this.updateTwitterBackgroundWorker.ProgressChanged += new OpenNETCF.ComponentModel.ProgressChangedEventHandler(this.updateTwitterBackgroundWorker_ProgressChanged);
            // 
            // fetchDirectMessageBackgroundWorker
            // 
            this.fetchDirectMessageBackgroundWorker.WorkerReportsProgress = true;
            this.fetchDirectMessageBackgroundWorker.WorkerSupportsCancellation = true;
            this.fetchDirectMessageBackgroundWorker.DoWork += new OpenNETCF.ComponentModel.DoWorkEventHandler(this.fetchDirectMessageBackgroundWorker_DoWork);
            this.fetchDirectMessageBackgroundWorker.RunWorkerCompleted += new OpenNETCF.ComponentModel.RunWorkerCompletedEventHandler(this.fetchDirectMessageBackgroundWorker_RunWorkerCompleted);
            this.fetchDirectMessageBackgroundWorker.ProgressChanged += new OpenNETCF.ComponentModel.ProgressChangedEventHandler(this.fetchDirectMessageBackgroundWorker_ProgressChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            resources.ApplyResources(this, "$this");
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
        private System.Windows.Forms.Button twitButton;
        private OpenNETCF.Windows.Forms.TextBox2 doingTextBox;
        private System.Windows.Forms.ListView timelineTwitterListView;
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
        private System.Windows.Forms.MenuItem timelineReplyMenuItem;
        private System.Windows.Forms.MenuItem timelineDirectMessageMenuItem;
        private System.Windows.Forms.TabPage directMessageTabPage;
        private System.Windows.Forms.ListView messageTwitterListView;
        private System.Windows.Forms.ColumnHeader messageScreenNameColumnHeader;
        private System.Windows.Forms.ColumnHeader messageColumnHeader;
        private System.Windows.Forms.ColumnHeader messageDateColumnHeader;
        private OpenNETCF.ComponentModel.BackgroundWorker fetchDirectMessageBackgroundWorker;
        private System.Windows.Forms.MenuItem automaticaryUpdateMenuItem;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.ContextMenu messagesContextMenu;
        private System.Windows.Forms.MenuItem messagesReplayMenuItem;
        private System.Windows.Forms.MenuItem messagesDirectMessageMenuItem;
        private System.Windows.Forms.MenuItem updateMenuItem;


    }
}

