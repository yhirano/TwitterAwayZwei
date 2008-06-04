using System;

using System.Drawing;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using MiscPocketCompactLibrary2.Reflection;

namespace TwitterAwayZwei
{
    /// <summary>
    /// TwitterAwayの設定を保持するクラス
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
        /// チェックするリスト列挙
        /// </summary>
        public enum CheckLists
        {
            Friends, Public
        }

        /// <summary>
        /// チェックするリスト
        /// </summary>
        private CheckLists checkList = CheckLists.Friends;

        /// <summary>
        /// チェックするリストを取得・設定する
        /// </summary>
        public CheckLists CheckList
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
        /// プロキシの接続方法
        /// </summary>
        private Twitter.Twitter.ProxyConnects proxyUse = Twitter.Twitter.ProxyConnects.OsSetting;

        /// <summary>
        /// プロキシの接続方法を取得・設定する
        /// </summary>
        public Twitter.Twitter.ProxyConnects ProxyUse
        {
            get { return proxyUse; }
            set { proxyUse = value; }
        }

        /// <summary>
        /// プロキシのサーバ名
        /// </summary>
        private string proxyServer = string.Empty;

        /// <summary>
        /// プロキシのサーバ名を取得・設定する
        /// </summary>
        public string ProxyServer
        {
            get { return proxyServer; }
            set { proxyServer = value; }
        }

        /// <summary>
        /// プロキシのポート番号
        /// </summary>
        private int proxyPort = 0;

        /// <summary>
        /// プロキシのポート番号を取得・設定する
        /// </summary>
        public int ProxyPort
        {
            get
            {
                if (0x00 <= proxyPort && proxyPort <= 0xFFFF)
                {
                    return proxyPort;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if (0x00 <= value && value <= 0xFFFF)
                {
                    proxyPort = value;
                }
                else { ; }
            }
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
