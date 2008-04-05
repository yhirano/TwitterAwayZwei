using System;

namespace TwitterAwayZwei.Twitter
{
    internal class DirectMessageAddedEventArgs : EventArgs
    {
        /// <summary>
        /// 追加されたダイレクトメッセージ情報
        /// </summary>
        private DirectMessage message;

        /// <summary>
        /// 追加されたダイレクトメッセージを取得する
        /// </summary>
        public DirectMessage Message
        {
            get { return message; }
        }

        /// <summary>
        /// 追加されたダイレクトメッセージの番号。
        /// 追加されるはずのダイレクトメッセージを1から数え上げたもの。
        /// </summary>
        private int messageNo;

        /// <summary>
        /// ダイレクトメッセージの番号を取得する
        /// </summary>
        public int MessageNo
        {
            get { return messageNo; }
        }

        /// <summary>
        /// 追加されるはずのダイレクトメッセージの数
        /// </summary>
        private int allMessageCount;

        /// <summary>
        /// 追加されるはずのダイレクトメッセージの数を取得する
        /// </summary>
        public int AllMessageCount
        {
            get { return allMessageCount; }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="message">追加したダイレクトメッセージ</param>
        /// <param name="messageNo">追加されたダイレクトメッセージの番号を取得する</param>
        /// <param name="allMessageCount">追加されるはずのダイレクトメッセージの数</param>
        public DirectMessageAddedEventArgs(DirectMessage message, int messageNo, int allMessageCount)
        {
            this.message = message;
            this.messageNo = messageNo;
            this.allMessageCount = allMessageCount;
        }
    }
}
