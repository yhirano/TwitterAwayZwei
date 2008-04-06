using System;

using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Xml;
using System.Text;
using System.Windows.Forms;
using MiscPocketCompactLibrary2.Reflection;

namespace TwitterAwayZwei.Twitter
{
    internal delegate void StatusAddedEventHandler(object sender, StatusAddedEventArgs e);

    internal delegate void DirectMessageAddedEventHandler(object sender, DirectMessageAddedEventArgs e);

    /// <summary>
    /// Twitterクラス
    /// </summary>
    public class Twitter
    {
        /// <summary>
        /// ユーザー名
        /// </summary>
        private string userName;

        /// <summary>
        /// ユーザー名を設定する
        /// </summary>
        public string UserName
        {
            set { userName = value; }
        }

        /// <summary>
        /// パスワード
        /// </summary>
        private string password;

        /// <summary>
        /// パスワードを設定する
        /// </summary>
        public string Password
        {
            set { password = value; }
        }

        /// <summary>
        /// プロフィールイメージのイメージリスト（小）
        /// </summary>
        private ImageList profileSmallImageList = new ImageList();

        /// <summary>
        /// プロフィールイメージのイメージリスト（小）を取得する
        /// </summary>
        public ImageList ProfileSmallImageList
        {
            get { return profileSmallImageList; }
        }

        /// <summary>
        /// プロフィールイメージのイメージリスト（大）
        /// </summary>
        private ImageList profileLargeImageList = new ImageList();

