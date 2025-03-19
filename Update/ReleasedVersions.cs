using System.Collections.Generic;
using System.Text.Json;

namespace VisualBinaryEditor.Update
{
    internal class ReleasedVersions
    {
        private readonly List<ReleasedVersion> _officialVersions;
        private readonly List<ReleasedVersion> _preReleaseVersions;

        internal IReadOnlyList<ReleasedVersion> OfficialVersion => _officialVersions;
        internal IReadOnlyList<ReleasedVersion> PreReleaseVersion => _preReleaseVersions;

        internal ReleasedVersions()
        {
            _officialVersions = new List<ReleasedVersion>();
            _preReleaseVersions = new List<ReleasedVersion>();
        }

        internal void Add(JsonElement releaseJsonElement)
        {
            string? versionName = "";
            foreach (JsonProperty jsonElement in releaseJsonElement.EnumerateObject())
            {
                /*
                switch (jsonElement.Name)
                {
                    case "tag_name":
                        break;
                    case "prerelease":
                        break;
                }
                */
                if (jsonElement.Name != "tag_name")
                {
                    continue;
                }
                versionName = jsonElement.Value.GetString();
            }
            if (string.IsNullOrEmpty(versionName))
            {
                return;
            }
            ReleasedVersion version = new ReleasedVersion(versionName);
            if (version.OfficialRelease)
            {
                _officialVersions.Add(version);
            }
            else
            {
                _preReleaseVersions.Add(version);
            }
        }

        internal void Sort()
        {
            _officialVersions.Sort();
            _preReleaseVersions.Sort();
        }
    }
}
