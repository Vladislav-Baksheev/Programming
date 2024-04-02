using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Classes;

namespace Programming.Model.Geometry
{
    public class Rectangle
    {
        private static int _allRectanglesCount = 0;

        private int _id;

        private int _length;
        private int _width;
        private string _color;

        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
        }

        public string Color { get; set; }

        public Point2D Center { get; set; }

        public int Id
        {
            get => _id;
        }

        public Rectangle(int length, int width, string color, int xCenter, int yCenter)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = new Point2D(xCenter, yCenter);
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        public Rectangle()
        {
            Length = 0;
            Width = 0;
            Color = string.Empty;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }
        public string GetRectangleInfo()
        {
            return $"{Id}: (X={Center.X}; Y={Center.Y}; W={Width}; H={Length})";
        }
        public override string ToString()
        {
            return $"Rectangle {Id}";
        }
    }
}
