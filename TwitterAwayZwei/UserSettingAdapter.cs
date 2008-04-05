using System;

using System.IO;
using System.Xml.Serialization;
using MiscPocketCompactLibrary2.Reflection;


namespace TwitterAwayZwei
{
    /// <summary>
    /// TwitterAwayの設定にアクセスするクラス
    /// </summary>
    public static class UserSettingAdapter
    {
        /// <summary>
        /// ユーザー設定
        /// </summary>
        private static UserSetting setting = new UserSetting();

        /// <summary>
        /// ユーザー設定を取得する
        /// </summary>
        public static UserSetting Setting
        {
            get { return UserSettingAdapter.setting; }
        }

        /// <summary>
        /// 設定を保存する
        /// </summary>
        public static void Save()
        {
            FileStream fs = null;
            try
            {
                if(Directory.Exists(Path.GetDirectoryName(TwitterAwayZweiInfo.SettingPath)) == false)
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(TwitterAwayZweiInfo.SettingPath));
                }
                fs = new FileStream(TwitterAwayZweiInfo.SettingPath, FileMode.Create, FileAccess.Write);
                XmlSerializer sr = new XmlSerializer(typeof(UserSetting));
                // シリアル化して書き込む
                sr.Serialize(fs, setting);
            }
            catch (InvalidOperationException) { ; }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        /// <summary>
        /// 設定を保存する
        /// </summary>
        public static void Load()
        {
            if (File.Exists(TwitterAwayZweiInfo.SettingPath) == true)
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(TwitterAwayZweiInfo.SettingPath, FileMode.Open, FileAccess.Read);
                    XmlSerializer sr = new XmlSerializer(typeof(UserSetting));
                    // シリアル化して書き込む
                    setting = sr.Deserialize(fs) as UserSetting;
                }
                catch (InvalidOperationException) { ; }
                catch (IOException) { ; }
                finally
                {
                    if (fs != null)
                    {
                        fs.Close();
                    }
                }
            }

            // 設定が空の場合は、ここまででエラーが起こっているため
            // 新たに設定のインスタンスを作成する
            if (setting == null)
            {
                setting = new UserSetting();
            }
        }
    }
}
