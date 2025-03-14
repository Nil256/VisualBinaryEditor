using System.IO;

namespace VisualBinaryEditor.BinaryEntries
{
    internal class BinaryLongEntry : BinaryIntegerEntryBase
    {
        public override BinaryType Type => BinaryType.Long;

        internal long Value { get; set; }

        public override decimal GetValue()
        {
            return Value;
        }
        public override void SetValue(in decimal value)
        {
            Value = decimal.ToInt64(value);
        }

        public override void Read(in BinaryReader reader)
        {
            Value = reader.ReadInt64();
        }
        public override void Write(in BinaryWriter writer)
        {
            writer.Write(Value);
        }
    }

    internal class BinaryUlongEntry : BinaryIntegerEntryBase
    {
        public override BinaryType Type => BinaryType.Ulong;

        internal ulong Value { get; set; }

        public override decimal GetValue()
        {
            return Value;
        }
        public override void SetValue(in decimal value)
        {
            Value = decimal.ToUInt64(value);
        }

        public override void Read(in BinaryReader reader)
        {
            Value = reader.ReadUInt64();
        }
        public override void Write(in BinaryWriter writer)
        {
            writer.Write(Value);
        }
    }
}
