using System;

namespace TwitterAwayZwei.Twitter
{
    internal class StatusAddedEventArgs : EventArgs
    {
        /// <summary>
        /// 追加されたステータス情報
        /// </summary>
        private StatusInfomation status;

        /// <summary>
        /// 追加されたステータス情報を取得する
        /// </summary>
        public StatusInfomation Status
        {
            get { return status; }
        }

        /// <summary>
        /// 追加されたステータス情報の番号。
        /// 追加されるはずのステータス情報を1から数え上げたもの。
        /// </summary>
        private int statusNo;

        /// <summary>
        /// 追加されたステータス情報の番号を取得する
        /// </summary>
        public int StatusNo
        {
            get { return statusNo; }
        }

        /// <summary>
        /// 追加されるはずのステータス情報の数
        /// </summary>
        private int allStatusCount;

        /// <summary>
        /// 追加されるはずのステータス情報の数を取得する
        /// </summary>
        public int AllStatusCount
        {
            get { return allStatusCount; }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="status">追加したステータス情報</param>
        /// <param name="statusNo">追加されたステータス情報の番号を取得する</param>
        /// <param name="allStatusCount">追加されるはずのステータス情報の数</param>
        public StatusAddedEventArgs(StatusInfomation status, int statusNo, int allStatusCount)
        {
            this.status = status;
            this.statusNo = statusNo;
            this.allStatusCount = allStatusCount;
        }
    }
}
