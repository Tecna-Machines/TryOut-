namespace Views.Utilities
{
    internal class TextBoxUtility
    {
        public static void LimpiarTextBox(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Clear();
            }
        }
    }
}
