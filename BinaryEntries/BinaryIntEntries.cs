using System;
using System.IO;

namespace VisualBinaryEditor.BinaryEntries
{
    internal class BinaryIntEntry : IBinaryEntry
    {
        public BinaryType Type => BinaryType.Int;

        internal int Value { get; set; }

        public void SetValue(in object value)
        {
            Value = Convert.ToInt32(value);
        }

        public void Write(in BinaryWriter writer)
        {
            writer.Write(Value);
        }
    }

    internal class BinaryUintEntry : IBinaryEntry
    {
        public BinaryType Type => BinaryType.Uint;

        internal uint Value { get; set; }

        public void SetValue(in object value)
        {
            Value = Convert.ToUInt32(value);
        }

        public void Write(in BinaryWriter writer)
        {
            writer.Write(Value);
        }
    }
}
