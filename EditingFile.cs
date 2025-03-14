using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualBinaryEditor
{
    internal class EditingFile
    {
        internal bool NewFile { get; init; }
        internal string FilePath { get; init; }

        internal EditingFile()
        {
            NewFile = true;
            FilePath = "";
        }

        internal EditingFile(string filePath)
        {
            NewFile = false;
            FilePath = filePath;
        }
    }
}