        /// <summary>
        /// プロフィールイメージのイメージリスト（大）を取得する
        /// </summary>
        public ImageList ProfileLargeImageList
        {
            get { return profileLargeImageList; }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="userName">ユーザ名</param>
        /// <param name="password">パスワード</param>
        public Twitter(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
            profileSmallImageList.ImageSize = new Size(16, 16);
            profileLargeImageList.ImageSize = new Size(44, 44);
        }

        /// <summary>
        /// タイムライン取得中のロック
        /// </summary>
        private object timelineFetchLock = new object();

        /// <summary>
        /// PublicTimelineのステータス情報を取得する
        /// </summary>
        public StatusInfomation[] PublicTimeline
        {
            get
            {
                lock (timelineFetchLock)
                {
                    Stream st = null;
                    StatusInfomation[] statuses;

                    try
                    {
                        st = GetWebStream(new Uri(TwitterAwayZweiInfo.TwitterPublicTimelineXml));
                        statuses = PaeseStatuses(st);
                        FetchPofileImages(statuses);
                    }
                    finally
                    {
                        if (st != null)
                        {
                            st.Close();
                        }
                    }

                    return statuses;
                }
            }
        }

        /// <summary>
        /// FriendTimelineのステータス情報を取得する
        /// </summary>
        public StatusInfomation[] FriendTimeline
        {
            get
            {
                lock (timelineFetchLock)
                {
                    Stream st = null;
                    StatusInfomation[] statuses;

                    try
                    {
                        st = GetWebStream(new Uri(TwitterAwayZweiInfo.TwitterFriendsTimelineXml), userName, password);
                        statuses = PaeseStatuses(st);
                        FetchPofileImages(statuses);
                    }
                    finally
                    {
                        if (st != null)
                        {
                            st.Close();
                        }
                    }

                    return statuses;
                }
            }
        }

        /// <summary>
        /// ダイレクトメッセージ取得中のロック
        /// </summary>
        private object directMessageFetchLock = new object();

        /// <summary>
        /// PublicTimelineのステータス情報を取得する
        /// </summary>
        public DirectMessage[] DirectMessage
        {
            get
            {
                lock (directMessageFetchLock)
                {
                    Stream st = null;
                    DirectMessage[] message;

                    try
                    {
                        st = GetWebStream(new Uri(TwitterAwayZweiInfo.TwitterDirectMessageTimelineXml), userName, password);
                        message = PaeseDirectMessage(st);
                    }
                    finally
                    {
                        if (st != null)
                        {
                            st.Close();
                        }
                    }

                    return message;
                }
            }
        }

        /// <summary>
        /// プロフィールイメージのURLとインデックスの値のハッシュ
        /// </summary>
        private Dictionary<Uri, int> profileIndexDictionary = new Dictionary<Uri, int>();

        public int GetProfileImageIndex(Uri profileImageUrl)
        {
            // すでにハッシュにURLのキーがある場合（profileImageListに既にイメージがある場合）
            if (profileIndexDictionary.ContainsKey(profileImageUrl) == true)
            {
                return (int)profileIndexDictionary[profileImageUrl];
            }
            // ハッシュににURLのキーがない場合
            else
            {
                return -1;
            }
        }

        public Image GetProfileLargeImage(Uri profileImageUrl)
        {
            // すでにハッシュにURLのキーがある場合（profileImageListに既にイメージがある場合）
            if (profileIndexDictionary.ContainsKey(profileImageUrl) == true)
            {
                int index = GetProfileImageIndex(profileImageUrl);
                if (index != -1 && index < profileLargeImageList.Images.Count)
                {
                    return profileLargeImageList.Images[index];
                }
                else
                {
                    return null;
                }
            }
            // ハッシュににURLのキーがない場合
            else
            {
                return null;
            }
        }

        /// <summary>
        /// ステータス情報XMLをステータス情報にパージングする
        /// </summary>
        /// <param name="stream">ステータス情報XMLを格納したStream</param>
        /// <returns>ステータス情報</returns>
        private StatusInfomation[] PaeseStatuses(Stream stream)
        {
            List<StatusInfomation> statusList = new List<StatusInfomation>();

            try
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(stream);
                XmlNodeList statusNodes = xdoc.GetElementsByTagName("status");
                int statusCount = 0;
                foreach (XmlNode statusNode in statusNodes)
                {
                    // ステータス
                    StatusInfomation status = new StatusInfomation();

                    foreach (XmlNode inStatusNode in statusNode.ChildNodes)
                    {
                        switch (inStatusNode.Name)
                        {
                            case "created_at":
                                status.SetCreatedAt(inStatusNode.InnerText);
                                break;
                            case "id":
                                status.Id = inStatusNode.InnerText;
                                break;
                            case "text":
                                status.Text = inStatusNode.InnerText;
                                break;
                            case "user":
                                {
                                    // ユーザー情報
                                    UserInfomation user = new UserInfomation();

                                    foreach (XmlNode userNode in inStatusNode.ChildNodes)
                                    {
                                        switch (userNode.Name)
                                        {
                                            case "id":
                                                user.Id = userNode.InnerText;
                                                break;
                                            case "name":
                                                user.Name = userNode.InnerText;
                                                break;
                                            case "screen_name":
                                                user.ScreenName = userNode.InnerText;
                                                break;
                                            case "location":
                                                user.Location = userNode.InnerText;
                                                break;
                                            case "description":
                                                user.Description = userNode.InnerText;
                                                break;
                                            case "profile_image_url":
                                                try
                                                {
                                                    user.ProfileImageUrl = new Uri(userNode.InnerText);
                                                }
                                                catch (UriFormatException) { ; }
                                                break;
                                            case "url":
                                                try
                                                {
                                                    user.Url = new Uri(userNode.InnerText);
                                                }
                                                catch (UriFormatException) { ; }
                                                break;
                                            case "protected":
                                                if (userNode.InnerText == Boolean.TrueString)
                                                {
                                                    user.ProtectedMyUpdate = true;
                                                }
                                                else
                                                {
                                                    user.ProtectedMyUpdate = false;
                                                }
                                                break;
                                        }
                                    } // foreach (XmlNode userNode in inStatusNode.ChildNodes)

                                    status.User = user;
                                }
                                break;
                        }
                    } // foreach (XmlNode inStatusNode in statusNode.ChildNodes)

                    statusList.Add(status);
                    OnStatusAdded(status, ++statusCount, statusNodes.Count);
                }
            }
            catch (WebException) { throw; }
            catch (OutOfMemoryException) { throw; }
            catch (IOException) { throw; }
            catch (UriFormatException) { throw; }
            catch (SocketException) { throw; }
            catch (XmlException) { throw; }

            return statusList.ToArray();
        }

