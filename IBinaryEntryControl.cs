using System;
using System.Windows.Forms;

namespace VisualBinaryEditor
{
    internal interface IBinaryEntryControl
    {
        public int Index { get; set; }
        public bool Selected { get; set; }

        public Control Control { get; }

        public event EventHandler? Click;
    }
}
