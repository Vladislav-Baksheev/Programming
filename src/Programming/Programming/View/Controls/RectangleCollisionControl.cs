using Programming.Model.Classes;
using Rectangle = Programming.Model.Geometry.Rectangle;
using Programming.Model.Geometry;

namespace Programming.View.Controls
{
    /// <summary>
    /// Пользовательский интерфейс для рисования прямоугольников.
    /// </summary>
    public partial class RectangleCollisionControl : UserControl
    {
        /// <summary>
        /// Список объектов класса <see cref="Rectangle"/>.
        /// </summary>
        private List<Rectangle> _rectangles = new List<Rectangle>();

        /// <summary>
        /// Выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle { get; set; }

        /// <summary>
        /// Экземпляр класса <see cref="Random"/>, для случайной генерации прямоугольника.
        /// </summary>
        public Random random = new Random();

        /// <summary>
        /// Список объектов класса <see cref="Panel"/>.
        /// </summary>
        private List<Panel> _rectanglePanels = new List<Panel>();

        /// <summary>
        /// Индекс выбранного прямоугольника.
        /// </summary>
        private int _currentIndexRectangle;

        /// <summary>
        /// Создает экземпляр класса <see cref="RectangleCollisionControl"/>.
        /// </summary>
        public RectangleCollisionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Находит пересекающиеся прямоугольники и перекрашивает их.
        /// </summary>
        public void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                RectanglesPanel.Controls[i].BackColor = AppColor.NotCollision;
                _rectangles[i].Color = "Green";
            }

            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectangles[i].Color = "Red";
                        _rectangles[j].Color = "Red";

                        RectanglesPanel.Controls[i].BackColor = AppColor.Collision;
                        RectanglesPanel.Controls[j].BackColor = AppColor.Collision;
                    }
                }
            }
        }

        /// <summary>
        /// Очищает все TextBoxes.
        /// </summary>
        public void ClearRectangleInfo()
        {
            IDTextBox.Clear();
            XTextBox.Clear();
            YTextBox.Clear();
            WidthTextBox.Clear();
            HeightTextBox.Clear();
        }

        /// <summary>
        /// Обновляет информацию в TextBoxes.
        /// </summary>
        private void UpdateRectangleInfo()
        {
            IDTextBox.Text = _currentRectangle.Id.ToString();
            HeightTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            XTextBox.Text = _currentRectangle.Center.X.ToString();
            YTextBox.Text = _currentRectangle.Center.Y.ToString();
        }
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex != -1)
            {
                _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
                _currentIndexRectangle = RectanglesListBox.SelectedIndex;
                UpdateRectangleInfo();
            }
        }

        private void XTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Center.X = int.Parse(XTextBox.Text);
                XTextBox.BackColor = AppColor.NormalBackColor;
                RectanglesPanel.Controls[_currentIndexRectangle].Location = new Point(_currentRectangle.Center.X,
                                                                              _currentRectangle.Center.Y);

                FindCollisions();
                UpdateRectangleInfo();
            }
            catch
            {
                if (RectanglesListBox.Items.Count != 0)
                {
                    XTextBox.BackColor = AppColor.ErrorBackColor;
                }
            }
        }

        private void YTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Center.Y = int.Parse(YTextBox.Text);
                YTextBox.BackColor = AppColor.NormalBackColor;
                RectanglesPanel.Controls[_currentIndexRectangle].Location = new Point(_currentRectangle.Center.X,
                                                                              _currentRectangle.Center.Y);

                FindCollisions();
                UpdateRectangleInfo();
            }
            catch
            {
                if (RectanglesListBox.Items.Count != 0)
                {
                    XTextBox.BackColor = AppColor.ErrorBackColor;
                }
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = int.Parse(WidthTextBox.Text);
                WidthTextBox.BackColor = AppColor.NormalBackColor;
                RectanglesPanel.Controls[_currentIndexRectangle].Height = _currentRectangle.Width;

                FindCollisions();
                UpdateRectangleInfo();
            }
            catch
            {
                if (RectanglesListBox.Items.Count != 0)
                {
                    WidthTextBox.BackColor = AppColor.ErrorBackColor;
                }
            }
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = int.Parse(HeightTextBox.Text);
                HeightTextBox.BackColor = AppColor.NormalBackColor;
                RectanglesPanel.Controls[_currentIndexRectangle].Width = _currentRectangle.Length;

                FindCollisions();
                UpdateRectangleInfo();
            }
            catch
            {
                if (RectanglesListBox.Items.Count != 0)
                {
                    HeightTextBox.BackColor = AppColor.ErrorBackColor;
                }
            }
        }

        private void AddButtonPictureBox_Click(object sender, EventArgs e)
        {
            Rectangle newRectangle = new(random.Next(0, 1000),
                                      random.Next(0, 1000),
                                      "White",
                                      random.Next(0, 100),
                                      random.Next(0, 100));
            var newPanel = new Panel
            {
                Height = newRectangle.Width,
                Width = newRectangle.Length,
                Location = new Point(newRectangle.Center.X, newRectangle.Center.Y),
                BackColor = AppColor.NotCollision
            };

            _rectangles.Add(newRectangle);
            _rectanglePanels.Add(newPanel);
            RectanglesListBox.Items.Clear();

            for (int i = 0; i < _rectangles.Count; i++)
            {
                RectanglesListBox.Items.Add(_rectangles[i].GetRectangleInfo());
                RectanglesPanel.Controls.Add(newPanel);
            }

            RectanglesListBox.SelectedIndex = _rectangles.Count - 1;

            FindCollisions();
        }

        private void RemoveButtonPictureBox_Click(object sender, EventArgs e)
        {
            if (_rectangles.Count > 0)
            {
                RectanglesListBox.Items.RemoveAt(RectanglesListBox.SelectedIndex);
                _rectangles.RemoveAt(_currentIndexRectangle);
                RectanglesPanel.Controls.RemoveAt(_currentIndexRectangle);
                _rectanglePanels.RemoveAt(_currentIndexRectangle);
                RectanglesListBox.SelectedIndex = _rectangles.Count > 0 ? 0 : -1;

                UpdateRectangleInfo();
            }

            if (_rectangles.Count == 0)
            {
                ClearRectangleInfo();
            }

            FindCollisions();
        }

        private void AddButtonPictureBox_MouseEnter(object sender, EventArgs e)
        {
            AddButtonPictureBox.Image = Properties.Resources.rectangle_add_24x24;
        }

        private void AddButtonPictureBox_MouseLeave(object sender, EventArgs e)
        {
            AddButtonPictureBox.Image = Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void RemoveButtonPictureBox_MouseEnter(object sender, EventArgs e)
        {
            RemoveButtonPictureBox.Image = Properties.Resources.rectangle_remove_24x24;
        }

        private void RemoveButtonPictureBox_MouseLeave(object sender, EventArgs e)
        {
            RemoveButtonPictureBox.Image = Properties.Resources.rectangle_remove_24x24_uncolor;
        }
    }
}
