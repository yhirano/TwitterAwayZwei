using System;

using System.Xml.Serialization;

namespace TwitterAwayZwei
{
    /// <summary>
    /// TwitterAway::Zweiの設定を保持するクラス
    /// </summary>
    [Serializable()]
    public class UserSetting
    {
        /// <summary>
        /// Twitterユーザー名
        /// </summary>
        private string userName;

        /// <summary>
        /// Twitterユーザー名を取得・設定する
        /// </summary>
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        /// <summary>
        /// Twitterパスワード
        /// </summary>
        private string password;

        /// <summary>
        /// Twitterパスワードを取得・設定する
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        /// <summary>
        /// チェックするリスト
        /// </summary>
        private Twitter.Twitter.CheckLists checkList = Twitter.Twitter.CheckLists.Friends;

        /// <summary>
        /// チェックするリストを取得・設定する
        /// </summary>
        public Twitter.Twitter.CheckLists CheckList
        {
            get { return checkList; }
            set { checkList = value; }
        }

        /// <summary>
        /// タイマーでチェックするか
        /// </summary>
        private bool automaticaryCheck = true;

        /// <summary>
        /// タイマーでチェックするかを取得・設定する
        /// </summary>
        public bool AutomaticaryCheck
        {
            get { return automaticaryCheck; }
            set { automaticaryCheck = value; }
        }

        /// <summary>
        /// タイムラインの取得間隔
        /// </summary>
        private int updateTimulineInterval = 60;

        /// <summary>
        /// タイムラインの取得間隔を取得・設定する
        /// </summary>
        public int UpdateTimulineInterval
        {
            get { return updateTimulineInterval; }
            set
            {
                // 規定に収まる場合
                if (TwitterAwayZweiInfo.UpdateTimulineIntervalMinimumSec <= value && value <= TwitterAwayZweiInfo.UpdateTimulineIntervalMaximumSec)
                {
                    updateTimulineInterval = value;
                }
                // 規定よりも短い場合
                else if (value < TwitterAwayZweiInfo.UpdateTimulineIntervalMinimumSec)
                {
                    updateTimulineInterval = TwitterAwayZweiInfo.UpdateTimulineIntervalMinimumSec;
                }
                // 規定よりも長い場合
                else if (value > TwitterAwayZweiInfo.UpdateTimulineIntervalMaximumSec)
                {
                    updateTimulineInterval = TwitterAwayZweiInfo.UpdateTimulineIntervalMaximumSec;
                }
            }
        }

        /// <summary>
        /// ダイレクトメッセージの取得間隔
        /// </summary>
        private int updateDirectMessageInterval = 600;

        /// <summary>
        /// ダイレクトメッセージの取得間隔を取得・設定する
        /// </summary>
        public int UpdateDirectMessageInterval
        {
            get { return updateDirectMessageInterval; }
            set
            {
                // 規定に収まる場合
                if (TwitterAwayZweiInfo.UpdateDirectMessageIntervalMinimumSec <= value && value <= TwitterAwayZweiInfo.UpdateDirectMessageIntervalMaximumSec)
                {
                    updateDirectMessageInterval = value;
                }
                // 規定よりも短い場合
                else if (value < TwitterAwayZweiInfo.UpdateDirectMessageIntervalMinimumSec)
                {
                    updateDirectMessageInterval = TwitterAwayZweiInfo.UpdateDirectMessageIntervalMinimumSec;
                }
                // 規定よりも長い場合
                else if (value > TwitterAwayZweiInfo.UpdateDirectMessageIntervalMaximumSec)
                {
                    updateDirectMessageInterval = TwitterAwayZweiInfo.UpdateDirectMessageIntervalMaximumSec;
                }
            }
        }

        /// <summary>
        /// プロフィールイメージを取得するか
        /// </summary>
        private bool isFetchProfileImages = true;

        /// <summary>
        /// プロフィールイメージを取得するかを取得・設定する
        /// </summary>
        public bool IsFetchProfileImages
        {
            get { return isFetchProfileImages; }
            set { isFetchProfileImages = value; }
        }

