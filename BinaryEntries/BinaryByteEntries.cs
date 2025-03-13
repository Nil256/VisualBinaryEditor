using System;
using System.IO;

namespace VisualBinaryEditor.BinaryEntries
{
    internal class BinaryByteEntry : IBinaryEntry
    {
        public BinaryType Type => BinaryType.Byte;

        internal byte Value { get; set; }

        public void SetValue(in object value)
        {
            Value = Convert.ToByte(value);
        }

        public void Write(in BinaryWriter writer)
        {
            writer.Write(Value);
        }
    }

    internal class BinarySbyteEntry : IBinaryEntry
    {
        public BinaryType Type => BinaryType.Sbyte;

        internal sbyte Value { get; set; }

        public void SetValue(in object value)
        {
            Value = Convert.ToSByte(value);
        }

        public void Write(in BinaryWriter writer)
        {
            writer.Write(Value);
        }
    }
}
