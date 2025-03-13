using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualBinaryEditor
{
    public partial class Main : Form
    {
        private readonly BinaryOrder order;
        private static ToolStripStatusLabel _debugLabelInstance;

        internal static void Debug(in string text)
        {
            if (_debugLabelInstance == null)
            {
                return;
            }
            _debugLabelInstance.Text = text;
        }

        public Main()
        {
            InitializeComponent();
            order = new BinaryOrder(binaryOrderPanel);
            _debugLabelInstance = debugLabel;
        }

        private void boolButton_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Bool);
        }

        private void byteButton_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Byte);
        }

        private void sbyteButton_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Sbyte);
        }

        private void shortButton_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Short);
        }

        private void ushortButton_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Ushort);
        }

        private void intButton_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Int);
        }

        private void uintButton_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Uint);
        }

        private void longButton_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Long);
        }

        private void ulongButton_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Ulong);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            order.Remove();
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            order.MoveUp();
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            order.MoveDown();
        }
    }
}
