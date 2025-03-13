using System;
using System.IO;

namespace VisualBinaryEditor.BinaryEntries
{
    internal class BinaryShortEntry : IBinaryEntry
    {
        public BinaryType Type => BinaryType.Short;

        internal short Value { get; set; }

        public void SetValue(in object value)
        {
            Value = Convert.ToInt16(value);
        }

        public void Write(in BinaryWriter writer)
        {
            writer.Write(Value);
        }
    }

    internal class BinaryUshortEntry : IBinaryEntry
    {
        public BinaryType Type => BinaryType.Ushort;

        internal ushort Value { get; set; }

        public void SetValue(in object value)
        {
            Value = Convert.ToUInt16(value);
        }

        public void Write(in BinaryWriter writer)
        {
            writer.Write(Value);
        }
    }
}
