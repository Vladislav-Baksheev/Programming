namespace Programming.View.Controls
{
    /// <summary>
    /// Пользовательский интерфейс для работы с перечислениями.
    /// </summary>
    public partial class EnumerationControl : UserControl
    {
        /// <summary>
        /// Создает экземпляр класса <see cref="EnumerationControl"/>.
        /// </summary>
        public EnumerationControl()
        {
            InitializeComponent();
            EnumsListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueListBox.Items.Clear();

            Type type = Type.GetType($"Programming.Model.Enums.{EnumsListBox.SelectedItem}");

            var values = Enum.GetValues(type);

            foreach (var value in values)
            {
                ValueListBox.Items.Add(value);
            }

            IntValueTextBox.Text = "";
        }

        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Text = ((int)ValueListBox.SelectedItem).ToString();
        }
    }
}
