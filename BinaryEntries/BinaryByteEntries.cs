using System.IO;

namespace VisualBinaryEditor.BinaryEntries
{
    internal class BinaryByteEntry : BinaryIntegerEntryBase
    {
        public override BinaryType Type => BinaryType.Byte;

        internal byte Value { get; set; }

        public override decimal GetValue()
        {
            return Value;
        }
        public override void SetValue(in decimal value)
        {
            Value = decimal.ToByte(value);
        }

        public override void Read(in BinaryReader reader)
        {
            Value = reader.ReadByte();
        }
        public override void Write(in BinaryWriter writer)
        {
            writer.Write(Value);
        }
    }

    internal class BinarySbyteEntry : BinaryIntegerEntryBase
    {
        public override BinaryType Type => BinaryType.Sbyte;

        internal sbyte Value { get; set; }

        public override decimal GetValue()
        {
            return Value;
        }
        public override void SetValue(in decimal value)
        {
            Value = decimal.ToSByte(value);
        }

        public override void Read(in BinaryReader reader)
        {
            Value = reader.ReadSByte();
        }
        public override void Write(in BinaryWriter writer)
        {
            writer.Write(Value);
        }
    }
}
