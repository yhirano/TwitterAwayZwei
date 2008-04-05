using System;

using System.Drawing;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using MiscPocketCompactLibrary2.Reflection;

namespace TwitterAwayZwei
{
    /// <summary>
    /// TwitterAwayの固有情報を記述しているクラス
    /// </summary>
    public static class TwitterAwayZweiInfo
    {
        #region アプリケーションの設定

        /// <summary>
        /// タイムラインの取得間隔上限を取得する
        /// </summary>
        public static int UpdateTimulineIntervalMaximumSec
        {
            get { return 3600; }
        }

        /// <summary>
        /// タイムラインの取得間隔下限を取得する
        /// </summary>
        public static int UpdateTimulineIntervalMinimumSec
        {
            get { return 60; }
        }

        /// <summary>
        /// ダイレクトメッセージの取得間隔上限を取得する
        /// </summary>
        public static int UpdateDirectMessageIntervalMaximumSec
        {
            get { return 3600; }
        }

        /// <summary>
        /// ダイレクトメッセージの取得間隔下限を取得する
        /// </summary>
        public static int UpdateDirectMessageIntervalMinimumSec
        {
            get { return 300; }
        }

        /// <summary>
        /// Web接続時のタイムアウト時間を取得する
        /// </summary>
        public static int WebRequestTimeoutMillSec
        {
            get { return 20000; }
        }

        /// <summary>
        /// ネットアクセス時のUserAgent設定
        /// </summary>
        private static string userAgent = null;

        /// <summary>
        /// ネットアクセス時のUserAgent設定を取得する
        /// </summary>
        public static string UserAgent
        {
            get
            {
                if (userAgent == null)
                {
                    userAgent = AssemblyUtility.Title + "/" + AssemblyUtility.Version.ToString();
                }
                return userAgent;
            }
        }

        /// <summary>
        /// Public TimelineのTwitter API URLを取得する
        /// </summary>
        public static string TwitterPublicTimelineXml
        {
            get { return "http://twitter.com/statuses/public_timeline.xml"; }
        }

        /// <summary>
        /// Friends TimelineのTwitter API URLを取得する
        /// </summary>
        public static string TwitterFriendsTimelineXml
        {
            get { return "http://twitter.com/statuses/friends_timeline.xml"; }
        }

        /// <summary>
        /// Direct MessageのTwitter API URLを取得する
        /// </summary>
        public static string TwitterDirectMessageTimelineXml
        {
            get { return "http://twitter.com/direct_messages.xml"; }
        }

        /// <summary>
        /// UpdateのTwitter API URLを取得する
        /// </summary>
        public static string TwitterUpdateXml
        {
            get { return "http://twitter.com/statuses/update.xml"; }
        }

        /// <summary>
        /// アプリケーションの設定ファイルパスを取得する
        /// </summary>
        public static string SettingPath
        {
            get
            {
                string title = Regex.Replace(AssemblyUtility.Title, "[\\\\/:,;*?\"<>|]", "_");
                string version = Regex.Replace(AssemblyUtility.Version.ToString(), "[\\\\/:,;*?\"<>|]", "_");
                return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\" + title + @"\Setting.xml";
            }
        }

        /// <summary>
        /// 例外に出力するログファイルを取得する
        /// </summary>
        public static string ExceptionLogFile
        {
            get { return "TwitterAwayExceptionLog.log"; }
        }

        #endregion
    }
}
