using System;
using System.Text.RegularExpressions;
using System.IO;

using System.Reflection;
using MiscPocketCompactLibrary2.Reflection;

namespace TwitterAwayZwei
{
    /// <summary>
    /// TwitterAway::Zwei�̌ŗL�����L�q���Ă���N���X
    /// </summary>
    internal static class TwitterAwayZweiInfo
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
        /// Timeline/Messages���X�g�̃f�t�H���g�t�H���g�T�C�Y
        /// </summary>
        public static int TimelineListDefaultFontSize
        {
            get { return 9; }
        }

        /// <summary>
        /// �A�v���P�[�V�����̐ݒ�t�@�C���p�X���擾����
        /// </summary>
        public static string SettingPath
        {
            get
            {
                string title = Regex.Replace(AssemblyUtility.GetTitle(Assembly.GetExecutingAssembly()), "[\\\\/:,;*?\"<>|]", "_");
                return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\" + title + @"\Setting.xml";
            }
        }

        /// <summary>
        /// ��O�ɏo�͂��郍�O�t�@�C�����擾����
        /// </summary>
        public static string ExceptionLogFilePath
        {
            get
            {
                return Path.GetDirectoryName(AssemblyUtility.GetLocation(Assembly.GetExecutingAssembly()))
                  + @"\" + "TwitterAwayZweiExceptionLog.log";
            }
        }

        #endregion
    }
}
