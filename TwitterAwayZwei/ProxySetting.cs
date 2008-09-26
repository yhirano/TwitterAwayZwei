using System;

using System.Xml.Serialization;

namespace TwitterAwayZwei
{
    /// <summary>
    /// プロキシの設定クラス
    /// </summary>
    [Serializable()]
    public class ProxySetting
    {
        /// <summary>
        /// プロキシの接続方法列挙
        /// </summary>
        public enum ProxyConnects
        {
            NoUse, AutoDetect, Manual
        }

        /// <summary>
        /// プロキシの接続方法
        /// </summary>
        private ProxyConnects proxyUse = ProxyConnects.AutoDetect;

        /// <summary>
        /// プロキシの接続方法を取得・設定する
        /// </summary>
        public ProxyConnects ProxyUse
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
        /// コンストラクタ
        /// </summary>
        public ProxySetting()
        { }
    }
}
