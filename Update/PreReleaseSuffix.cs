using System.Collections.Generic;

namespace VisualBinaryEditor.Update
{
    internal enum PreReleaseSuffix
    {
        None,
        Alpha,
        Beta,
        Rc
    }

    internal static class PreReleaseSuffixUtil
    {
        private static readonly Dictionary<PreReleaseSuffix, byte> _compareValues;

        static PreReleaseSuffixUtil()
        {
            _compareValues = new Dictionary<PreReleaseSuffix, byte>();
            _compareValues.Add(PreReleaseSuffix.Alpha, 0);
            _compareValues.Add(PreReleaseSuffix.Beta, 1);
            _compareValues.Add(PreReleaseSuffix.Rc, 2);
            _compareValues.Add(PreReleaseSuffix.None, 255);
        }

        /// <summary><code>self &gt; other</code></summary>
        internal static bool IsGreaterThan(this PreReleaseSuffix self, in PreReleaseSuffix other)
        {
            return _compareValues[self] > _compareValues[other];
        }

        /// <summary><code>self &lt; other</code></summary>
        internal static bool IsLessThan(this PreReleaseSuffix self, in PreReleaseSuffix other)
        {
            return _compareValues[self] < _compareValues[other];
        }
    }
}
