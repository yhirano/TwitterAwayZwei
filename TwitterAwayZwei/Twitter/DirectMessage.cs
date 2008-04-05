using System;

namespace TwitterAwayZwei.Twitter
{
    /// <summary>
    /// Twitterのダイレクトメッセージ情報
    /// </summary>
    public class DirectMessage
    {
        /// <summary>
        /// ダイレクトメッセージ送信された時刻
        /// </summary>
        private DateTime createdAt;

        /// <summary>
        /// ダイレクトメッセージ送信された時刻を取得・設定する
        /// </summary>
        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }

        /// <summary>
        /// ID
        /// </summary>
        private string id;

        /// <summary>
        /// IDを取得・設定する
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// テキスト
        /// </summary>
        private string text;

        /// <summary>
        /// テキストを取得・設定する
        /// </summary>
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        /// <summary>
        /// 送信者ID
        /// </summary>
        private string senderId;

        /// <summary>
        /// 送信者IDを取得・設定する
        /// </summary>
        public string SenderId
        {
            get { return senderId; }
            set { senderId = value; }
        }

        /// <summary>
        /// 受信者ID
        /// </summary>
        private string recipientId;

        /// <summary>
        /// 受信者IDを取得・設定する
        /// </summary>
        public string RecipientId
        {
            get { return recipientId; }
            set { recipientId = value; }
        }

        /// <summary>
        /// 送信者スクリーン名
        /// </summary>
        private string senderScreenName;

        /// <summary>
        /// 送信者スクリーン名を取得・設定する
        /// </summary>
        public string SenderScreenName
        {
            get { return senderScreenName; }
            set { senderScreenName = value; }
        }

        /// <summary>
        /// 受信者スクリーン名
        /// </summary>
        private string recipientrScreenName;

        /// <summary>
        /// 受信者スクリーン名を取得・設定する
        /// </summary>
        public string RecipientrScreenName
        {
            get { return recipientrScreenName; }
            set { recipientrScreenName = value; }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DirectMessage()
        {
        }

        /// <summary>
        /// ステータス情報が作成された時刻をセットする
        /// </summary>
        /// <param name="date">ステータス情報が作成された時刻</param>
        public void SetCreatedAt(string date)
        {
            try
            {
                createdAt = DateTime.ParseExact(date, "ddd MMM d HH':'mm':'ss zzz yyyy",
                    System.Globalization.DateTimeFormatInfo.InvariantInfo,
                    System.Globalization.DateTimeStyles.None);
            }
            catch (FormatException ex)
            {
                throw ex;
            }
        }
    }
}
