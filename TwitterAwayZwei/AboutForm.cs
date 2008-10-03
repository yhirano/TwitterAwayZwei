using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OpenNETCF.Reflection;
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
            applicationNameLabel.Text = AssemblyUtility.GetTitle(Assembly2.GetEntryAssembly());
            versionNumberLabel.Text = AssemblyUtility.GetVersion(Assembly2.GetEntryAssembly()).ToString();
            copyrightLabel.Text = AssemblyUtility.GetCopyright(Assembly2.GetEntryAssembly());
        }
    }
}
