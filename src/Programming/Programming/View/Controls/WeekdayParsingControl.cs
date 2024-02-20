using Programming.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string text = ParseTextBox.Text;

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
