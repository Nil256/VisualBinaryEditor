using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void helpAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }
    }
}