        /// <summary>
        /// Timeline/Messagesリストのフォントサイズ列挙
        /// </summary>
        [Serializable()]
        public enum TimelineListFontSizes
        {
            DefaultSize,
            Size6pt = 6,
            Size7pt = 7,
            Size8pt = 8,
            Size9pt = 9,
            Size10pt = 10,
            Size11pt = 11,
            Size12pt = 12,
            Size13pt = 13,
            Size14pt = 14,
            Size15pt = 15,
            Size16pt = 16,
            Size17pt = 17,
            Size18pt = 18,
            Size19pt = 19,
            Size20pt = 20
        }

        /// <summary>
        /// Timeline/Messagesリストのフォントサイズ
        /// </summary>
        private TimelineListFontSizes timelineListFontSize = TimelineListFontSizes.DefaultSize;

        /// <summary>
        /// Timeline/Messagesリストのフォントサイズを取得・設定する
        /// </summary>
        public TimelineListFontSizes TimelineListFontSize
        {
            get { return timelineListFontSize; }
            set { timelineListFontSize = value; }
        }

        /// <summary>
        /// プロキシ設定
        /// </summary>
        private ProxySetting proxy = new ProxySetting();

        /// <summary>
        /// プロキシ設定を取得・設定する
        /// </summary>
        public ProxySetting Proxy
        {
            get { return proxy; }
            set { proxy = value; }
        }

        /// <summary>
        /// メインフォームのスプリッターの位置
        /// </summary>
        private int topPanelHeight = 120;

        /// <summary>
        /// メインフォームのスプリッターの位置を取得・設定する
        /// </summary>
        public int TopPanelHeight
        {
            get { return topPanelHeight; }
            set
            {
                if (topPanelHeight >= 0)
                {
                    topPanelHeight = value;
                }
                else { ; }
            }
        }

        /// <summary>
        /// TimelineTwitterListViewのName欄の幅
        /// </summary>
        private int timelineTwitterListViewNameColumnWidth = 60;

        /// <summary>
        /// TimelineTwitterListViewのName欄の幅を取得・設定する
        /// </summary>
        public int TimelineTwitterListViewNameColumnWidth
        {
            get { return timelineTwitterListViewNameColumnWidth; }
            set { timelineTwitterListViewNameColumnWidth = value; }
        }

        /// <summary>
        /// TimelineTwitterListViewのDowing欄の幅
        /// </summary>
        private int timelineTwitterListViewDoingColumnWidth = 120;

        /// <summary>
        /// TimelineTwitterListViewのDowing欄の幅を取得・設定する
        /// </summary>
        public int TimelineTwitterListViewDoingColumnWidth
        {
            get { return timelineTwitterListViewDoingColumnWidth; }
            set { timelineTwitterListViewDoingColumnWidth = value; }
        }

        /// <summary>
        /// TimelineTwitterListViewのDate欄の幅
        /// </summary>
        private int timelineTwitterListViewDateColumnWidth = 50;

        /// <summary>
        /// TimelineTwitterListViewのDate欄の幅を取得・設定する
        /// </summary>
        public int TimelineTwitterListViewDateColumnWidth
        {
            get { return timelineTwitterListViewDateColumnWidth; }
            set { timelineTwitterListViewDateColumnWidth = value; }
        }

        /// <summary>
        /// MessageTwitterListViewのName欄の幅
        /// </summary>
        private int messageTwitterListViewNameColumnWidth;

        /// <summary>
        /// MessageTwitterListViewのName欄の幅を取得・設定する
        /// </summary>
        public int MessageTwitterListViewNameColumnWidth
        {
            get { return messageTwitterListViewNameColumnWidth; }
            set { messageTwitterListViewNameColumnWidth = value; }
        }

        /// <summary>
        /// MessageTwitterListViewのMessage欄の幅
        /// </summary>
        private int messageTwitterListViewMessageColumnWidth;

        /// <summary>
        /// MessageTwitterListViewのMessage欄の幅を取得・設定する
        /// </summary>
        public int MessageTwitterListViewMessageColumnWidth
        {
            get { return messageTwitterListViewMessageColumnWidth; }
            set { messageTwitterListViewMessageColumnWidth = value; }
        }

        /// <summary>
        /// MessageTwitterListViewのDate欄の幅
        /// </summary>
        private int messageTwitterListViewDateColumnWidth;

        /// <summary>
        /// MessageTwitterListViewのDate欄の幅を取得・設定する
        /// </summary>
        public int MessageTwitterListViewDateColumnWidth
        {
            get { return messageTwitterListViewDateColumnWidth; }
            set { messageTwitterListViewDateColumnWidth = value; }
        }
    }
}
