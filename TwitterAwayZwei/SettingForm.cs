using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace TwitterAwayZwei
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            // タイムライン取得間隔の上限と下限
            checkTimelineIntervalNumericUpDown.Minimum = TwitterAwayZweiInfo.UpdateTimulineIntervalMinimumSec;
            checkTimelineIntervalNumericUpDown.Maximum = TwitterAwayZweiInfo.UpdateTimulineIntervalMaximumSec;

            // ダイレクトメッセージ取得間隔の上限と下限
            checkDirectMessageIntervalNumericUpDown.Minimum = TwitterAwayZweiInfo.UpdateDirectMessageIntervalMinimumSec;
            checkDirectMessageIntervalNumericUpDown.Maximum = TwitterAwayZweiInfo.UpdateDirectMessageIntervalMaximumSec;

            #region 設定の読み込み

            switch (UserSettingAdapter.Setting.TimelineListFontSize)
            {
                case UserSetting.TimelineListFontSizes.Size6pt:
                    timelineListFontSizeDomainUpDown.SelectedIndex = 1;
                    break;
                case UserSetting.TimelineListFontSizes.Size7pt:
                    timelineListFontSizeDomainUpDown.SelectedIndex = 2;
                    break;
                case UserSetting.TimelineListFontSizes.Size8pt:
                    timelineListFontSizeDomainUpDown.SelectedIndex = 3;
                    break;
                case UserSetting.TimelineListFontSizes.Size9pt:
                    timelineListFontSizeDomainUpDown.SelectedIndex = 4;
                    break;
                case UserSetting.TimelineListFontSizes.Size10pt:
                    timelineListFontSizeDomainUpDown.SelectedIndex = 5;
                    break;
                case UserSetting.TimelineListFontSizes.Size11pt:
                    timelineListFontSizeDomainUpDown.SelectedIndex = 6;
                    break;
                case UserSetting.TimelineListFontSizes.Size12pt:
                    timelineListFontSizeDomainUpDown.SelectedIndex = 7;
                    break;
                case UserSetting.TimelineListFontSizes.Size13pt:
                    timelineListFontSizeDomainUpDown.SelectedIndex = 8;
                    break;
                case UserSetting.TimelineListFontSizes.Size14pt:
                    timelineListFontSizeDomainUpDown.SelectedIndex = 9;
                    break;
                case UserSetting.TimelineListFontSizes.Size15pt:
                    timelineListFontSizeDomainUpDown.SelectedIndex = 10;
                    break;
                case UserSetting.TimelineListFontSizes.Size16pt:
                    timelineListFontSizeDomainUpDown.SelectedIndex = 11;
                    break;
                case UserSetting.TimelineListFontSizes.Size17pt:
                    timelineListFontSizeDomainUpDown.SelectedIndex = 12;
                    break;
                case UserSetting.TimelineListFontSizes.Size18pt:
                    timelineListFontSizeDomainUpDown.SelectedIndex = 13;
                    break;
                case UserSetting.TimelineListFontSizes.Size19pt:
                    timelineListFontSizeDomainUpDown.SelectedIndex = 14;
                    break;
                case UserSetting.TimelineListFontSizes.Size20pt:
                    timelineListFontSizeDomainUpDown.SelectedIndex = 15;
                    break;
                case UserSetting.TimelineListFontSizes.DefaultSize:
                default:
                    timelineListFontSizeDomainUpDown.SelectedIndex = 0;
                    break;
            }

            userNameTextBox.Text = UserSettingAdapter.Setting.UserName;
            passwordTextBox.Text = UserSettingAdapter.Setting.Password;

            switch (UserSettingAdapter.Setting.CheckList)
            {
                case UserSetting.CheckLists.Friends:
                    checkFriendsRadioButton.Checked = true;
                    checkPublicRadioButton.Checked = false;
                    break;
                case UserSetting.CheckLists.Public:
                    checkFriendsRadioButton.Checked = false;
                    checkPublicRadioButton.Checked = true;
                    break;
                default:
                    // ここに到達することはあり得ない
                    Trace.Assert(false, "想定外の動作のため、終了します");
                    break;
            }

            fetchProfileIconsCheckBox.Checked = UserSettingAdapter.Setting.IsFetchProfileImages;

            checkTimelineIntervalNumericUpDown.Text = (UserSettingAdapter.Setting.UpdateTimulineInterval).ToString();
            checkDirectMessageIntervalNumericUpDown.Text = (UserSettingAdapter.Setting.UpdateDirectMessageInterval).ToString();

            switch (UserSettingAdapter.Setting.ProxyUse)
            {
                case Twitter.Twitter.ProxyConnects.Unuse:
                    proxyUnuseRadioButton.Checked = true;
                    proxyUseOsSettingRadioButton.Checked = false;
                    proxyUseOriginalSettingRadioButton.Checked = false;
                    break;
                case Twitter.Twitter.ProxyConnects.OsSetting:
                    proxyUnuseRadioButton.Checked = false;
                    proxyUseOsSettingRadioButton.Checked = true;
                    proxyUseOriginalSettingRadioButton.Checked = false;
                    break;
                case Twitter.Twitter.ProxyConnects.OriginalSetting:
                    proxyUnuseRadioButton.Checked = false;
                    proxyUseOsSettingRadioButton.Checked = false;
                    proxyUseOriginalSettingRadioButton.Checked = true;
                    break;
                default:
                    // ここに到達することはあり得ない
                    Trace.Assert(false, "想定外の動作のため、終了します");
                    break;
            }

            proxyServerTextBox.Text = UserSettingAdapter.Setting.ProxyServer;
            proxyPortTextBox.Text = UserSettingAdapter.Setting.ProxyPort.ToString();

            #endregion
        }

        private void SettingForm_Closing(object sender, CancelEventArgs e)
        {
            #region 設定の書き込み

            switch (timelineListFontSizeDomainUpDown.SelectedIndex)
            {
                case 1:
                    UserSettingAdapter.Setting.TimelineListFontSize = UserSetting.TimelineListFontSizes.Size6pt;
                    break;
                case 2:
                    UserSettingAdapter.Setting.TimelineListFontSize = UserSetting.TimelineListFontSizes.Size7pt;
                    break;
                case 3:
                    UserSettingAdapter.Setting.TimelineListFontSize = UserSetting.TimelineListFontSizes.Size8pt;
                    break;
                case 4:
                    UserSettingAdapter.Setting.TimelineListFontSize = UserSetting.TimelineListFontSizes.Size9pt;
                    break;
                case 5:
                    UserSettingAdapter.Setting.TimelineListFontSize = UserSetting.TimelineListFontSizes.Size10pt;
                    break;
                case 6:
                    UserSettingAdapter.Setting.TimelineListFontSize = UserSetting.TimelineListFontSizes.Size11pt;
                    break;
                case 7:
                    UserSettingAdapter.Setting.TimelineListFontSize = UserSetting.TimelineListFontSizes.Size12pt;
                    break;
                case 8:
                    UserSettingAdapter.Setting.TimelineListFontSize = UserSetting.TimelineListFontSizes.Size13pt;
                    break;
                case 9:
                    UserSettingAdapter.Setting.TimelineListFontSize = UserSetting.TimelineListFontSizes.Size14pt;
                    break;
                case 10:
                    UserSettingAdapter.Setting.TimelineListFontSize = UserSetting.TimelineListFontSizes.Size15pt;
                    break;
                case 11:
                    UserSettingAdapter.Setting.TimelineListFontSize = UserSetting.TimelineListFontSizes.Size16pt;
                    break;
                case 12:
                    UserSettingAdapter.Setting.TimelineListFontSize = UserSetting.TimelineListFontSizes.Size17pt;
                    break;
                case 13:
                    UserSettingAdapter.Setting.TimelineListFontSize = UserSetting.TimelineListFontSizes.Size18pt;
                    break;
                case 14:
                    UserSettingAdapter.Setting.TimelineListFontSize = UserSetting.TimelineListFontSizes.Size19pt;
                    break;
                case 15:
                    UserSettingAdapter.Setting.TimelineListFontSize = UserSetting.TimelineListFontSizes.Size20pt;
                    break;
                case 0:
                default:
                    UserSettingAdapter.Setting.TimelineListFontSize = UserSetting.TimelineListFontSizes.DefaultSize;
                    break;
            }

            UserSettingAdapter.Setting.UserName = userNameTextBox.Text;
            UserSettingAdapter.Setting.Password = passwordTextBox.Text;

            if (checkFriendsRadioButton.Checked == true)
            {
                UserSettingAdapter.Setting.CheckList = UserSetting.CheckLists.Friends;
            }
            else if (checkPublicRadioButton.Checked == true)
            {
                UserSettingAdapter.Setting.CheckList = UserSetting.CheckLists.Public;
            }
            else
            {
                // ここに到達することはあり得ない
                Trace.Assert(false, "想定外の動作のため、終了します");
            }

            UserSettingAdapter.Setting.IsFetchProfileImages = fetchProfileIconsCheckBox.Checked;

            try
            {
                UserSettingAdapter.Setting.UpdateTimulineInterval = Convert.ToInt32(checkTimelineIntervalNumericUpDown.Text);
            }
            catch (ArgumentException) { ; }
            catch (FormatException) { ; }
            catch (OverflowException) { ; }

            try
            {
                UserSettingAdapter.Setting.UpdateDirectMessageInterval = Convert.ToInt32(checkDirectMessageIntervalNumericUpDown.Text);
            }
            catch (ArgumentException) { ; }
            catch (FormatException) { ; }
            catch (OverflowException) { ; }

            if (proxyUnuseRadioButton.Checked == true)
            {
                UserSettingAdapter.Setting.ProxyUse = Twitter.Twitter.ProxyConnects.Unuse;
            }
            else if (proxyUseOsSettingRadioButton.Checked == true)
            {
                UserSettingAdapter.Setting.ProxyUse = Twitter.Twitter.ProxyConnects.OsSetting;
            }
            else if (proxyUseOriginalSettingRadioButton.Checked == true)
            {
                UserSettingAdapter.Setting.ProxyUse = Twitter.Twitter.ProxyConnects.OriginalSetting;
            }
            else
            {
                // ここに到達することはあり得ない
                Trace.Assert(false, "想定外の動作のため、終了します");
            }
            UserSettingAdapter.Setting.ProxyServer = proxyServerTextBox.Text.Trim();
            try
            {
                UserSettingAdapter.Setting.ProxyPort = int.Parse(proxyPortTextBox.Text.Trim());
            }
            catch (ArgumentException) { ; }
            catch (FormatException) { ; }
            catch (OverflowException) { ; }

            try
            {
                UserSettingAdapter.Save();
            }
            catch (IOException)
            {
                MessageBox.Show("設定ファイルが書き込めませんでした", "設定ファイル書き込みエラー");
            }

            #endregion
        }

        private void userNameCutMenuItem_Click(object sender, EventArgs e)
        {
            userNameTextBox.Cut();
        }

        private void userNameCopyMenuItem_Click(object sender, EventArgs e)
        {
            userNameTextBox.Copy();
        }

        private void userNamePasteMenuItem_Click(object sender, EventArgs e)
        {
            userNameTextBox.Paste();
        }

        private void passwordCutMenuItem_Click(object sender, EventArgs e)
        {
            passwordTextBox.Cut();
        }

        private void passwordCopyMenuItem_Click(object sender, EventArgs e)
        {
            passwordTextBox.Copy();
        }

        private void passwordPasteMenuItem_Click(object sender, EventArgs e)
        {
            passwordTextBox.Paste();
        }

        private void proxyServerCutMenuItem_Click(object sender, EventArgs e)
        {
            proxyServerTextBox.Cut();
        }

        private void proxyServerCopyMenuItem_Click(object sender, EventArgs e)
        {
            proxyServerTextBox.Copy();
        }

        private void proxyServerPasteMenuItem_Click(object sender, EventArgs e)
        {
            proxyServerTextBox.Paste();
        }

        private void proxyPortCutMenuItem_Click(object sender, EventArgs e)
        {
            proxyPortTextBox.Cut();
        }

        private void proxyPortCopyMenuItem_Click(object sender, EventArgs e)
        {
            proxyPortTextBox.Copy();
        }

        private void proxyPortPasteMenuItem_Click(object sender, EventArgs e)
        {

            proxyPortTextBox.Paste();
        }
    }
}