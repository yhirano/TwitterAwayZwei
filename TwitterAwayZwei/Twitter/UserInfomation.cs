using System;

namespace TwitterAwayZwei.Twitter
{
    /// <summary>
    /// Twitterのユーザー情報
    /// </summary>
    public class UserInfomation
    {
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
        /// 名前
        /// </summary>
        private string name;

        /// <summary>
        /// 名前を取得・設定する
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// スクリーン名
        /// </summary>
        private string screenName;

        /// <summary>
        /// スクリーン名を取得・設定する
        /// </summary>
        public string ScreenName
        {
            get { return screenName; }
            set { screenName = value; }
        }

        /// <summary>
        /// ロケーション
        /// </summary>
        private string location;

        /// <summary>
        /// ロケーションを取得・設定する
        /// </summary>
        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        /// <summary>
        /// 詳細
        /// </summary>
        private string description;

        /// <summary>
        /// 詳細を取得・設定する
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        /// <summary>
        /// プロフィールイメージのURL
        /// </summary>
        private Uri profileImageUrl;

        /// <summary>
        /// プロフィールイメージのURLを取得・設定する
        /// </summary>
        public Uri ProfileImageUrl
        {
            get { return profileImageUrl; }
            set { profileImageUrl = value; }
        }

        /// <summary>
        /// ユーザーサイトのURL
        /// </summary>
        private Uri url;

        /// <summary>
        /// ユーザーサイトのURLを取得・設定する
        /// </summary>
        public Uri Url
        {
            get { return url; }
            set { url = value; }
        }

        /// <summary>
        /// Protectの有無
        /// </summary>
        private bool protectedMyUpdate;

        /// <summary>
        /// Protectの有無を取得・設定する
        /// </summary>
        public bool ProtectedMyUpdate
        {
            get { return protectedMyUpdate; }
            set { protectedMyUpdate = value; }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public UserInfomation()
        {
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="name">名前</param>
        /// <param name="screenName">スクリーン名</param>
        /// <param name="location">ロケーション</param>
        /// <param name="description">詳細</param>
        /// <param name="profileImageUrl">プロフィールイメージURL</param>
        /// <param name="url">ユーザーサイトURL</param>
        /// <param name="protectedMyUpdate">Protectの有無</param>
        public UserInfomation(string id, string name, string screenName, string location, string description, Uri profileImageUrl, Uri url, bool protectedMyUpdate)
        {
            this.id = id;
            this.name = name;
            this.screenName = screenName;
            this.location = location;
            this.description = description;
            this.profileImageUrl = profileImageUrl;
            this.url = url;
            this.protectedMyUpdate = protectedMyUpdate;
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="name">名前</param>
        /// <param name="screenName">スクリーン名</param>
        /// <param name="location">ロケーション</param>
        /// <param name="description">詳細</param>
        /// <param name="profileImageUrl">プロフィールイメージURL</param>
        /// <param name="url">ユーザーサイトURL</param>
        /// <param name="protectedMyUpdate">Protectの有無</param>
        public UserInfomation(string id, string name, string screenName, string location, string description, string profileImageUrl, string url, bool protectedMyUpdate)
        {
            this.id = id;
            this.name = name;
            this.screenName = screenName;
            this.location = location;
            this.description = description;
            try
            {
                this.profileImageUrl = new Uri(profileImageUrl);
            }
            catch (UriFormatException) { ; }
            try
            {
                this.url = new Uri(url);
            }
            catch (UriFormatException) { ; }
            this.protectedMyUpdate = protectedMyUpdate;
        }
    }
}
