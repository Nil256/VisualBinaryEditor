using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualBinaryEditor
{
    public partial class Main
    {
        private readonly BinaryOrder order;

        private void boolButton_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Bool);
        }
        private void editEntryAddBoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Bool);
        }

        private void byteButton_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Byte);
        }
        private void editEntryAddByteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Byte);
        }

        private void sbyteButton_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Sbyte);
        }
        private void editEntryAddSbyteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Sbyte);
        }

        private void shortButton_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Short);
        }
        private void editEntryAddShortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Short);
        }

        private void ushortButton_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Ushort);
        }
        private void editEntryAddUshortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Ushort);
        }

        private void intButton_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Int);
        }
        private void editEntryAddIntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Int);
        }

        private void uintButton_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Uint);
        }
        private void editEntryAddUintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Uint);
        }

        private void longButton_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Long);
        }
        private void editEntryAddLongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Long);
        }

        private void ulongButton_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Ulong);
        }
        private void editEntryAddUlongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order.Add(BinaryType.Ulong);
        }


        private void upButton_Click(object sender, EventArgs e)
        {
            order.MoveUp();
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            order.MoveDown();
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            order.Remove();
        }
        private void editEntryRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order.Remove();
        }

        private void editEntryClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order.Clear();
        }
    }
}
