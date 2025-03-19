using System;
using System.Windows.Forms;

namespace VisualBinaryEditor.Update.Result
{
    public partial class NoUpdateDialog : Form
    {
        public NoUpdateDialog()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
