using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Enums;
using Programming.View;
namespace Programming.View.Controls
{
    public partial class SeasonHandleControl : UserControl
    {
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
                    MessageBox.Show("Ура, солнце!");
                    break;
                case 1:
                    SeasonGroupBox.BackColor = System.Drawing.Color.Yellow;
                    break;
                case 2:
                    SeasonGroupBox.BackColor = System.Drawing.Color.Green;
                    break;
                case 3:
                    MessageBox.Show("Брр, холодно!");
                    break;
            }
        }
    }
}
