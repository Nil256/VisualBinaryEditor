using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

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
                _parentPanel.ScrollControlIntoView(_controls[_selectedEntryIndex].Control);
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

        internal void MoveToTop()
        {
            if (SelectedEntryIndex <= 0)
            {
                return;
            }
            IBinaryEntryControl selectedControl = _controls[SelectedEntryIndex];
            for (var i = SelectedEntryIndex - 1; i >= 0; i--)
            {
                _controls[i + 1] = _controls[i];
            }
            _controls[0] = selectedControl;
            UpdateEntryIndexes();
            SelectedEntryIndex = 0;
        }

        internal void MoveUp()
        {
            if (SelectedEntryIndex <= 0)
            {
                return;
            }
            SelectedEntryIndex = SwapEntries(SelectedEntryIndex - 1);
        }

        internal void MoveDown()
        {
            if (SelectedEntryIndex >= _controls.Count - 1)
            {
                return;
            }
            SelectedEntryIndex = SwapEntries(SelectedEntryIndex + 1);
        }

        internal void MoveToBottom()
        {
            if (SelectedEntryIndex >= _controls.Count - 1)
            {
                return;
            }
            // SelectedEntryIndex = SwapEntries(_controls.Count - 1);
            IBinaryEntryControl selectedControl = _controls[SelectedEntryIndex];
            for (var i = SelectedEntryIndex; i < _controls.Count - 1; i++)
            {
                _controls[i] = _controls[i + 1];
            }
            _controls[_controls.Count - 1] = selectedControl;
            UpdateEntryIndexes();
            SelectedEntryIndex = _controls.Count - 1;
        }

        private int SwapEntries(int targetIndex)
        {
            IBinaryEntryControl swappedControl = _controls[targetIndex];
            _controls[targetIndex] = _controls[SelectedEntryIndex];
            _controls[SelectedEntryIndex] = swappedControl;
            UpdateEntryIndexes();
            return targetIndex;
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

        internal void Clear()
        {
            List<IBinaryEntryControl> controls = _controls;
            for (var i = 0; i < controls.Count; i++)
            {
                IBinaryEntryControl control = controls[i];
                _parentPanel.Controls.Remove(control.Control);
            }
            _controls.Clear();
            SelectedEntryIndex = -1;
        }

        internal bool CanImportBinary()
        {
            return _controls.Count > 0;
        }

        internal void ImportBinary(in BinaryReader reader)
        {
            List<IBinaryEntryControl> controls = _controls;
            for (var i = 0; i < controls.Count; i++)
            {
                IBinaryEntryControl control = controls[i];
                control.Read(reader);
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
                control.Write(writer);
            }
        }
    }
}
