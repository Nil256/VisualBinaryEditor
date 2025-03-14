namespace VisualBinaryEditor.BinaryEntries
{
    internal interface INumericUpDownValueConverter
    {
        public decimal GetValue();
        public void SetValue(in decimal value);
    }
}
