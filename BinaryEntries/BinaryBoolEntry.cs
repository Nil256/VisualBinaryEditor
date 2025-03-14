using System.IO;

namespace VisualBinaryEditor.BinaryEntries
{
    internal class BinaryBoolEntry : IBinaryEntry
    {
        public BinaryType Type => BinaryType.Bool;

        internal bool Value { get; set; }

        public int GetValue()
        {
            return Value ? 1 : 0;
        }
        public void SetValue(in string value)
        {
            Value = bool.Parse(value);
        }

        public void Read(in BinaryReader reader)
        {
            Value = reader.ReadBoolean();
        }
        public void Write(in BinaryWriter writer)
        {
            writer.Write(Value);
        }
    }
}
