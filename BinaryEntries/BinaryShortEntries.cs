using System.IO;

namespace VisualBinaryEditor.BinaryEntries
{
    internal class BinaryShortEntry : BinaryIntegerEntryBase
    {
        public override BinaryType Type => BinaryType.Short;

        internal short Value { get; set; }

        public override decimal GetValue()
        {
            return Value;
        }
        public override void SetValue(in decimal value)
        {
            Value = decimal.ToInt16(value);
        }

        public override void Read(in BinaryReader reader)
        {
            Value = reader.ReadInt16();
        }
        public override void Write(in BinaryWriter writer)
        {
            writer.Write(Value);
        }
    }

    internal class BinaryUshortEntry : BinaryIntegerEntryBase
    {
        public override BinaryType Type => BinaryType.Ushort;

        internal ushort Value { get; set; }

        public override decimal GetValue()
        {
            return Value;
        }
        public override void SetValue(in decimal value)
        {
            Value = decimal.ToUInt16(value);
        }

        public override void Read(in BinaryReader reader)
        {
            Value = reader.ReadUInt16();
        }
        public override void Write(in BinaryWriter writer)
        {
            writer.Write(Value);
        }
    }
}
