using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Net;
using System.IO;
using System.Resources;
using System.Windows.Forms;
using OpenNETCF.ComponentModel;
using MiscPocketCompactLibrary2.Reflection;
using TwitterAwayZwei.Twitter;

namespace TwitterAwayZwei
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Twitter
        /// </summary>
        TwitterAwayZwei.Twitter.Twitter twitterAccount;

        /// <summary>
        /// 自動チェックするか
        /// </summary>
        private bool automaticaryCheck = false;

        /// <summary>
        /// 取得している TwitterStatusInfomation
        /// </summary>
        private StatusInfomation[] twitterStatuses;

        /// <summary>
        /// 取得している DirectMessage
        /// </summary>
        private DirectMessage[] twitterDirectMessages;

        /// <summary>
        /// ステータスバーに表示するエラー
        /// </summary>
        private string errorTextStatusBar;

        /// <summary>
        /// 多言語リソース
        /// </summary>
        private ResourceManager stringResource = new ResourceManager("TwitterAwayZwei.TwitterAwayZweiStrings", AssemblyUtility.Assembly);

        public MainForm()
        {
            InitializeComponent();

            // Twitterの初期化
            twitterAccount = new TwitterAwayZwei.Twitter.Twitter(UserSettingAdapter.Setting.UserName, UserSettingAdapter.Setting.Password);
            twitterAccount.IsFetchProfileImages = UserSettingAdapter.Setting.IsFetchProfileImages;
            twitterAccount.ProxyUse = UserSettingAdapter.Setting.ProxyUse;
            twitterAccount.ProxyServer = UserSettingAdapter.Setting.ProxyServer;
            twitterAccount.ProxyPort = UserSettingAdapter.Setting.ProxyPort;
            twitterAccount.WebRequestTimeoutMillSec = TwitterAwayZweiInfo.WebRequestTimeoutMillSec;
            twitterAccount.StatusAdded += delegate(object sender, StatusAddedEventArgs e)
            {
                fetchTimelineBackgroundWorker.ReportProgress((int)(((float)e.StatusNo / (float)e.AllStatusCount) * 100), e.Status);
            };
            twitterAccount.DirectMessageAdded += delegate(object sender, DirectMessageAddedEventArgs e)
            {
                fetchDirectMessageBackgroundWorker.ReportProgress((int)(((float)e.MessageNo / (float)e.AllMessageCount) * 100), e.Message);
            };
        }

        /// <summary>
        /// CheckTimelineUpdate()の動作排他処理のためのフラグ
        /// </summary>
        private bool checkTimelineUpdateNowFlag = false;

        /// <summary>
        /// Twitterタイムラインのチェック
        /// </summary>
        private void CheckTimelineUpdate()
        {
            // タイムラインのチェック中はチェックしない
            if (checkTimelineUpdateNowFlag == true)
            {
                return;
            }

            // 排他処理のためのフラグを立てる
            checkTimelineUpdateNowFlag = true;

            try
            {
                twitterAccount.UserName = UserSettingAdapter.Setting.UserName;
                twitterAccount.Password = UserSettingAdapter.Setting.Password;
                twitterAccount.IsFetchProfileImages = UserSettingAdapter.Setting.IsFetchProfileImages;
                twitterAccount.ProxyUse = UserSettingAdapter.Setting.ProxyUse;
                twitterAccount.ProxyServer = UserSettingAdapter.Setting.ProxyServer;
                twitterAccount.ProxyPort = UserSettingAdapter.Setting.ProxyPort;
                twitterAccount.WebRequestTimeoutMillSec = TwitterAwayZweiInfo.WebRequestTimeoutMillSec;

                switch (UserSettingAdapter.Setting.CheckList)
                {
                    case UserSetting.CheckLists.Friends:
                        twitterStatuses = twitterAccount.FriendTimeline;
                        break;
                    case UserSetting.CheckLists.Public:
                        twitterStatuses = twitterAccount.PublicTimeline;
                        break;
                    default:
                        break;
                }
            }
            catch (WebException) { throw; }
            catch (UriFormatException) { throw; }
            finally
            {
                // 排他処理のためのフラグを下げる
                checkTimelineUpdateNowFlag = false;
            }
        }

        private void CheckTwitterUpdateSync()
        {
            // CheckTimelineUpdate()が処理の場合は何もせず終了
            if (checkTimelineUpdateNowFlag == true)
            {
                return;
            }

            updateMenuItem.Enabled = false;

            CheckTimelineUpdate();
            UpdateTimelineListView(twitterStatuses);

            updateMenuItem.Enabled = true;
        }

        private void CheckTwitterUpdateAsync()
        {
            // 非同期処理でタイムラインの取得中は何もせず終了
            if (fetchTimelineBackgroundWorker.IsBusy == true)
            {
                return;
            }

            // CheckTimelineUpdate()が処理の場合は何もせず終了
            if (checkTimelineUpdateNowFlag == true)
            {
                return;
            }

            fetchTimelineBackgroundWorker.RunWorkerAsync();
        }

        /// <summary>
        /// リストビューに StatusInfomation を設定する
        /// </summary>
        /// <param name="addStatus"></param>
        private void UpdateTimelineListView(StatusInfomation[] statuses)
        {
            timelineTwitterListView.Items.Clear();

            if (statuses == null)
            {
                return;
            }

            timelineTwitterListView.BeginUpdate();
            foreach (StatusInfomation status in statuses)
            {
                AddStatusToListView(status);
            }
            timelineTwitterListView.EndUpdate();
        }

        /// <summary>
        /// リストビューに StatusInfomation を追加する
        /// </summary>
        /// <param name="addStatus"></param>
        private void AddStatusToListView(StatusInfomation addStatus)
        {
            string date = string.Empty;
            if (DateTime.Today <= addStatus.CreatedAt)
            {
                TimeSpan span = DateTime.Now.Subtract(addStatus.CreatedAt);
                if (0 <= span.Minutes && span.Minutes < 1 && span.Hours == 0)
                {
                    date = string.Format(stringResource.GetString("SecAgo"), span.Seconds.ToString());
                }
                else if (0 <= span.Hours && span.Hours < 1 && span.Days == 0)
                {
                    date = string.Format(stringResource.GetString("MinAgo"), span.Minutes.ToString());
                }
                else
                {
                    date = string.Format(stringResource.GetString("HourAgo"), span.Hours.ToString());
                }
            }
            else
            {
                date = addStatus.CreatedAt.ToString("d", null);
            }

            string[] str = { addStatus.User.Name, addStatus.Text, date };

            ListViewItem item = new ListViewItem(str);
            item.Tag = addStatus;
            if (addStatus.User.ProfileImageUrl != null)
            {
                item.ImageIndex = twitterAccount.GetProfileImageIndex(addStatus.User.ProfileImageUrl);
            }
            timelineTwitterListView.Items.Add(item);
        }

        /// <summary>
        /// CheckDirectMessageUpdate()の動作排他処理のためのフラグ
        /// </summary>
        private bool checkDirectMessageUpdateNowFlag = false;

        /// <summary>
        /// Twitterダイレクトメッセージのチェック
        /// </summary>
        private void CheckDirectMessageUpdate()
        {
            // タイムラインのチェック中はチェックしない
            if (checkDirectMessageUpdateNowFlag == true)
            {
                return;
            }

            // 排他処理のためのフラグを立てる
            checkDirectMessageUpdateNowFlag = true;

            try
            {
                twitterAccount.UserName = UserSettingAdapter.Setting.UserName;
                twitterAccount.Password = UserSettingAdapter.Setting.Password;
                twitterDirectMessages = twitterAccount.DirectMessage;
            }
            catch (WebException) { throw; }
            catch (UriFormatException) { throw; }
            finally
            {
                // 排他処理のためのフラグを下げる
                checkDirectMessageUpdateNowFlag = false;
            }
        }

        private void CheckDirectMessageUpdateSync()
        {
            // CheckDirectMessageUpdate()が処理の場合は何もせず終了
            if (checkDirectMessageUpdateNowFlag == true)
            {
                return;
            }

            CheckDirectMessageUpdate();
            UpdateDirectMessageListView(twitterDirectMessages);
        }

        private void CheckDirectMessageUpdateAsync()
        {
            // 非同期処理でタイムラインの取得中は何もせず終了
            if (fetchDirectMessageBackgroundWorker.IsBusy == true)
            {
                return;
            }

            // CheckDirectMessageUpdate()が処理の場合は何もせず終了
            if (checkDirectMessageUpdateNowFlag == true)
            {
                return;
            }

            fetchDirectMessageBackgroundWorker.RunWorkerAsync();
        }

        /// <summary>
        /// リストビューに DirectMessage を設定する
        /// </summary>
        /// <param name="addStatus"></param>
        private void UpdateDirectMessageListView(DirectMessage[] messages)
        {
            messageTwitterListView.Items.Clear();

            if (messages == null)
            {
                return;
            }

            messageTwitterListView.BeginUpdate();
            foreach (DirectMessage message in messages)
            {
                AddMessageToListView(message);
            }
            messageTwitterListView.EndUpdate();
        }

        /// <summary>
        /// リストビューに DirectMessage を追加する
        /// </summary>
        /// <param name="addStatus"></param>
        private void AddMessageToListView(DirectMessage message)
        {
            string date = string.Empty;
            if (DateTime.Today <= message.CreatedAt)
            {
                TimeSpan span = DateTime.Now.Subtract(message.CreatedAt);
                if (0 <= span.Minutes && span.Minutes < 1 && span.Hours == 0)
                {
                    date = string.Format(stringResource.GetString("SecAgo"), span.Seconds.ToString());
                }
                else if (0 <= span.Hours && span.Hours < 1 && span.Days == 0)
                {
                    date = string.Format(stringResource.GetString("MinAgo"), span.Minutes.ToString());
                }
                else
                {
                    date = string.Format(stringResource.GetString("HourAgo"), span.Hours.ToString());
                }
            }
            else
            {
                date = message.CreatedAt.ToString("d", null);
            }

            string[] str = { message.SenderScreenName, message.Text, date };

            ListViewItem item = new ListViewItem(str);
            item.Tag = message;
            messageTwitterListView.Items.Add(item);
        }


        /// <summary>
        /// 自動チェックを有効にする
        /// </summary>
        private void EnableAutomaticaryCheck()
        {
            // 起動時にタイムラインをチェック
            CheckTwitterUpdateAsync();

            // 起動時にダイレクトメッセージをチェック
            CheckDirectMessageUpdateAsync();

            // 自動チェックのフラグを立てる
            automaticaryCheck = true;
        }

        /// <summary>
        /// 自動チェックを無効にする
        /// </summary>
        private void DisableAutomaticaryCheck()
        {
            // スレッドを中止
            fetchTimelineBackgroundWorker.CancelAsync();
            fetchDirectMessageBackgroundWorker.CancelAsync();
            updateTwitterBackgroundWorker.CancelAsync();

            ResetPassesSecendsPriviousFetch();

            // 自動チェックのフラグを下げる
            automaticaryCheck = false;
        }

        /// <summary>
        /// 入力されたテキストの状態を見て、TwitButtonの有効無効を切り替える
        /// </summary>
        private void SwitchEnableUpdateButton()
        {
            if (doingTextBox.Text.Length > 0)
            {
                twitButton.Enabled = true;
            }
            else
            {
                twitButton.Enabled = false;
            }
        }

        /// <summary>
        /// フォームに関する設定を呼び出す
        /// </summary>
        private void LoadFormSetting()
        {
            automaticaryCheck = UserSettingAdapter.Setting.AutomaticaryCheck;
            topPanel.Height = UserSettingAdapter.Setting.TopPanelHeight;
            timelineTwitterListView.Columns[0].Width = UserSettingAdapter.Setting.TimelineTwitterListViewNameColumnWidth;
            timelineTwitterListView.Columns[1].Width = UserSettingAdapter.Setting.TimelineTwitterListViewDoingColumnWidth;
            timelineTwitterListView.Columns[2].Width = UserSettingAdapter.Setting.TimelineTwitterListViewDateColumnWidth;
            messageTwitterListView.Columns[0].Width = UserSettingAdapter.Setting.MessageTwitterListViewNameColumnWidth;
            messageTwitterListView.Columns[1].Width = UserSettingAdapter.Setting.MessageTwitterListViewMessageColumnWidth;
            messageTwitterListView.Columns[2].Width = UserSettingAdapter.Setting.MessageTwitterListViewDateColumnWidth;
        }

        /// <summary>
        /// フォームに関する設定を保存する
        /// </summary>
        private void SaveFormSetting()
        {
            UserSettingAdapter.Setting.AutomaticaryCheck = automaticaryCheck;
            UserSettingAdapter.Setting.TopPanelHeight = topPanel.Height;
            UserSettingAdapter.Setting.TimelineTwitterListViewNameColumnWidth = timelineTwitterListView.Columns[0].Width;
            UserSettingAdapter.Setting.TimelineTwitterListViewDoingColumnWidth = timelineTwitterListView.Columns[1].Width;
            UserSettingAdapter.Setting.TimelineTwitterListViewDateColumnWidth = timelineTwitterListView.Columns[2].Width;
            UserSettingAdapter.Setting.MessageTwitterListViewNameColumnWidth = messageTwitterListView.Columns[0].Width;
            UserSettingAdapter.Setting.MessageTwitterListViewMessageColumnWidth = messageTwitterListView.Columns[1].Width;
            UserSettingAdapter.Setting.MessageTwitterListViewDateColumnWidth = messageTwitterListView.Columns[2].Width;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // フォームのテキストバーを設定
            this.Text = AssemblyUtility.Title;

            SwitchEnableUpdateButton();

            // 設定の復元
            LoadFormSetting();

            timelineTwitterListView.SmallImageList = twitterAccount.ProfileSmallImageList;
            timelineTwitterListView.LargeImageList = twitterAccount.ProfileLargeImageList;

            // タイマーを有効にする
            fetchTimelineTimer.Enabled = true;

            if (automaticaryCheck == true)
            {
                automaticaryUpdateMenuItem.Checked = true;
                EnableAutomaticaryCheck();
            }
            else
            {
                automaticaryUpdateMenuItem.Checked = false;
            }
        }

        private void MainForm_Closing(object sender, CancelEventArgs e)
        {
            SaveFormSetting();
        }

        /// <summary>
        /// 前回のタイムラインの取得から過ぎた時間
        /// </summary>
        private int passesSecendsPreviousFetchTimeline = 0;

        /// <summary>
        /// 前回のタイムラインの取得から過ぎた時間
        /// </summary>
        private int passesSecendsPreviousFetchDirectMessage = 0;

        /// <summary>
        /// エラーを表示してから経過した時間
        /// </summary>
        private int passesSecendsShowError = 0;

        /// <summary>
        /// エラーを表示する時間
        /// </summary>
        private const int ERROR_SHOW_SEC = 10;

        private void fetchTimelineTimer_Tick(object sender, EventArgs e)
        {
            if (automaticaryCheck == true)
            {
                #region タイムライン取得

                if (passesSecendsPreviousFetchTimeline >= (UserSettingAdapter.Setting.UpdateTimulineInterval))
                {
                    passesSecendsPreviousFetchTimeline = 0;
                    CheckTwitterUpdateAsync();
                }
                else
                {
                    ++passesSecendsPreviousFetchTimeline;
                }

                #endregion // タイムライン取得

                #region ダイレクトメッセージ取得

                if (passesSecendsPreviousFetchTimeline >= (UserSettingAdapter.Setting.UpdateDirectMessageInterval))
                {
                    passesSecendsPreviousFetchTimeline = 0;
                    CheckDirectMessageUpdateAsync();
                }
                else
                {
                    ++passesSecendsPreviousFetchDirectMessage;
                }

                #endregion // ダイレクトメッセージ取得
            }

            #region エラー表示

            if (passesSecendsShowError >= ERROR_SHOW_SEC)
            {
                errorTextStatusBar = string.Empty;
                passesSecendsShowError = 0;
            }
            else if (errorTextStatusBar == string.Empty)
            {
                passesSecendsShowError = 0;
            }
            else
            {
                ++passesSecendsShowError;
            }

            #endregion // エラー表示

            StringBuilder statusBarString = new StringBuilder();
            if (automaticaryCheck == true)
            {
                statusBarString = statusBarString.Append(UserSettingAdapter.Setting.UpdateTimulineInterval - passesSecendsPreviousFetchTimeline + " sec.");
            }
            if (checkTimelineUpdateNowFlag == true)
            {
                statusBarString.Append(" タイムライン取得中");
            }
            if (passesSecendsShowError > 0 && errorTextStatusBar != string.Empty)
            {
                statusBarString.Append(" " + errorTextStatusBar);
            }
            mainStatusBar.Text = statusBarString.ToString();
        }

        /// <summary>
        /// タイムラインやダイレクトメッセージを取得してからの経過時間をリセットする
        /// </summary>
        private void ResetPassesSecendsPriviousFetch()
        {
            passesSecendsPreviousFetchTimeline = 0;
            passesSecendsPreviousFetchDirectMessage = 0;
        }

        private delegate void MethodInvokeDelegate();

        private void fetchTimelineTwitterBackgroundWorker_DoWork(object sender, OpenNETCF.ComponentModel.DoWorkEventArgs e)
        {
            this.Invoke(new MethodInvokeDelegate(delegate
            {
                updateMenuItem.Enabled = false;
            }));

            CheckTimelineUpdate();
        }

        private void fetchTimelineBackgroundWorker_ProgressChanged(object sender, OpenNETCF.ComponentModel.ProgressChangedEventArgs e)
        {
            ;
        }

        private delegate void UpdateTimelineListViewViewDelegate(StatusInfomation[] statuses);

        private void fetchTimelineTwitterBackgroundWorker_RunWorkerCompleted(object sender, OpenNETCF.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                ;
            }
            else if (e.Error == null)
            {
                if (this.InvokeRequired == true)
                {
                    Invoke(new UpdateTimelineListViewViewDelegate(UpdateTimelineListView), new object[] { twitterStatuses });
                }
                else
                {
                    UpdateTimelineListView(twitterStatuses);
                }
            }
            else
            {
                if (e.Error is WebException)
                {
                    switch (((WebException)e.Error).Status)
                    {
                        case WebExceptionStatus.ProtocolError:
                            errorTextStatusBar = string.Format("{0}{1}", stringResource.GetString("PrefixTimeline"), stringResource.GetString("UserNameORPasswordWrong"));
                            break;
                        case WebExceptionStatus.Timeout:
                            errorTextStatusBar = string.Format("{0}{1}", stringResource.GetString("PrefixTimeline"), stringResource.GetString("ConnectionTimuout"));
                            break;
                        default:
                            errorTextStatusBar = string.Format("{0}{1}", stringResource.GetString("PrefixTimeline"), stringResource.GetString("NotAbleToBeFetch"));
                            break;
                    }
                }
            }

            this.Invoke(new MethodInvokeDelegate(delegate
            {
                updateMenuItem.Enabled = true;
            }));
        }

        private void fetchDirectMessageBackgroundWorker_DoWork(object sender, OpenNETCF.ComponentModel.DoWorkEventArgs e)
        {
            CheckDirectMessageUpdate();
        }

        private void fetchDirectMessageBackgroundWorker_ProgressChanged(object sender, OpenNETCF.ComponentModel.ProgressChangedEventArgs e)
        {
            ;
        }

        private delegate void UpdateDirectMessageListViewDelegate(DirectMessage[] messages);

        private void fetchDirectMessageBackgroundWorker_RunWorkerCompleted(object sender, OpenNETCF.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                ;
            }
            else if (e.Error == null)
            {
                if (this.InvokeRequired == true)
                {
                    Invoke(new UpdateDirectMessageListViewDelegate(UpdateDirectMessageListView), new object[] { twitterDirectMessages });
                }
                else
                {
                    UpdateDirectMessageListView(twitterDirectMessages);
                }
            }
            else
            {
                if (e.Error is WebException)
                {
                    switch (((WebException)e.Error).Status)
                    {
                        case WebExceptionStatus.ProtocolError:
                            errorTextStatusBar = string.Format("{0}{1}", stringResource.GetString("PrefixDirectMessage"), stringResource.GetString("UserNameORPasswordWrong"));
                            break;
                        case WebExceptionStatus.Timeout:
                            errorTextStatusBar = string.Format("{0}{1}", stringResource.GetString("PrefixDirectMessage"), stringResource.GetString("ConnectionTimuout"));
                            break;
                        default:
                            errorTextStatusBar = string.Format("{0}{1}", stringResource.GetString("PrefixDirectMessage"), stringResource.GetString("NotAbleToBeFetch"));
                            break;
                    }
                }
            }
        }

        private void updateTwitterBackgroundWorker_DoWork(object sender, OpenNETCF.ComponentModel.DoWorkEventArgs e)
        {
            string message = e.Argument as string;
            if (message != null)
            {
                twitterAccount.Update(message);
            }
        }

        private void updateTwitterBackgroundWorker_ProgressChanged(object sender, OpenNETCF.ComponentModel.ProgressChangedEventArgs e)
        {
            ;
        }

        private void updateTwitterBackgroundWorker_RunWorkerCompleted(object sender, OpenNETCF.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                if (e.Error is WebException)
                {
                    switch (((WebException)e.Error).Status)
                    {
                        case WebExceptionStatus.ProtocolError:
                            errorTextStatusBar = string.Format("{0}{1}", stringResource.GetString("PrefixTwitter"), stringResource.GetString("UserNameORPasswordWrong"));
                            break;
                        case WebExceptionStatus.Timeout:
                            errorTextStatusBar = string.Format("{0}{1}", stringResource.GetString("PrefixTwitter"), stringResource.GetString("ConnectionTimuout"));
                            break;
                        default:
                            errorTextStatusBar = string.Format("{0}{1}", stringResource.GetString("PrefixTwitter"), stringResource.GetString("NotAbleToBeFetch"));
                            break;
                    }
                }
                else if (e.Error is UriFormatException)
                {

                    errorTextStatusBar = string.Format("{0}{1}", stringResource.GetString("PrefixTwitter"), stringResource.GetString("NotAbleToBeUpdate"));
                }
            }

            twitButton.Enabled = true;
        }

        private void twitterListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // リストビューに選択がある場合
            if (timelineTwitterListView.SelectedIndices.Count == 1 && timelineTwitterListView.SelectedIndices[0] < twitterStatuses.Length)
            {
                StatusInfomation status = timelineTwitterListView.Items[timelineTwitterListView.SelectedIndices[0]].Tag as StatusInfomation;
                if (status != null)
                {
                    doingInfomationTextLabel.Text = status.User.Name + " / " + status.User.ScreenName + "\r\n" + status.Text;

                    twitterIconPictureBox.Image = twitterAccount.GetProfileLargeImage(status.User.ProfileImageUrl);
                }
            }
            // リストビューに選択がない場合
            else
            {
                doingInfomationTextLabel.Text = string.Empty;
                twitterIconPictureBox.Image = null;
            }
        }

        private void messageTwitterListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // リストビューに選択がある場合
            if (messageTwitterListView.SelectedIndices.Count == 1 && messageTwitterListView.SelectedIndices[0] < twitterDirectMessages.Length)
            {
                DirectMessage message = messageTwitterListView.Items[messageTwitterListView.SelectedIndices[0]].Tag as DirectMessage;
                if (message != null)
                {
                    doingInfomationTextLabel.Text = message.SenderScreenName + "\r\n" + message.Text;

                    twitterIconPictureBox.Image = null;
                }
            }
            // リストビューに選択がない場合
            else
            {
                doingInfomationTextLabel.Text = string.Empty;
                twitterIconPictureBox.Image = null;
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            SaveFormSetting();

            // タイマーを止める
            fetchTimelineTimer.Enabled = false;

            // スレッドを中止
            fetchTimelineBackgroundWorker.CancelAsync();
            fetchDirectMessageBackgroundWorker.CancelAsync();
            updateTwitterBackgroundWorker.CancelAsync();

            // スレッドが中止されるまで待つ
            while (fetchTimelineBackgroundWorker.IsBusy == true || fetchDirectMessageBackgroundWorker.IsBusy == true || updateTwitterBackgroundWorker.IsBusy == true)
            {
                System.Threading.Thread.Sleep(100);
            }

            Application.Exit();
        }

        private void settingMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.ShowDialog();
            settingForm.Dispose();

            ResetPassesSecendsPriviousFetch();
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
            aboutForm.Dispose();
        }

        private void twitButton_Click(object sender, EventArgs e)
        {
            if (updateTwitterBackgroundWorker.IsBusy == false)
            {
                twitButton.Enabled = false;
                string message = doingTextBox.Text;
                doingTextBox.Text = string.Empty;
                updateTwitterBackgroundWorker.RunWorkerAsync(message);
            }
        }

        private void cutMenuItem_Click(object sender, EventArgs e)
        {
            doingTextBox.Cut();
        }

        private void copyMenuItem_Click(object sender, EventArgs e)
        {
            doingTextBox.Copy();
        }

        private void pasteMenuItem_Click(object sender, EventArgs e)
        {
            doingTextBox.Paste();
        }

        private void timelineContextMenu_Popup(object sender, EventArgs e)
        {
            if (timelineTwitterListView.SelectedIndices.Count > 0 &&
                timelineTwitterListView.Items[timelineTwitterListView.SelectedIndices[0]].Tag is StatusInfomation)
            {
                timelineReplyMenuItem.Enabled = true;
                timelineDirectMessageMenuItem.Enabled = true;
            }
            else
            {
                timelineReplyMenuItem.Enabled = false;
                timelineDirectMessageMenuItem.Enabled = false;
            }
        }

        private void timelineReplyMenuItem_Click(object sender, EventArgs e)
        {
            if (timelineTwitterListView.SelectedIndices.Count > 0 &&
                timelineTwitterListView.Items[timelineTwitterListView.SelectedIndices[0]].Tag is StatusInfomation)
            {
                StatusInfomation status = (StatusInfomation)timelineTwitterListView.Items[timelineTwitterListView.SelectedIndices[0]].Tag;
                doingTextBox.Text = string.Format("@{0} {1}", status.User.ScreenName, doingTextBox.Text);
            }
        }

        private void timelineDirectMessageMenuItem_Click(object sender, EventArgs e)
        {
            if (timelineTwitterListView.SelectedIndices.Count > 0 &&
                timelineTwitterListView.Items[timelineTwitterListView.SelectedIndices[0]].Tag is StatusInfomation)
            {
                StatusInfomation status = (StatusInfomation)timelineTwitterListView.Items[timelineTwitterListView.SelectedIndices[0]].Tag;
                doingTextBox.Text = string.Format("D {0} {1}", status.User.ScreenName, doingTextBox.Text);
            }
        }


        private void messagesContextMenu_Popup(object sender, EventArgs e)
        {
            if (messageTwitterListView.SelectedIndices.Count > 0 &&
                messageTwitterListView.Items[messageTwitterListView.SelectedIndices[0]].Tag is DirectMessage)
            {
                messagesReplayMenuItem.Enabled = true;
                messagesDirectMessageMenuItem.Enabled = true;
            }
            else
            {
                messagesReplayMenuItem.Enabled = false;
                messagesDirectMessageMenuItem.Enabled = false;
            }
        }

        private void messagesReplayMenuItem_Click(object sender, EventArgs e)
        {
            if (messageTwitterListView.SelectedIndices.Count > 0 &&
                messageTwitterListView.Items[messageTwitterListView.SelectedIndices[0]].Tag is DirectMessage)
            {
                DirectMessage message = (DirectMessage)messageTwitterListView.Items[messageTwitterListView.SelectedIndices[0]].Tag;
                doingTextBox.Text = string.Format("@{0} {1}", message.SenderScreenName, doingTextBox.Text);
            }
        }

        private void messagesDirectMessageMenuItem_Click(object sender, EventArgs e)
        {
            if (messageTwitterListView.SelectedIndices.Count > 0 &&
                messageTwitterListView.Items[messageTwitterListView.SelectedIndices[0]].Tag is DirectMessage)
            {
                DirectMessage message = (DirectMessage)messageTwitterListView.Items[messageTwitterListView.SelectedIndices[0]].Tag;
                doingTextBox.Text = string.Format("D {0} {1}", message.SenderScreenName, doingTextBox.Text);
            }
        }

        private void automaticaryUpdateMenuItem_Click(object sender, EventArgs e)
        {
            if (automaticaryCheck == true)
            {
                DisableAutomaticaryCheck();
                automaticaryUpdateMenuItem.Checked = false;
            }
            else
            {
                EnableAutomaticaryCheck();
                automaticaryUpdateMenuItem.Checked = true;
            }
        }

        private void doingTextBox_TextChanged(object sender, EventArgs e)
        {
            SwitchEnableUpdateButton();
        }

        private void bottomPanel_Paint(object sender, PaintEventArgs e)
        {
            if (UserSettingAdapter.Setting.TimelineListFontSize == UserSetting.TimelineListFontSizes.DefaultSize)
            {
                Font font = new Font(timelineTwitterListView.Font.Name, TwitterAwayZweiInfo.TimelineListDefaultFontSize, timelineTwitterListView.Font.Style);
                timelineTwitterListView.Font = font;
                messageTwitterListView.Font = font;
            }
            else
            {
                Font font = new Font(timelineTwitterListView.Font.Name, (int)UserSettingAdapter.Setting.TimelineListFontSize, timelineTwitterListView.Font.Style);
                timelineTwitterListView.Font = font;
                messageTwitterListView.Font = font;
            }
        }

        private void updateMenuItem_Click(object sender, EventArgs e)
        {
            CheckTwitterUpdateAsync();
        }
    }
}
