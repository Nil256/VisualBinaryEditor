using System;
using System.Drawing;
using System.Windows.Forms;
using VisualBinaryEditor.BinaryEntries;

namespace VisualBinaryEditor
{
    internal class BinaryBoolEntryControl : IBinaryEntryControl
    {
        internal static IBinaryEntryControl Create(in int index, in Panel parent)
        {
            return new BinaryBoolEntryControl(index, parent, new BinaryBoolEntry());
        }

        private readonly Panel _parentPanel;
        private readonly IBinaryEntry binaryEntry;
        private readonly Panel panel;
        private readonly Label indexLabel;
        private readonly Label nameLabel;
        private readonly TextBox nameTextBox;
        private readonly Label typeLabel;
        private readonly Label valueLabel;
        private readonly ComboBox valueBox;

        private int _index;
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                _index = value;
                panel.Location = BinaryEntryControlCreater.GetLocation(_index, _parentPanel.AutoScrollPosition);
                indexLabel.Text = BinaryEntryControlCreater.GetIndexText(_index);
            }
        }

        private bool _selected;
        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                _selected = value;
                Color panelColor = _selected ? SystemColors.Highlight : SystemColors.ControlLightLight;
                Color textColor = _selected ? SystemColors.HighlightText : SystemColors.ControlText;
                panel.BackColor = panelColor;
                indexLabel.ForeColor = textColor;
                nameLabel.ForeColor = textColor;
                typeLabel.ForeColor = textColor;
                valueLabel.ForeColor = textColor;
                nameTextBox.Enabled = _selected;
                valueBox.Enabled = _selected;
            }
        }

        public Control Control => panel;

        public event EventHandler? Click
        {
            add
            {
                panel.Click += value;
                indexLabel.Click += value;
                nameLabel.Click += value;
                typeLabel.Click += value;
                valueLabel.Click += value;
            }
            remove
            {
                panel.Click -= value;
                indexLabel.Click -= value;
                nameLabel.Click -= value;
                typeLabel.Click -= value;
                valueLabel.Click -= value;
            }
        }

        private BinaryBoolEntryControl(in int index, in Panel parent, in IBinaryEntry entry)
        {
            _index = index;
            _parentPanel = parent;

            binaryEntry = entry;
            panel = new Panel();
            indexLabel = new Label();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            typeLabel = new Label();
            valueLabel = new Label();
            valueBox = new ComboBox();
            panel.SuspendLayout();

            parent.Controls.Add(panel);

            panel.BackColor = SystemColors.ControlLightLight;
            panel.Controls.Add(indexLabel);
            panel.Controls.Add(nameLabel);
            panel.Controls.Add(nameTextBox);
            panel.Controls.Add(typeLabel);
            panel.Controls.Add(valueLabel);
            panel.Controls.Add(valueBox);
            panel.Location = BinaryEntryControlCreater.GetLocation(index, _parentPanel.AutoScrollOffset);
            panel.Name = "binaryNumberEntryPanel";
            panel.Size = BinaryEntryControlCreater.PanelSize;

            indexLabel.SetAsIndexLabel(index);
            nameLabel.SetAsNameLabel();
            nameTextBox.SetAsNameTextBox();
            typeLabel.SetAsTypeLabel(binaryEntry.Type);
            valueLabel.SetAsValueLabel();

            valueBox.FormattingEnabled = true;
            valueBox.Items.Add("false");
            valueBox.Items.Add("true");
            valueBox.Location = new Point(460, 10);
            valueBox.Name = "valueBox";
            valueBox.Size = BinaryEntryControlCreater.ValueBoxSize;
            valueBox.SelectedIndex = 0;
            valueBox.Enabled = false;
            // valueBox.Text = "false";

            panel.ResumeLayout(false);
            panel.PerformLayout();
        }
    }
}
