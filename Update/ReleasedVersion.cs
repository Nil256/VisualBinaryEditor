using System;

namespace VisualBinaryEditor.Update
{
    internal class ReleasedVersion : IComparable<ReleasedVersion>
    {
        internal static readonly ReleasedVersion Dummy_Official = new ReleasedVersion(true);
        internal static readonly ReleasedVersion Dummy_PreRelease = new ReleasedVersion(false);

        private const string ALPHA_SUFFIX = "-alpha";
        private const string BETA_SUFFIX = "-beta";
        private const string RC_SUFFIX = "-rc";

        internal string VersionName { get; init; }
        internal bool OfficialRelease { get; init; }
        private Version Version { get; init; }
        private PreReleaseSuffix Suffix { get; init; }

        private ReleasedVersion(bool officialRelease)
        {
            VersionName = "-";
            OfficialRelease = officialRelease;
            Version = new Version(0, 0, 0);
            Suffix = PreReleaseSuffix.Alpha;
        }

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
            OfficialRelease = Suffix == PreReleaseSuffix.None;
            if (!Version.TryParse(versionNameWithoutSuffix.AsSpan(1), out Version? version) || version == null)
            {
                throw new ArgumentException("バージョン名が正しくない可能性があります。", nameof(versionName));
            }
            Version = version;
        }

        public static bool operator ==(ReleasedVersion a, ReleasedVersion b)
        {
            return a.Version == b.Version && a.Suffix == b.Suffix;
        }

        public static bool operator !=(ReleasedVersion a, ReleasedVersion b)
        {
            return !(a == b);
        }

        public static bool operator >(ReleasedVersion a, ReleasedVersion b)
        {
            if (a.Version > b.Version)
            {
                return true;
            }
            if (a.Version == b.Version)
            {
                return a.Suffix.IsGreaterThan(b.Suffix);
            }
            return false;
        }

        public static bool operator <(ReleasedVersion a, ReleasedVersion b)
        {
            if (a.Version < b.Version)
            {
                return true;
            }
            if (a.Version == b.Version)
            {
                return a.Suffix.IsLessThan(b.Suffix);
            }
            return false;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not ReleasedVersion other)
            {
                return false;
            }
            return this == other;
        }

        public override int GetHashCode()
        {
            return VersionName.GetHashCode();
        }

        public int CompareTo(ReleasedVersion? other)
        {
            if (other is null)
            {
                return 1;
            }
            if (this < other)
            {
                return -1;
            }
            if (this > other)
            {
                return 1;
            }
            return 0;
        }
    }
}
