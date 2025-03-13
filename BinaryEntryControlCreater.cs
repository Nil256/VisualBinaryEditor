using System.Drawing;
using System.Windows.Forms;

namespace VisualBinaryEditor
{
    internal static class BinaryEntryControlCreater
    {
        internal static readonly Size PanelSize = new Size(677, 50);
        internal static readonly Size ValueBoxSize = new Size(210, 30);

        internal static Point GetLocation(in int index, in Point offset)
        {
            int x = 5;
            int y = 5 + index * 52;
            x += offset.X;
            y += offset.Y;
            return new Point(x, y);
        }

        internal static string GetIndexText(in int index)
        {
            int indexForText = index + 1;
            if (indexForText < 10)
            {
                return indexForText.ToString("00");
            }
            return indexForText.ToString();
        }

        internal static void SetAsIndexLabel(this Label indexLabel, in int index)
        {
            int indexForText = index + 1;
            indexLabel.AutoSize = true;
            indexLabel.Location = new Point(15, 14);
            indexLabel.Name = "indexLabel";
            indexLabel.Size = new Size(28, 23);
            indexLabel.Text = GetIndexText(index);
        }

        internal static void SetAsNameLabel(this Label nameLabel)
        {
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(60, 14);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(60, 23);
            nameLabel.Text = "Name:";
        }

        internal static void SetAsNameTextBox(this TextBox nameTextBox)
        {
            nameTextBox.Location = new Point(120, 10);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(150, 30);
        }

        internal static void SetAsTypeLabel(this Label typeLabel, in BinaryType type)
        {
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(282, 14);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(112, 23);
            typeLabel.Text = $"Type: {type.ToString().ToLower()}";
        }

        internal static void SetAsValueLabel(this Label valueLabel)
        {
            valueLabel.AutoSize = true;
            valueLabel.Location = new Point(400, 14);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new Size(56, 23);
            valueLabel.Text = "Value:";
        }
    }
}
