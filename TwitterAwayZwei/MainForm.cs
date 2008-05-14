﻿using System;

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

            CheckTimelineUpdate();
            UpdateTimelineListView(twitterStatuses);
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
            timilineTwitterListView.Items.Clear();

            if (statuses == null)
            {
                return;
            }

            timilineTwitterListView.BeginUpdate();
            foreach (StatusInfomation status in statuses)
            {
                AddStatusToListView(status);
            }
            timilineTwitterListView.EndUpdate();
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
                if (span.Minutes < 1)
                {
                    date = string.Format(stringResource.GetString("SecAgo"), span.Seconds.ToString());
                }
                else if (span.Hours < 1)
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
            timilineTwitterListView.Items.Add(item);
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
                if (span.Minutes < 1)
                {
                    date = string.Format(stringResource.GetString("SecAgo"), span.Seconds.ToString());
                }
                else if (span.Hours < 1)
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
            timilineTwitterListView.Items.Add(item);
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
        /// フォームに関する設定を呼び出す
        /// </summary>
        private void LoadFormSetting()
        {
            automaticaryCheck = UserSettingAdapter.Setting.AutomaticaryCheck;
            topPanel.Height = UserSettingAdapter.Setting.TopPanelHeight;
            timilineTwitterListView.Columns[0].Width = UserSettingAdapter.Setting.TimelineTwitterListViewNameColumnWidth;
            timilineTwitterListView.Columns[1].Width = UserSettingAdapter.Setting.TimelineTwitterListViewDoingColumnWidth;
            timilineTwitterListView.Columns[2].Width = UserSettingAdapter.Setting.TimelineTwitterListViewDateColumnWidth;
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
            UserSettingAdapter.Setting.TimelineTwitterListViewNameColumnWidth = timilineTwitterListView.Columns[0].Width;
            UserSettingAdapter.Setting.TimelineTwitterListViewDoingColumnWidth = timilineTwitterListView.Columns[1].Width;
            UserSettingAdapter.Setting.TimelineTwitterListViewDateColumnWidth = timilineTwitterListView.Columns[2].Width;
            UserSettingAdapter.Setting.MessageTwitterListViewNameColumnWidth = messageTwitterListView.Columns[0].Width;
            UserSettingAdapter.Setting.MessageTwitterListViewMessageColumnWidth = messageTwitterListView.Columns[1].Width;
            UserSettingAdapter.Setting.MessageTwitterListViewDateColumnWidth = messageTwitterListView.Columns[2].Width;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // フォームのテキストバーを設定
            this.Text = AssemblyUtility.Title;

            // 設定の復元
            LoadFormSetting();

            timilineTwitterListView.SmallImageList = twitterAccount.ProfileSmallImageList;
            timilineTwitterListView.LargeImageList = twitterAccount.ProfileLargeImageList;

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

        private void fetchTimelineTwitterBackgroundWorker_DoWork(object sender, OpenNETCF.ComponentModel.DoWorkEventArgs e)
        {
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

            updateButton.Enabled = true;
        }

        private void twitterListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // リストビューに選択がある場合
            if (timilineTwitterListView.SelectedIndices.Count == 1 && timilineTwitterListView.SelectedIndices[0] < twitterStatuses.Length)
            {
                StatusInfomation status = timilineTwitterListView.Items[timilineTwitterListView.SelectedIndices[0]].Tag as StatusInfomation;
                if (status != null)
                {
                    doingInfomationTextLabel.Text = status.User.Name + "\r\n" + status.Text;

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

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (updateTwitterBackgroundWorker.IsBusy == false)
            {
                updateButton.Enabled = false;
                string message = dowingTextBox.Text;
                dowingTextBox.Text = string.Empty;
                updateTwitterBackgroundWorker.RunWorkerAsync(message);
            }
        }

        private void cutMenuItem_Click(object sender, EventArgs e)
        {
            dowingTextBox.Cut();
        }

        private void copyMenuItem_Click(object sender, EventArgs e)
        {
            dowingTextBox.Copy();
        }

        private void pasteMenuItem_Click(object sender, EventArgs e)
        {
            dowingTextBox.Paste();
        }

        private void replyMenuItem_Click(object sender, EventArgs e)
        {
            if (timilineTwitterListView.SelectedIndices.Count > 0 &&
                timilineTwitterListView.Items[timilineTwitterListView.SelectedIndices[0]].Tag is StatusInfomation)
            {
                StatusInfomation status = (StatusInfomation)timilineTwitterListView.Items[timilineTwitterListView.SelectedIndices[0]].Tag;
                dowingTextBox.Text = string.Format("@{0} {1}", status.User.ScreenName, dowingTextBox.Text);
            }
        }

        private void directMessageMenuItem_Click(object sender, EventArgs e)
        {
            if (timilineTwitterListView.SelectedIndices.Count > 0 &&
                timilineTwitterListView.Items[timilineTwitterListView.SelectedIndices[0]].Tag is StatusInfomation)
            {
                StatusInfomation status = (StatusInfomation)timilineTwitterListView.Items[timilineTwitterListView.SelectedIndices[0]].Tag;
                dowingTextBox.Text = string.Format("D {0} {1}", status.User.ScreenName, dowingTextBox.Text);
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
    }
}
