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

        private void fileNewSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!order.CanExportBinary())
            {
                MessageBox.Show("バイナリファイルに出力するには、\nバイナリエントリが最低でも1つ必要です。", "保存するデータがありません", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult result = binaryFileSaveDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            try
            {
                using (Stream file = binaryFileSaveDialog.OpenFile())
                {
                    using (BinaryWriter writer = new BinaryWriter(file))
                    {
                        order.ExportBinary(writer);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"ファイルの保存中にエラーが発生しました。\n{exception}", "保存に失敗しました", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