        ///// <summary>
        ///// ステータス情報XMLをステータス情報にパージングする
        ///// </summary>
        ///// <param name="stream">ステータス情報XMLを格納したStream</param>
        ///// <returns>ステータス情報</returns>
        //private StatusInfomation[] PaeseStatuses(Stream stream)
        //{
        //    XmlReader reader = null;

        //    // ステータスのリスト
        //    List<StatusInfomation> statuses = new List<StatusInfomation>();

        //    try
        //    {
        //        reader = XmlTextReader.Create(stream);

        //        // ステータス
        //        StatusInfomation status = null;
        //        // ユーザー
        //        UserInfomation user = null;
        //        // userタグの中にいるか
        //        bool inUserFlag = false;

        //        while (reader.Read())
        //        {
        //            if (reader.NodeType == XmlNodeType.Element)
        //            {
        //                if (reader.LocalName == "status")
        //                {
        //                    status = new StatusInfomation();
        //                } // End of status
        //                else if (reader.LocalName == "created_at")
        //                {
        //                    status.SetCreatedAt(reader.ReadString());
        //                } // End of created_at
        //                else if (reader.LocalName == "id")
        //                {
        //                    status.Id = reader.ReadString();
        //                } // End of id
        //                else if (reader.LocalName == "text")
        //                {
        //                    status.Text = reader.ReadString();
        //                } // End of text
        //                else if (reader.LocalName == "user")
        //                {
        //                    inUserFlag = true;
        //                    user = new UserInfomation();
        //                    status.User = user;

        //                } // End of user
        //                else if (inUserFlag == true)
        //                {
        //                    if (reader.LocalName == "id")
        //                    {
        //                        user.Id = reader.ReadString();
        //                    } // End of id
        //                    else if (reader.LocalName == "name")
        //                    {
        //                        user.Name = reader.ReadString();
        //                    } // End of name
        //                    else if (reader.LocalName == "screen_name")
        //                    {
        //                        user.ScreenName = reader.ReadString();
        //                    } // End of screen_name
        //                    else if (reader.LocalName == "location")
        //                    {
        //                        user.Location = reader.ReadString();
        //                    } // End of location
        //                    else if (reader.LocalName == "description")
        //                    {
        //                        user.Description = reader.ReadString();
        //                    } // End of description
        //                    else if (reader.LocalName == "profile_image_url")
        //                    {
        //                        try
        //                        {
        //                            user.ProfileImageUrl = new Uri(reader.ReadString());
        //                        }
        //                        catch (UriFormatException)
        //                        {
        //                            ;
        //                        }
        //                    } // End of profile_image_url
        //                    else if (reader.LocalName == "url")
        //                    {
        //                        try
        //                        {
        //                            user.Url = new Uri(reader.ReadString());
        //                        }
        //                        catch (UriFormatException)
        //                        {
        //                            ;
        //                        }
        //                    } // End of url
        //                    else if (reader.LocalName == "protected")
        //                    {
        //                        if (reader.ReadString() == Boolean.TrueString)
        //                        {
        //                            user.ProtectedMyUpdate = true;
        //                        }
        //                        else
        //                        {
        //                            user.ProtectedMyUpdate = false;
        //                        }
        //                    } // End of protected
        //                } // End of userタグの中にいるか
        //            }
        //            else if (reader.NodeType == XmlNodeType.EndElement)
        //            {
        //                if (reader.LocalName == "status")
        //                {
        //                    statuses.Add(status);
        //                    OnStatusAdded(status, statuses.Count, 20);
        //                }
        //                else if (reader.LocalName == "user")
        //                {
        //                    inUserFlag = false;
        //                }
        //            }
        //        }
        //    }
        //    catch (WebException)
        //    {
        //        throw;
        //    }
        //    catch (OutOfMemoryException)
        //    {
        //        throw;
        //    }
        //    catch (IOException)
        //    {
        //        throw;
        //    }
        //    catch (UriFormatException)
        //    {
        //        throw;
        //    }
        //    catch (SocketException)
        //    {
        //        throw;
        //    }
        //    catch (XmlException)
        //    {
        //        throw;
        //    }
        //    catch (ArgumentException)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        if (reader != null)
        //        {
        //            reader.Close();
        //        }
        //    }

