using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using VisualBinaryEditor.BinaryEntries;

namespace VisualBinaryEditor
{
    internal class BinaryIntegerEntryControl : IBinaryEntryControl
    {
        internal static IBinaryEntryControl CreateByte(in int index, in Panel parent)
        {
            return new BinaryIntegerEntryControl(index, parent, new BinaryByteEntry());
        }
        internal static IBinaryEntryControl CreateSbyte(in int index, in Panel parent)
        {
            return new BinaryIntegerEntryControl(index, parent, new BinarySbyteEntry());
        }

        internal static IBinaryEntryControl CreateShort(in int index, in Panel parent)
        {
            return new BinaryIntegerEntryControl(index, parent, new BinaryShortEntry());
        }
        internal static IBinaryEntryControl CreateUshort(in int index, in Panel parent)
        {
            return new BinaryIntegerEntryControl(index, parent, new BinaryUshortEntry());
        }

        internal static IBinaryEntryControl CreateInt(in int index, in Panel parent)
        {
            return new BinaryIntegerEntryControl(index, parent, new BinaryIntEntry());
        }
        internal static IBinaryEntryControl CreateUint(in int index, in Panel parent)
        {
            return new BinaryIntegerEntryControl(index, parent, new BinaryUintEntry());
        }

        internal static IBinaryEntryControl CreateLong(in int index, in Panel parent)
        {
            return new BinaryIntegerEntryControl(index, parent, new BinaryLongEntry());
        }
        internal static IBinaryEntryControl CreateUlong(in int index, in Panel parent)
        {
            return new BinaryIntegerEntryControl(index, parent, new BinaryUlongEntry());
        }

        private readonly Panel _parentPanel;
        private readonly IBinaryEntry binaryEntry;
        private readonly Panel panel;
        private readonly Label indexLabel;
        private readonly Label nameLabel;
        private readonly TextBox nameTextBox;
        private readonly Label typeLabel;
        private readonly Label valueLabel;
        private readonly NumericUpDown valueBox;
        // private readonly TextBox valueTextBox;

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

        private BinaryIntegerEntryControl(in int index, in Panel parent, in IBinaryEntry entry)
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
            valueBox = new NumericUpDown();
            panel.SuspendLayout();
            ((ISupportInitialize)valueBox).BeginInit();

            parent.Controls.Add(panel);

            panel.BackColor = SystemColors.ControlLightLight;
            panel.Controls.Add(indexLabel);
            panel.Controls.Add(nameLabel);
            panel.Controls.Add(nameTextBox);
            panel.Controls.Add(typeLabel);
            panel.Controls.Add(valueLabel);
            panel.Controls.Add(valueBox);
            panel.Location = BinaryEntryControlCreater.GetLocation(index, _parentPanel.AutoScrollPosition);
            panel.Name = "binaryNumberEntryPanel";
            panel.Size = BinaryEntryControlCreater.PanelSize;

            indexLabel.SetAsIndexLabel(index);
            nameLabel.SetAsNameLabel();
            nameTextBox.SetAsNameTextBox();
            typeLabel.SetAsTypeLabel(binaryEntry.Type);
            valueLabel.SetAsValueLabel();

            valueBox.Location = new Point(460, 10);
            valueBox.Name = "valueBox";
            valueBox.Size = BinaryEntryControlCreater.ValueBoxSize;
            switch (binaryEntry.Type)
            {
                case BinaryType.Byte:
                    valueBox.Minimum = byte.MinValue;
                    valueBox.Maximum = byte.MaxValue;
                    break;
                case BinaryType.Sbyte:
                    valueBox.Minimum = sbyte.MinValue;
                    valueBox.Maximum = sbyte.MaxValue;
                    break;
                case BinaryType.Short:
                    valueBox.Minimum = short.MinValue;
                    valueBox.Maximum = short.MaxValue;
                    break;
                case BinaryType.Ushort:
                    valueBox.Minimum = ushort.MinValue;
                    valueBox.Maximum = ushort.MaxValue;
                    break;
                case BinaryType.Int:
                    valueBox.Minimum = int.MinValue;
                    valueBox.Maximum = int.MaxValue;
                    break;
                case BinaryType.Uint:
                    valueBox.Minimum = uint.MinValue;
                    valueBox.Maximum = uint.MaxValue;
                    break;
                case BinaryType.Long:
                    valueBox.Minimum = long.MinValue;
                    valueBox.Maximum = long.MaxValue;
                    break;
                case BinaryType.Ulong:
                    valueBox.Minimum = ulong.MinValue;
                    valueBox.Maximum = ulong.MaxValue;
                    break;
                case BinaryType.Float:
                    valueBox.Minimum = new decimal(float.MinValue);
                    valueBox.Maximum = new decimal(float.MaxValue);
                    valueBox.Increment = new decimal(0.1f);
                    break;
                case BinaryType.Double:
                    valueBox.Minimum = new decimal(double.MinValue);
                    valueBox.Maximum = new decimal(double.MaxValue);
                    valueBox.Increment = new decimal(0.1);
                    break;
                case BinaryType.Decimal:
                    valueBox.Minimum = decimal.MinValue;
                    valueBox.Maximum = decimal.MaxValue;
                    valueBox.Increment = 0.1M;
                    break;
            }
            valueBox.ValueChanged += (sender, _) =>
            {
                binaryEntry.SetValue(valueBox.Value);
            };
            valueBox.Enabled = false;

            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((ISupportInitialize)valueBox).EndInit();
        }
    }
}
