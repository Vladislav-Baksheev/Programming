using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private static int _allRectanglesCount = 0;

        private int _id;

        private double _length;
        private double _width;
        private string _color;

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value > 0)
                    _length = value;
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                    _width = value;
            }
        }

        public string Color { get; set; }

        public int Id
        {
            get => _id;
        }

        public Rectangle(double length, double width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
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

        public override string ToString()
        {
            return $"Rectangle {Id}";
        }
    }
}
