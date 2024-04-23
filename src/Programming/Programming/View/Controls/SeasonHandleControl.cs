using Programming.Model.Enums;
namespace Programming.View.Controls
{
    /// <summary>
    /// Пользовательский интерфейс для работы с временами года.
    /// </summary>
    public partial class SeasonHandleControl : UserControl
    {
        /// <summary>
        /// Создает экземпляр класса <see cref="SeasonHandleControl"/>.
        /// </summary>
        public SeasonHandleControl()
        {
            InitializeComponent();
            Array values = Enum.GetValues(typeof(Season));
            foreach (var value in values)
            {
                SeasonComboBox.Items.Add(value.ToString());
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (SeasonComboBox.SelectedIndex)
            {
                case 0:
                    {
                        MessageBox.Show("Ура, солнце!");
                        break;
                    }
                case 1:
                    {
                        SeasonGroupBox.BackColor = System.Drawing.Color.Yellow;
                        break;
                    }     
                case 2:
                    {
                        SeasonGroupBox.BackColor = System.Drawing.Color.Green;
                        break;
                    }     
                case 3:
                    {
                        MessageBox.Show("Брр, холодно!");
                        break;
                    } 
            }
        }
    }
}
