using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MiscPocketCompactLibrary2.Reflection;

namespace TwitterAwayZwei
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            applicationNameLabel.Text = AssemblyUtility.Title;
            versionNumberLabel.Text = AssemblyUtility.Version.ToString();
            copyrightLabel.Text = AssemblyUtility.Copyright;
        }
    }
}
