using Programming.Model.Classes;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о точке.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Координата х.
        /// </summary>
        private int _x;

        /// <summary>
        /// Координата у.
        /// </summary>
        private int _y;

        /// <summary>
        /// Возвращает и задает координату x.
        /// </summary>
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(X));
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задает координату у.
        /// </summary>
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Y));
                _y = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Point2D"/>
        /// </summary>
        public Point2D()
        {
            X = 0;
            Y = 0;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Point2D"/>
        /// </summary>
        /// <param name="x">Координата х.</param>
        /// <param name="y">Координата у.</param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
