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
                                               _colors[random.Next(_colors.Length)], random.Next(0, 100), random.Next(0, 100));

                RectanglesListBox.Items.Add(_rectangles[i].ToString());
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            IDTextBox.Text = _currentRectangle.Id.ToString();
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color.ToString();
            XTextBox.Text = _currentRectangle.Center.X.ToString();
            YTextBox.Text = _currentRectangle.Center.Y.ToString();
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
            int indexMaxWidth = 0;
            double maxWidth = 0;

            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    indexMaxWidth = i;
                }
            }

            return indexMaxWidth;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        private void XTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void YTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
