using System.Windows.Forms;

namespace VisualBinaryEditor.Utils
{
    internal class MessageBoxCreater
    {
        private readonly MessageBoxIcon _icon;
        private readonly string _title;
        private readonly string _message;
        private readonly MessageBoxButtons _buttons;

        internal MessageBoxCreater(in string message, in string caption, in MessageBoxButtons buttons, in MessageBoxIcon icon)
        {
            _message = message;
            _title = caption;
            _buttons = buttons;
            _icon = icon;
        }

        internal DialogResult ShowDialog()
        {
            return MessageBox.Show(_message, _title, _buttons, _icon);
        }
    }
}
