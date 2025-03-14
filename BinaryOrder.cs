using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using VisualBinaryEditor.BinaryEntries;

namespace VisualBinaryEditor
{
    internal class BinaryOrder
    {
        private readonly Panel _parentPanel;
        private readonly List<IBinaryEntryControl> _controls;

        private int _selectedEntryIndex;
        private int SelectedEntryIndex
        {
            get
            {
                return _selectedEntryIndex;
            }
            set
            {
                Select(value);
                Main.Debug(_selectedEntryIndex.ToString());
            }
        }

        internal BinaryOrder(in Panel parent)
        {
            _parentPanel = parent;
            _controls = new List<IBinaryEntryControl>();
            SelectedEntryIndex = -1;
        }

        private void Select(in int index, bool forced = false)
        {
            if (_selectedEntryIndex == index && !forced)
            {
                return;
            }
            if (0 <= _selectedEntryIndex && _selectedEntryIndex < _controls.Count)
            {
                _controls[_selectedEntryIndex].Selected = false;
            }
            _selectedEntryIndex = index;
            if (0 <= _selectedEntryIndex && _selectedEntryIndex < _controls.Count)
            {
                _controls[_selectedEntryIndex].Selected = true;
            }
        }

        internal void Add(in BinaryType type)
        {
            int index = SelectedEntryIndex + 1;
            IBinaryEntryControl control;
            switch (type)
            {
                case BinaryType.Bool:
                    control = BinaryBoolEntryControl.Create(index, _parentPanel);
                    break;
                case BinaryType.Byte:
                    control = BinaryIntegerEntryControl.CreateByte(index, _parentPanel);
                    break;
                case BinaryType.Sbyte:
                    control = BinaryIntegerEntryControl.CreateSbyte(index, _parentPanel);
                    break;
                case BinaryType.Short:
                    control = BinaryIntegerEntryControl.CreateShort(index, _parentPanel);
                    break;
                case BinaryType.Ushort:
                    control = BinaryIntegerEntryControl.CreateUshort(index, _parentPanel);
                    break;
                case BinaryType.Int:
                    control = BinaryIntegerEntryControl.CreateInt(index, _parentPanel);
                    break;
                case BinaryType.Uint:
                    control = BinaryIntegerEntryControl.CreateUint(index, _parentPanel);
                    break;
                case BinaryType.Long:
                    control = BinaryIntegerEntryControl.CreateLong(index, _parentPanel);
                    break;
                case BinaryType.Ulong:
                    control = BinaryIntegerEntryControl.CreateUlong(index, _parentPanel);
                    break;
                default:
                    return;
            }
            control.Click += (_, _) =>
            {
                SelectedEntryIndex = control.Index;
            };
            _controls.Insert(index, control);
            UpdateEntryIndexes();
            SelectedEntryIndex = index;
            _parentPanel.ScrollControlIntoView(control.Control);
        }

        internal void MoveUp()
        {
            if (SelectedEntryIndex <= 0)
            {
                return;
            }
            int swappedIndex = SelectedEntryIndex - 1;
            IBinaryEntryControl swappedControl = _controls[swappedIndex];
            _controls[swappedIndex] = _controls[SelectedEntryIndex];
            _controls[SelectedEntryIndex] = swappedControl;
            UpdateEntryIndexes();
            SelectedEntryIndex = swappedIndex;
        }

        internal void MoveDown()
        {
            if (SelectedEntryIndex >= _controls.Count - 1)
            {
                return;
            }
            int swappedIndex = SelectedEntryIndex + 1;
            IBinaryEntryControl swappedControl = _controls[swappedIndex];
            _controls[swappedIndex] = _controls[SelectedEntryIndex];
            _controls[SelectedEntryIndex] = swappedControl;
            UpdateEntryIndexes();
            SelectedEntryIndex = swappedIndex;
        }

        internal void Remove()
        {
            if (SelectedEntryIndex < 0 || _controls.Count <= SelectedEntryIndex)
            {
                return;
            }
            IBinaryEntryControl control = _controls[SelectedEntryIndex];
            _controls.Remove(control);
            _parentPanel.Controls.Remove(control.Control);
            UpdateEntryIndexes();
            if (SelectedEntryIndex > _controls.Count - 1)
            {
                SelectedEntryIndex = _controls.Count - 1;
            }
            else
            {
                Select(_selectedEntryIndex, true);
            }
        }

        private void UpdateEntryIndexes()
        {
            List<IBinaryEntryControl> controls = _controls;
            for (var i = 0; i < controls.Count; i++)
            {
                IBinaryEntryControl control = controls[i];
                control.Index = i;
            }
        }

        internal bool CanExportBinary()
        {
            return _controls.Count > 0;
        }

        internal void ExportBinary(in BinaryWriter writer)
        {
            List<IBinaryEntryControl> controls = _controls;
            for (var i = 0; i < controls.Count; i++)
            {
                IBinaryEntryControl control = controls[i];
                IBinaryEntry entry = control.Entry;
                entry.Write(writer);
            }
        }
    }
}
