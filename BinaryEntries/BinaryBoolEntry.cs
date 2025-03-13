using System;
using System.IO;

namespace VisualBinaryEditor.BinaryEntries
{
    internal class BinaryBoolEntry : IBinaryEntry
    {
        public BinaryType Type => BinaryType.Bool;

        internal bool Value { get; set; }

        public void SetValue(in object value)
        {
            Value = Convert.ToBoolean(value);
        }

        public void Write(in BinaryWriter writer)
        {
            writer.Write(Value);
        }
    }
}
