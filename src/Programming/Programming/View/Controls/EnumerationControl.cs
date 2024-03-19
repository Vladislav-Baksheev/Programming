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
    public partial class EnumerationControl : UserControl
    {
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
