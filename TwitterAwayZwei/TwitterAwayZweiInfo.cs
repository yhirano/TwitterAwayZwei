using System;

using System.Drawing;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using MiscPocketCompactLibrary2.Reflection;

namespace TwitterAwayZwei
{
    /// <summary>
    /// TwitterAway�̌ŗL�����L�q���Ă���N���X
    /// </summary>
    public static class TwitterAwayZweiInfo
    {
        #region �A�v���P�[�V�����̐ݒ�

        /// <summary>
        /// �^�C�����C���̎擾�Ԋu������擾����
        /// </summary>
        public static int UpdateTimulineIntervalMaximumSec
        {
            get { return 3600; }
        }

        /// <summary>
        /// �^�C�����C���̎擾�Ԋu�������擾����
        /// </summary>
        public static int UpdateTimulineIntervalMinimumSec
        {
            get { return 60; }
        }

        /// <summary>
        /// �_�C���N�g���b�Z�[�W�̎擾�Ԋu������擾����
        /// </summary>
        public static int UpdateDirectMessageIntervalMaximumSec
        {
            get { return 3600; }
        }

        /// <summary>
        /// �_�C���N�g���b�Z�[�W�̎擾�Ԋu�������擾����
        /// </summary>
        public static int UpdateDirectMessageIntervalMinimumSec
        {
            get { return 300; }
        }

        /// <summary>
        /// Web�ڑ����̃^�C���A�E�g���Ԃ��擾����
        /// </summary>
        public static int WebRequestTimeoutMillSec
        {
            get { return 20000; }
        }

        /// <summary>
        /// �l�b�g�A�N�Z�X����UserAgent�ݒ�
        /// </summary>
        private static string userAgent = null;

        /// <summary>
        /// �l�b�g�A�N�Z�X����UserAgent�ݒ���擾����
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
        /// Public Timeline��Twitter API URL���擾����
        /// </summary>
        public static string TwitterPublicTimelineXml
        {
            get { return "http://twitter.com/statuses/public_timeline.xml"; }
        }

        /// <summary>
        /// Friends Timeline��Twitter API URL���擾����
        /// </summary>
        public static string TwitterFriendsTimelineXml
        {
            get { return "http://twitter.com/statuses/friends_timeline.xml"; }
        }

        /// <summary>
        /// Direct Message��Twitter API URL���擾����
        /// </summary>
        public static string TwitterDirectMessageTimelineXml
        {
            get { return "http://twitter.com/direct_messages.xml"; }
        }

        /// <summary>
        /// Update��Twitter API URL���擾����
        /// </summary>
        public static string TwitterUpdateXml
        {
            get { return "http://twitter.com/statuses/update.xml"; }
        }

        /// <summary>
        /// �A�v���P�[�V�����̐ݒ�t�@�C���p�X���擾����
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
        /// ��O�ɏo�͂��郍�O�t�@�C�����擾����
        /// </summary>
        public static string ExceptionLogFile
        {
            get { return "TwitterAwayExceptionLog.log"; }
        }

        #endregion
    }
}