        //    return statuses.ToArray();
        //}

        /// <summary>
        /// プロフィールイメージを取得する
        /// </summary>
        /// <param name="statuses">Status情報</param>
        private void FetchPofileImages(StatusInfomation[] statuses)
        {
            foreach (StatusInfomation status in statuses)
            {
                FetchPofileImage(status.User.ProfileImageUrl);
            }
        }

        /// <summary>
        /// プロフィールイメージを取得する
        /// </summary>
        private void FetchPofileImage(Uri profileImageUrl)
        {
            // プロフィールイメージが取得済みの場合は何もしない
            if (profileIndexDictionary.ContainsKey(profileImageUrl) == true)
            {
                return;
            }

            // イメージを取得する
            Stream st = null;
            try
            {
                st = GetWebStream(profileImageUrl);

                if (st != null)
                {
                    Image image = new Bitmap(st);
                    if (image != null)
                    {
                        profileSmallImageList.Images.Add(image);
                        profileLargeImageList.Images.Add(image);
                        profileIndexDictionary[profileImageUrl] = profileSmallImageList.Images.Count - 1;
                    }
                }
                else
                {
                    profileIndexDictionary[profileImageUrl] = -1;
                }
            }
            finally
            {
                if (st != null)
                {
                    st.Close();
                }
            }
        }

        /// <summary>
        /// ダイレクトメッセージXMLをステータス情報にパージングする
        /// </summary>
        /// <param name="stream">ダイレクトメッセージXMLを格納したStream</param>
        /// <returns>ダイレクトメッセージ</returns>
        private DirectMessage[] PaeseDirectMessage(Stream stream)
        {
            List<DirectMessage> messageList = new List<DirectMessage>();

            try
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(stream);
                XmlNodeList directMessageNodes = xdoc.GetElementsByTagName("direct_message");
                int messageCount = 0;
                foreach (XmlNode directMessageNode in directMessageNodes)
                {
                    // メッセージ
                    DirectMessage message = new DirectMessage();

                    foreach (XmlNode inDirectMessageNode in directMessageNode.ChildNodes)
                    {
                        switch (inDirectMessageNode.Name)
                        {
                            case "created_at":
                                message.SetCreatedAt(inDirectMessageNode.InnerText);
                                break;
                            case "id":
                                message.Id = inDirectMessageNode.InnerText;
                                break;
                            case "text":
                                message.Text = inDirectMessageNode.InnerText;
                                break;
                            case "sender_id":
                                message.SenderId = inDirectMessageNode.InnerText;
                                break;
                            case "recipient_id":
                                message.RecipientId = inDirectMessageNode.InnerText;
                                break;
                            case "sender_screen_name":
                                message.SenderScreenName = inDirectMessageNode.InnerText;
                                break;
                            case "recipient_screen_name":
                                message.RecipientrScreenName = inDirectMessageNode.InnerText;
                                break;
                        }
                    } // foreach (XmlNode inStatusNode in statusNode.ChildNodes)

                    messageList.Add(message);
                    OnDirectMessageAdded(message, ++messageCount, directMessageNodes.Count);
                }
            }
            catch (WebException) { throw; }
            catch (OutOfMemoryException) { throw; }
            catch (IOException) { throw; }
            catch (UriFormatException) { throw; }
            catch (SocketException) { throw; }
            catch (XmlException) { throw; }

            return messageList.ToArray();
        }

        /// <summary>
        /// Update中のロック
        /// </summary>
        private object updateFetchLock = new object();

