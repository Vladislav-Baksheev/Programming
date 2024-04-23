using Programming.Model.Enums;

namespace Programming.View.Controls
{
    /// <summary>
    /// Пользовательский интерфейс для работы с днями недели.
    /// </summary>
    public partial class WeekdayParsingControl : UserControl
    {
        /// <summary>
        /// Создает экземпляр класса <see cref="WeekdayParsingControl"/>.
        /// </summary>
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            var text = ParseTextBox.Text;

            if (Enum.TryParse(text, out Weekday weekday))
            {
                WeekdayLabel.Text = $"Это день недели ({text} = {(int)weekday})";
            }
            else
            {
                WeekdayLabel.Text = "Нет такого дня недели";
            }
        }
    }
}
