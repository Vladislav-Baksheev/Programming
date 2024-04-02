using Programming.Model.Enums;
using Programming.Model.Classes;
using Rectangle = Programming.Model.Geometry.Rectangle;
using Programming.Model.Geometry;

namespace Programming.View.Controls
{
    public partial class RectangleCollisionControl : UserControl
    {
        public RectangleCollisionControl()
        {
            InitializeComponent();
        }

        private List<Rectangle> _rectangles = new List<Rectangle>();

        private Rectangle _currentRectangle;

        public Random random = new Random();

        private List<Panel> _rectanglePanels = new List<Panel>();

        private int _currentIndexRectangle;

        private void AddButton_Click(object sender, EventArgs e)
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

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex != -1)
            {
                _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
                _currentIndexRectangle = RectanglesListBox.SelectedIndex;
                UpdateRectangleInfo();
            }
        }
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
        public void ClearRectangleInfo()
        {
            IDTextBox.Clear();
            XTextBox.Clear();
            YTextBox.Clear();
            WidthTextBox.Clear();
            HeightTextBox.Clear();
        }
        private void UpdateRectangleInfo()
        {
            IDTextBox.Text = _currentRectangle.Id.ToString();
            HeightTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            XTextBox.Text = _currentRectangle.Center.X.ToString();
            YTextBox.Text = _currentRectangle.Center.Y.ToString();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
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

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {

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
    }
}
