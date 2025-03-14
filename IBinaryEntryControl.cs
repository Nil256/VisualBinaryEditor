using System;
using System.IO;
using System.Windows.Forms;
using VisualBinaryEditor.BinaryEntries;

namespace VisualBinaryEditor
{
    internal interface IBinaryEntryControl
    {
        public int Index { get; set; }
        public bool Selected { get; set; }
        public Control Control { get; }

        public event EventHandler? Click;

        public void Read(in BinaryReader reader);
        public void Write(in BinaryWriter writer);
    }
}
