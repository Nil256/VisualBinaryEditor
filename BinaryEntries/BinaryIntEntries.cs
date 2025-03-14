using System.IO;

namespace VisualBinaryEditor.BinaryEntries
{
    internal class BinaryIntEntry : BinaryIntegerEntryBase
    {
        public override BinaryType Type => BinaryType.Int;

        internal int Value { get; set; }

        public override decimal GetValue()
        {
            return Value;
        }
        public override void SetValue(in decimal value)
        {
            Value = decimal.ToInt32(value);
        }

        public override void Read(in BinaryReader reader)
        {
            Value = reader.ReadInt32();
        }
        public override void Write(in BinaryWriter writer)
        {
            writer.Write(Value);
        }
    }

    internal class BinaryUintEntry : BinaryIntegerEntryBase
    {
        public override BinaryType Type => BinaryType.Uint;

        internal uint Value { get; set; }

        public override decimal GetValue()
        {
            return Value;
        }
        public override void SetValue(in decimal value)
        {
            Value = decimal.ToUInt32(value);
        }

        public override void Read(in BinaryReader reader)
        {
            Value = reader.ReadUInt32();
        }

        public override void Write(in BinaryWriter writer)
        {
            writer.Write(Value);
        }
    }
}
