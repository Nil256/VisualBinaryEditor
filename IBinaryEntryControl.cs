using System;
using System.Windows.Forms;
using VisualBinaryEditor.BinaryEntries;

namespace VisualBinaryEditor
{
    internal interface IBinaryEntryControl
    {
        public IBinaryEntry Entry { get; }

        public int Index { get; set; }
        public bool Selected { get; set; }
        public Control Control { get; }

        public event EventHandler? Click;
    }
}
