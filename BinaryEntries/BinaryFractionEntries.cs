using System;
using System.IO;

namespace VisualBinaryEditor.BinaryEntries
{
    internal class BinaryFloatEntry : IBinaryEntry
    {
        public BinaryType Type => BinaryType.Float;

        internal float Value { get; set; }

        public void SetValue(in object value)
        {
            throw new NotImplementedException();
        }

        public void Read(in BinaryReader reader)
        {
            Value = reader.ReadSingle();
        }

        public void Write(in BinaryWriter writer)
        {
            writer.Write(Value);
        }
    }

    internal class BinaryDoubleEntry : IBinaryEntry
    {
        public BinaryType Type => BinaryType.Double;

        internal double Value { get; set; }

        public void SetValue(in object value)
        {
            throw new NotImplementedException();
        }

        public void Read(in BinaryReader reader)
        {
            Value = reader.ReadDouble();
        }

        public void Write(in BinaryWriter writer)
        {
            writer.Write(Value);
        }
    }

    internal class BinaryDecimalEntry : IBinaryEntry
    {
        public BinaryType Type => BinaryType.Decimal;

        internal decimal Value { get; set; }

        public void SetValue(in object value)
        {
            throw new NotImplementedException();
        }

        public void Read(in BinaryReader reader)
        {
            Value = reader.ReadDecimal();
        }

        public void Write(in BinaryWriter writer)
        {
            writer.Write(Value);
        }
    }
}
