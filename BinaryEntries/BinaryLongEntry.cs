using System;
using System.IO;

namespace VisualBinaryEditor.BinaryEntries
{
    internal class BinaryLongEntry : IBinaryEntry
    {
        public BinaryType Type => BinaryType.Long;

        internal long Value { get; set; }

        public void SetValue(in object value)
        {
            Value = Convert.ToInt64(value);
        }

        public void Write(in BinaryWriter writer)
        {
            writer.Write(Value);
        }
    }

    internal class BinaryUlongEntry : IBinaryEntry
    {
        public BinaryType Type => BinaryType.Ulong;

        internal ulong Value { get; set; }

        public void SetValue(in object value)
        {
            Value = Convert.ToUInt64(value);
        }

        public void Write(in BinaryWriter writer)
        {
            writer.Write(Value);
        }
    }
}
