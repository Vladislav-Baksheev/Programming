using Programming.Model.Classes;
using Color = Programming.Model.Enums.Color;
using Rectangle = Programming.Model.Geometry.Rectangle;

namespace Programming.View.Controls
{
    /// <summary>
    /// Пользовательский интерфейс для создания и работы с прямоугольниками.
    /// </summary>
    public partial class RectangleControl : UserControl
    {
        /// <summary>
        /// Минимальное количество символов в TextBoxes.
        /// </summary>
        private readonly int _min = 0;

        /// <summary>
        /// Максимальное количество символов в TextBoxes.
        /// </summary>
        private readonly int _max = 999;

        /// <summary>
        /// Список объектов класса <see cref="Rectangle"/>.
        /// </summary>
        private Rectangle[] _rectangles { get; set; }

        /// <summary>
        /// Текущий прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Экземпляр класса <see cref="Random"/>, создающий случайную генерацию прямоугольника.
        /// </summary>
        Random random = new Random();

        /// <summary>
        /// Массив цветов.
        /// </summary>
        private string[] _colors;

        /// <summary>
        /// Создает экземпляр класса <see cref="RectangleControl"/>.
        /// </summary>
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

        /// <summary>
        /// Ищет прямоугольник с максимальной шириной.
        /// </summary>
        /// <param name="rectangles">Массив прямоугольников.</param>
        /// <returns>Индекс прямоугольника с максимальной шириной.</returns>
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
                _currentRectangle.Length = Convert.ToInt32(LengthTextBox.Text);
                Validator.AssertValueInRange(_currentRectangle.Length, _min, _max, nameof(LengthTextBox));
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
                _currentRectangle.Width = Convert.ToInt32(WidthTextBox.Text);
                Validator.AssertValueInRange(_currentRectangle.Width, _min, _max, nameof(WidthTextBox));
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
