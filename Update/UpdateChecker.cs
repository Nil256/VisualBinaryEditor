using System.Windows.Forms;

namespace VisualBinaryEditor.Update
{
    internal static class UpdateChecker
    {
        internal static void CheckUpdate(ReleasedVersion currentVersion)
        {
            UpdateCheckingDialog dialog = new UpdateCheckingDialog();
            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            ReleasedVersions releasedVersions = dialog.Versions;
            releasedVersions.Sort();
            new UpdateCheckedResultDialog(releasedVersions).ShowDialog();
        }
    }
}
