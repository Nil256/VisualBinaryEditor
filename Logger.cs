using System;
using System.IO;
using System.Windows.Forms;
using VisualBinaryEditor.Utils;

namespace VisualBinaryEditor
{
    internal static class Logger
    {
        private static string GetLogFilePath(in string logFileName)
        {
            return Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), logFileName);
        }

        internal static string GetErrorLogFilePath()
        {
            const string FILE_NAME = "Error.log";
            return GetLogFilePath(FILE_NAME);
        }

        internal static bool Error(in string message, out MessageBoxCreater[] failedMessages)
        {
            failedMessages = Array.Empty<MessageBoxCreater>();
            string filePath = GetErrorLogFilePath();
            try
            {
                File.WriteAllText(filePath, message);
            }
            catch (Exception ex)
            {
                failedMessages = new MessageBoxCreater[2];
                failedMessages[0] = new MessageBoxCreater($"エラーのログを出力できませんでした。\n以下エラーのログ:\n{message}", "致命的なエラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                failedMessages[1] = new MessageBoxCreater($"ログの出力に関するエラー:\n{ex.ToString()}", "致命的なエラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            return true;
        }
    }
}
