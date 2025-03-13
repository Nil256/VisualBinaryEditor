using System.Collections.Generic;
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
                if (0 <= _selectedEntryIndex && _selectedEntryIndex < _controls.Count)
                {
                    _controls[_selectedEntryIndex].Selected = false;
                }
                _selectedEntryIndex = value;
                if (0 <= _selectedEntryIndex && _selectedEntryIndex < _controls.Count)
                {
                    _controls[_selectedEntryIndex].Selected = true;
                }
                Main.Debug(_selectedEntryIndex.ToString());
            }
        }

        internal BinaryOrder(in Panel parent)
        {
            _parentPanel = parent;
            _controls = new List<IBinaryEntryControl>();
            SelectedEntryIndex = -1;
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

        internal void Remove()
        {
            if (SelectedEntryIndex < 0 || _controls.Count <= SelectedEntryIndex)
            {
                return;
            }
            IBinaryEntryControl control = _controls[SelectedEntryIndex];
            _controls.Remove(control);
            _parentPanel.Controls.Remove(control.Control);
            SelectedEntryIndex = _selectedEntryIndex;
            if (SelectedEntryIndex >= _controls.Count)
            {
                SelectedEntryIndex = _controls.Count - 1;
            }
            UpdateEntryIndexes();
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
    }
}
