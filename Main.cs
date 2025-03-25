using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using VisualBinaryEditor.Update;

namespace VisualBinaryEditor
{
    public partial class Main : Form
    {
        internal static readonly ReleasedVersion CurrentVersion = new ReleasedVersion("v0.1.3-alpha");

        public Main()
        {
            InitializeComponent();
            order = new BinaryOrder(binaryOrderPanel);
            editingFile = new EditingFile();
            editingFileNameToolStripStatusLabel.Text = "";
        }

        private void fileExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void helpCheckUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateChecker.CheckUpdate(CurrentVersion);
        }

        private void helpAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void helpHowToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string ONLINE_DOC = "https://nil256.github.io/VisualBinaryEditorDoc/";
            string executableRootPath = Path.GetDirectoryName(Application.ExecutablePath);
            string relativeDocPath = Path.Combine("Documentation", "index.html");
            string docPath = Path.Combine(executableRootPath, relativeDocPath);
            ProcessStartInfo info = new ProcessStartInfo()
            {
                FileName = docPath,
                UseShellExecute = true
            };
            if (!File.Exists(docPath))
            {
                info.FileName = ONLINE_DOC;
            }
            Process.Start(info);
        }

        private void helpLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo()
            {
                FileName = "https://github.com/Nil256/VisualBinaryEditor/blob/main/LICENSE",
                UseShellExecute = true
            };
            Process.Start(info);
        }
    }
}
