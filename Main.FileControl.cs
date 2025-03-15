using System;
using System.IO;
using System.Windows.Forms;

namespace VisualBinaryEditor
{
    public partial class Main
    {
        private EditingFile editingFile;

        private void fileNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order.Clear();
            editingFile = new EditingFile();
            editingFileNameToolStripStatusLabel.Text = "";
            fileReloadToolStripMenuItem.Enabled = false;
        }

        private void fileOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CanLoadBinaryFile())
            {
                return;
            }
            DialogResult result = binaryFileOpenDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            LoadBinaryFile(binaryFileOpenDialog.FileName);
        }

        private void fileReloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CanLoadBinaryFile())
            {
                return;
            }
            LoadBinaryFile(editingFile.FilePath);
        }

        private void binaryOrderPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data == null || !e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.None;
                return;
            }
            e.Effect = DragDropEffects.Copy;
        }

        private void binaryOrderPanel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null || !e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                return;
            }
            string[]? files = (string[]?)e.Data.GetData(DataFormats.FileDrop);
            if (files == null || files.Length == 0)
            {
                return;
            }
            if (!CanLoadBinaryFile())
            {
                return;
            }
            if (files.Length > 1)
            {
                DialogResult result = MessageBox.Show("複数のファイルを同時に編集できません。\n最初のファイルを読み込みますか？", "複数のファイルを検出しました", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            string filePath = files[0];
            LoadBinaryFile(filePath);
        }

        private bool CanLoadBinaryFile()
        {
            if (!order.CanImportBinary())
            {
                MessageBox.Show("バイナリファイルを読み込むには、\nバイナリエントリが最低でも1つ必要です。", "読み込むためのバイナリエントリがありません", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void LoadBinaryFile(in string filePath)
        {
            bool notEndOfStream = false;
            try
            {
                using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(file))
                    {
                        order.ImportBinary(reader);
                        Stream stream = reader.BaseStream;
                        if (stream.Position < stream.Length)
                        {
                            notEndOfStream = true;
                        }
                    }
                }
            }
            catch (EndOfStreamException)
            {
                MessageBox.Show($"ファイルのデータよりバイナリエントリが多いです。\n現在のバイナリオーダーがファイルのバイナリの構成と異なっている可能性が高いです。", "読み込み終了後にエラーが発生しました", MessageBoxButtons.OK, MessageBoxIcon.Error);
                editingFile = new EditingFile(filePath);
                editingFileNameToolStripStatusLabel.Text = Path.GetFileName(filePath);
                fileReloadToolStripMenuItem.Enabled = true;
                return;
            }
            catch (Exception exception)
            {
                MessageBox.Show($"ファイルの読み込み中にエラーが発生しました。\n{exception}", "読み込みに失敗しました", MessageBoxButtons.OK, MessageBoxIcon.Error);
                editingFile = new EditingFile();
                editingFileNameToolStripStatusLabel.Text = "";
                fileReloadToolStripMenuItem.Enabled = false;
                return;
            }
            editingFile = new EditingFile(filePath);
            editingFileNameToolStripStatusLabel.Text = Path.GetFileName(filePath);
            fileReloadToolStripMenuItem.Enabled = true;
            if (notEndOfStream)
            {
                MessageBox.Show($"ファイルのデータよりバイナリエントリが少ないです。\n現在のバイナリオーダーがファイルのバイナリの構成と異なっている可能性があります。", "バイナリの長さの不一致", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fileSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Focus();
            if (!CanSaveBinaryFile())
            {
                return;
            }
            if (editingFile.NewFile || !File.Exists(editingFile.FilePath))
            {
                SaveNewBinaryFile();
                return;
            }
            SaveBinaryFile(editingFile.FilePath);
        }

        private void fileNewSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Focus();
            if (!CanSaveBinaryFile())
            {
                return;
            }
            SaveNewBinaryFile();
        }

        private bool CanSaveBinaryFile()
        {
            if (!order.CanExportBinary())
            {
                MessageBox.Show("バイナリファイルを保存するには、\nバイナリエントリが最低でも1つ必要です。", "保存するデータがありません", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void SaveNewBinaryFile()
        {
            DialogResult result = binaryFileSaveDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            SaveBinaryFile(binaryFileSaveDialog.FileName);
        }

        private void SaveBinaryFile(in string filePath)
        {
            try
            {
                using (FileStream file = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    using (BinaryWriter writer = new BinaryWriter(file))
                    {
                        order.ExportBinary(writer);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"ファイルの保存中にエラーが発生しました。\n{exception}", "保存に失敗しました", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            editingFile = new EditingFile(filePath);
            editingFileNameToolStripStatusLabel.Text = Path.GetFileName(filePath);
            fileReloadToolStripMenuItem.Enabled = true;
        }
    }
}
