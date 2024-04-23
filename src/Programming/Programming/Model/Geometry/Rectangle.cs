using Programming.Model.Classes;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о прямоугольнике.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Длина прямоугольника.
        /// </summary>
        private int _length;

        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private int _width;

        /// <summary>
        /// Цвет прямоугольника.
        /// </summary>
        private string _color;

        /// <summary>
        /// Возвращает и задает длину прямоугольника.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает ширину прямоугольника.
        /// </summary>
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

        /// <summary>
        /// Возвращает количество всех прямоугольников.
        /// </summary>
        public static int AllRectanglesCount{ get; set;}

        /// <summary>
        /// Возвращает и задает цвет прямоугольника.
        /// </summary>
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Color));
                _color = value;
            }
        }

        /// <summary>
        /// Возвращает и задает центральную точку.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает ID прямоугольника.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>
        /// </summary>
        /// <param name="length">Длина прямоугольника.</param>
        /// <param name="width">Ширина прямоугольника.</param>
        /// <param name="color">Цвет прямоугольника.</param>
        /// <param name="xCenter">Центральная точка Х.</param>
        /// <param name="yCenter">Центральная точка Y.</param>
        public Rectangle(int length, 
            int width, 
            string color, 
            int xCenter, 
            int yCenter)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = new Point2D(xCenter, yCenter);
            AllRectanglesCount++;
            Id = AllRectanglesCount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>
        /// </summary>
        public Rectangle()
        {
            Length = 0;
            Width = 0;
            Color = string.Empty;
            AllRectanglesCount++;
            Id = AllRectanglesCount;
        }

        /// <summary>
        /// Получает информацию о прямоугольнике.
        /// </summary>
        /// <returns>Строка "{Id}: (X={Center.X}; Y={Center.Y}; W={Width}; H={Length})"</returns>
        public string GetRectangleInfo()
        {
            return $"{Id}: (X={Center.X}; Y={Center.Y}; W={Width}; H={Length})";
        }

        /// <summary>
        /// Возвращает строку по заданному шаблону.
        /// </summary>
        /// <returns>Строка "Rectangle {Id}"</returns>
        public override string ToString()
        {
            return $"Rectangle {Id}";
        }
    }
}
