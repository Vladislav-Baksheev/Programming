using Programming.Model.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = Programming.Model.Enums.Color;
using Rectangle = Programming.Model.Classes.Rectangle;

namespace Programming.View.Controls
{
    public partial class RectangleControl : UserControl
    {
        private Rectangle[] _rectangles;

        private Rectangle _currentRectangle;

        Random random = new Random();

        private string[] _colors;

        public RectangleControl()
        {
            InitializeComponent();

            _rectangles = new Rectangle[5];
            _colors = Enum.GetNames(typeof(Color));

            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Rectangle(random.Next(0, 1000), random.Next(0, 1000),
                                               _colors[random.Next(_colors.Length)]);

                RectanglesListBox.Items.Add(_rectangles[i].ToString());
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color.ToString();
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = Convert.ToDouble(LengthTextBox.Text);
                LengthTextBox.BackColor = AppColor.NormalBackColor;
            }
            catch (Exception ex)
            {
                LengthTextBox.BackColor = AppColor.ErrorBackColor;
            }

        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = Convert.ToDouble(WidthTextBox.Text);
                WidthTextBox.BackColor = AppColor.NormalBackColor;
            }
            catch (Exception ex)
            {
                WidthTextBox.BackColor = AppColor.ErrorBackColor;
            }

        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }

        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int index = 0;

            for (int i = 1; i < rectangles.Length; i++)
            {
                if (rectangles[i - 1].Width > rectangles[i].Width)
                {
                    index = i - 1;
                }
            }
            return index;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }
    }
}
