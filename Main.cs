using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace VisualBinaryEditor
{
    public partial class Main : Form
    {
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
            ProcessStartInfo info = new ProcessStartInfo()
            {
                FileName = "https://github.com/Nil256/VisualBinaryEditor/releases",
                UseShellExecute = true
            };
            Process.Start(info);
        }

        private void helpAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void helpHowToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string readMePath = Application.ExecutablePath;
            readMePath = Path.GetDirectoryName(readMePath);
            readMePath = Path.Combine(readMePath, "README.txt");
            if (!File.Exists(readMePath))
            {
                MessageBox.Show("えっ？\nもしかしてREADME.txt消しちゃった！？\nえぇ...参ったなぁ...", "README.txtが見つかりません。", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                DialogResult result = MessageBox.Show("仕方ないからGitHubで開くけどいい？", "README.txtが見つかりません。", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                ProcessStartInfo info2 = new ProcessStartInfo()
                {
                    FileName = "https://github.com/Nil256/VisualBinaryEditor/blob/main/README.txt",
                    UseShellExecute = true
                };
                Process.Start(info2);
                return;
            }
            ProcessStartInfo info = new ProcessStartInfo()
            {
                FileName = readMePath,
                UseShellExecute = true
            };
            Process.Start(info);
        }
    }
}
