using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace VisualBinaryEditor.Update
{
    public partial class UpdateCheckedResultDialog : Form
    {
        private const string URL_BASE = "https://github.com/Nil256/VisualBinaryEditor/releases/tag/";

        // private readonly ReleasedVersions _releasedVersions;
        private readonly ReleasedVersion _latestOfficicalVersion;
        private readonly ReleasedVersion _latestPreReleaseVersion;

        internal UpdateCheckedResultDialog(ReleasedVersions releasedVersions)
        {
            InitializeComponent();

            ReleasedVersion currentVersion = Main.CurrentVersion;
            currentVersionLabel.Text += currentVersion.VersionName;
            if (!Main.CurrentVersion.OfficialRelease)
            {
                preReleaseWarningLabel.Visible = false;
            }

            _latestOfficicalVersion = ReleasedVersion.Dummy_Official;
            _latestPreReleaseVersion = ReleasedVersion.Dummy_PreRelease;
            // _releasedVersions = releasedVersions;
            IReadOnlyList<ReleasedVersion> officialVersion = releasedVersions.OfficialVersion;
            IReadOnlyList<ReleasedVersion> preReleaseVersion = releasedVersions.PreReleaseVersion;
            if (officialVersion.Count > 0)
            {
                _latestOfficicalVersion = officialVersion[officialVersion.Count - 1];
            }
            if (preReleaseVersion.Count > 0)
            {
                _latestPreReleaseVersion = preReleaseVersion[preReleaseVersion.Count - 1];
            }
            officialVersionLabel.Text += _latestOfficicalVersion.VersionName;
            preReleaseVersionLabel.Text += _latestPreReleaseVersion.VersionName;

            bool existsLatestOfficalUpdate = _latestOfficicalVersion > currentVersion;
            bool existsLatestPreReleaseUpdate = _latestPreReleaseVersion > currentVersion;
            if (existsLatestOfficalUpdate)
            {
                downloadOfficalVersionButton.Enabled = true;
            }
            if (existsLatestPreReleaseUpdate)
            {
                downloadPreReleaseVersionButton.Enabled = true;
            }

            if (!existsLatestOfficalUpdate && !existsLatestPreReleaseUpdate)
            {
                resultLabel.Text = "ソフトウェアは最新です。";
                return;
            }
            if (existsLatestOfficalUpdate)
            {
                // resultLabel.Text = "アップデートが見つかりました。";
                downloadOfficalVersionButton.Focus();
                return;
            }
            if (currentVersion.OfficialRelease)
            {
                resultLabel.Text = "プレリリースのアップデートが見つかりました。";
                closeButton.Focus();
            }
            else
            {
                // resultLabel.Text = "アップデートが見つかりました。";
                downloadPreReleaseVersionButton.Focus();
            }
        }

        private void downloadOfficalVersionButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo()
            {
                FileName = URL_BASE + _latestOfficicalVersion.VersionName,
                UseShellExecute = true
            };
            Process.Start(info);
        }

        private void downloadPreReleaseVersionButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo()
            {
                FileName = URL_BASE + _latestPreReleaseVersion.VersionName,
                UseShellExecute = true
            };
            Process.Start(info);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
