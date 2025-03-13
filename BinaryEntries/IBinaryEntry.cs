using System.IO;

namespace VisualBinaryEditor.BinaryEntries
{
    internal interface IBinaryEntry
    {
        public BinaryType Type { get; }

        public void SetValue(in object value);

        public void Write(in BinaryWriter writer);
    }
}
