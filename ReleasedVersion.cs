using System;

namespace VisualBinaryEditor
{
    internal class ReleasedVersion
    {
        private const string ALPHA_SUFFIX = "-alpha";
        private const string BETA_SUFFIX = "-beta";
        private const string RC_SUFFIX = "-rc";

        internal string VersionName { get; init; }
        internal bool OfficialRelease { get; init; }
        internal string Version { get; init; }
        internal PreReleaseSuffix Suffix { get; init; }

        internal ReleasedVersion(in string versionName)
        {
            VersionName = versionName;
            string versionNameWithoutSuffix = versionName;
            string lowerVersionName = versionName.ToLower();
            if (lowerVersionName.EndsWith(ALPHA_SUFFIX))
            {
                Suffix = PreReleaseSuffix.Alpha;
                versionNameWithoutSuffix = versionNameWithoutSuffix.Substring(0, lowerVersionName.Length - ALPHA_SUFFIX.Length);
            }
            else if (lowerVersionName.EndsWith(BETA_SUFFIX))
            {
                Suffix = PreReleaseSuffix.Beta;
                versionNameWithoutSuffix = versionNameWithoutSuffix.Substring(0, lowerVersionName.Length - BETA_SUFFIX.Length);
            }
            else if (lowerVersionName.EndsWith(RC_SUFFIX))
            {
                Suffix = PreReleaseSuffix.Rc;
                versionNameWithoutSuffix = versionNameWithoutSuffix.Substring(0, lowerVersionName.Length - RC_SUFFIX.Length);
            }
            else
            {
                Suffix = PreReleaseSuffix.None;
            }
            if (!char.IsDigit(versionNameWithoutSuffix[versionNameWithoutSuffix.Length - 1]))
            {
                throw new ArgumentException("バージョンが正しくない可能性があります。", nameof(versionName));
            }
            OfficialRelease = Suffix == PreReleaseSuffix.None;
            Version = versionNameWithoutSuffix;
        }
    }
}
