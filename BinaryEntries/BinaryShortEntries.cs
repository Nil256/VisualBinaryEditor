using System.IO;

namespace VisualBinaryEditor.BinaryEntries
{
    internal class BinaryShortEntry : IBinaryEntry
    {
        public BinaryType Type => BinaryType.Short;

        internal short Value { get; set; }

        public void SetValue(in object value)
        {
            Value = decimal.ToInt16((decimal)value);
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
            Value = decimal.ToUInt16((decimal)value);
        }

        public void Write(in BinaryWriter writer)
        {
            writer.Write(Value);
        }
    }
}
