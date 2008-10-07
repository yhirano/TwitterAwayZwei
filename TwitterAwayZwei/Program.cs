﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Windows.Forms;
using MiscPocketCompactLibrary2.Diagnostics;
using MiscPocketCompactLibrary2.Reflection;

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
            try
            {
                // 設定を読み込む
                UserSettingAdapter.Load();

                Application.Run(new MainForm());

                // 設定を保存する
                UserSettingAdapter.Save();
            }
            catch (Exception ex)
            {
                #region 例外ログを書き出す

                Log exceptionLog = new Log(TwitterAwayZweiInfo.ExceptionLogFilePath);
                StringBuilder error = new StringBuilder();

                Assembly entryAsm = OpenNETCF.Reflection.Assembly2.GetEntryAssembly();
                error.Append("Application:        " +
                    AssemblyUtility.GetTitle(entryAsm) + " " + AssemblyUtility.GetVersion(entryAsm).ToString() + "\r\n");
                error.Append("Date:               " + System.DateTime.Now.ToString("G") + "\r\n");
                error.Append("OS:                 " + Environment.OSVersion.ToString() + "\r\n");
                error.Append("Culture:            " + System.Globalization.CultureInfo.CurrentCulture.Name + "\r\n");
                error.Append("Exception class:    " + ex.GetType().ToString() + "\r\n");
                error.Append("Exception ToString: " + ex.ToString() + "\r\n");
                error.Append("Exception message:  " + "\r\n");
                error.Append(ex.Message);
                error.Append("Exception stack     : " + "\r\n");
                error.Append(ex.StackTrace);

                error.Append("\r\n");
                error.Append("\r\n");

                exceptionLog.LogThis(error.ToString(), Log.LogPrefix.date);

                #endregion // 例外ログを書き出す

                // 例外の再送
                throw ex;
            }
        }
    }
}