        /// <summary>
        /// メッセージをUpdateする
        /// </summary>
        /// <param name="message">メッセージ</param>
        public void Update(string message)
        {
            lock (updateFetchLock)
            {
                string sendMessage = string.Empty;

                // 送信メッセージをUTF-8化してバイト列に入れる
                byte[] messageBytes = Encoding.Convert(Encoding.Unicode, Encoding.UTF8, Encoding.Unicode.GetBytes(message));

                // URLエンコード
                foreach (byte b in messageBytes)
                {
                    sendMessage += "%" + b.ToString("X2");
                }

                Stream st = null;

                try
                {
                    string send = TwitterAwayZweiInfo.TwitterUpdateXml + "?status=" + sendMessage;
                    st = GetWebStream(new Uri(send), "POST", userName, password);
                }
                catch (WebException)
                {
                    throw;
                }
                catch (UriFormatException)
                {
                    throw;
                }
                finally
                {
                    if (st != null)
                    {
                        st.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Webサイトの情報をStreamで返す
        /// </summary>
        /// <param name="url">URL</param>
        /// <returns>Webサイトの情報のStream</returns>
        private static Stream GetWebStream(Uri url)
        {
            return GetWebStream(url, string.Empty, string.Empty, string.Empty);
        }

        /// <summary>
        /// Webサイトの情報をStreamで返す
        /// </summary>
        /// <param name="url">URL</param>
        /// <param name="requestMethod">HTTPリクエストメソッド</param>
        /// <returns>Webサイトの情報のStream</returns>
        private static Stream GetWebStream(Uri url, string requestMethod)
        {
            return GetWebStream(url, requestMethod, string.Empty, string.Empty);
        }

        /// <summary>
        /// Webサイトの情報をStreamで返す
        /// </summary>
        /// <param name="url">URL</param>
        /// <param name="userName">Web認証のユーザー名</param>
        /// <param name="password">Web認証のパスワード</param>
        /// <returns>Webサイトの情報のStream</returns>
        private static Stream GetWebStream(Uri url, string userName, string password)
        {
            return GetWebStream(url, string.Empty, userName, password);
        }

        /// <summary>
        /// Webサイトの情報をStreamで返す
        /// </summary>
        /// <param name="url">URL</param>
        /// <param name="requestMethod">HTTPリクエストメソッド</param>
        /// <param name="userName">Web認証のユーザー名</param>
        /// <param name="password">Web認証のパスワード</param>
        /// <returns>Webサイトの情報のStream</returns>
        private static Stream GetWebStream(Uri url, string requestMethod, string userName, string password)
        {
            HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create(url);
            webReq.AllowWriteStreamBuffering = true;
            if (userName != null && userName != string.Empty)
            {
                webReq.Credentials = new NetworkCredential(userName, password);
            }

            if (requestMethod != null && requestMethod != string.Empty)
            {
                webReq.Method = requestMethod;
            }

            switch (UserSettingAdapter.Setting.ProxyUse)
            {
                case UserSetting.ProxyConnects.Unuse:
                    WebProxy proxy = new WebProxy();
                    proxy.Address = null;
                    webReq.Proxy = proxy;
                    break;
                case UserSetting.ProxyConnects.OriginalSetting:
                    webReq.Proxy = new WebProxy(UserSettingAdapter.Setting.ProxyServer, UserSettingAdapter.Setting.ProxyPort);
                    break;
                case UserSetting.ProxyConnects.OsSetting:
                default:
                    break;

            }
            webReq.Timeout = TwitterAwayZweiInfo.WebRequestTimeoutMillSec;
            webReq.UserAgent = TwitterAwayZweiInfo.UserAgent;
            webReq.Headers.Add("X-Twitter-Client", AssemblyUtility.Title);
            webReq.Headers.Add("X-Twitter-Client-Version", AssemblyUtility.Version.ToString());

            return webReq.GetResponse().GetResponseStream();
        }

        internal event StatusAddedEventHandler StatusAdded;

        private void OnStatusAdded(StatusInfomation addedStatus, int statusNo, int allStatusCount)
        {
            if (StatusAdded != null)
            {
                StatusAdded(this, new StatusAddedEventArgs(addedStatus, statusNo, allStatusCount));
            }
        }

        internal event DirectMessageAddedEventHandler DirectMessageAdded;

        private void OnDirectMessageAdded(DirectMessage message, int messageNo, int allMessageCount)
        {
            if (DirectMessageAdded != null)
            {
                DirectMessageAdded(this, new DirectMessageAddedEventArgs(message, messageNo, allMessageCount));
            }
        }
    }
}
