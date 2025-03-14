using System.IO;

namespace VisualBinaryEditor.BinaryEntries
{
    internal abstract class BinaryIntegerEntryBase : IBinaryEntry, INumericUpDownValueConverter
    {
        public abstract BinaryType Type { get; }

        public abstract decimal GetValue();
        public abstract void SetValue(in decimal value);

        public abstract void Read(in BinaryReader reader);
        public abstract void Write(in BinaryWriter writer);
    }
}
