using System.IO;

namespace VisualBinaryEditor.BinaryEntries
{
    internal interface IBinaryEntry
    {
        public BinaryType Type { get; }

        public void Read(in BinaryReader reader);
        public void Write(in BinaryWriter writer);
    }
}
