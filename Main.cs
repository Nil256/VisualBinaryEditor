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
    }
}
