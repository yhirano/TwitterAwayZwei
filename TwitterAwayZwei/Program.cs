using System;

using System.Collections.Generic;
using System.Windows.Forms;

namespace TwitterAwayZwei
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [MTAThread]
        static void Main()
        {
            // 設定を読み込む
            UserSettingAdapter.Load();

            Application.Run(new MainForm());

            // 設定を保存する
            UserSettingAdapter.Save();
        }
    }
}