using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace VisualBinaryEditor
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void gitHubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo()
            {
                FileName = "https://github.com/Nil256/VisualBinaryEditor",
                UseShellExecute = true
            };
            Process.Start(info);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
