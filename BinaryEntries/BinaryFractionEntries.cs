using System;
using System.IO;

namespace VisualBinaryEditor.BinaryEntries
{
    class BinaryFloatEntry : IBinaryEntry
    {
        public BinaryType Type => BinaryType.Float;

        internal float Value { get; set; }

        public void SetValue(in object value)
        {
            Value = Convert.ToSingle(value);
        }

        public void Write(in BinaryWriter writer)
        {
            writer.Write(Value);
        }
    }

    class BinaryDoubleEntry : IBinaryEntry
    {
        public BinaryType Type => BinaryType.Double;

        internal double Value { get; set; }

        public void SetValue(in object value)
        {
            Value = Convert.ToDouble(value);
        }

        public void Write(in BinaryWriter writer)
        {
            writer.Write(Value);
        }
    }

    class BinaryDecimalEntry : IBinaryEntry
    {
        public BinaryType Type => BinaryType.Decimal;

        internal decimal Value { get; set; }

        public void SetValue(in object value)
        {
            Value = Convert.ToDecimal(value);
        }

        public void Write(in BinaryWriter writer)
        {
            writer.Write(Value);
        }
    }
}
