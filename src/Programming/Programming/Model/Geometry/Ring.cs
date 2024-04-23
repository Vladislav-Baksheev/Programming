using Programming.Model.Classes;

namespace Programming.Model.Geometry
{
    public class Ring
    {
        /// <summary>
        /// Внутренний радиус.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Внешний радиус.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Возвращает и задает внутренний радиус.
        /// </summary>
        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(_innerRadius, nameof(InnerRadius));
                Validator.AssertOnBiggerValue(_innerRadius, _outerRadius, nameof(OuterRadius));
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задает внешний радиус.
        /// </summary>
        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(_outerRadius, nameof(OuterRadius));
                Validator.AssertOnBiggerValue(_innerRadius, _outerRadius, nameof(OuterRadius));
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает площадь.
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(OuterRadius, 2) - Math.PI * Math.Pow(InnerRadius, 2);
            }
        }

        /// <summary>
        /// Возвращает и задает центральную точку.
        /// </summary>
        public Point2D Point { get; set; }

        /// <summary>
        /// Возвращает и задает начальную точку построения.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Ring"/>
        /// </summary>
        /// <param name="inner">Внутренний радиус.</param>
        /// <param name="outer">Внешний радиус.</param>
        public Ring(double inner, double outer)
        {
            InnerRadius = inner;
            OuterRadius = outer;
        }
    }
}
