using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Classes;

namespace Programming.Model.Geometry
{
    public class Ring
    {
        public Point2D _point { get; set; }

        private double _innerRadius;

        private double _outerRadius;

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
            }
        }

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

        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(OuterRadius, 2) - Math.PI * Math.Pow(InnerRadius, 2);
            }
        }

        /// <summary>
        /// Возвращает и задает начальную точку построения.
        /// </summary>
        public Point2D Center { get; set; }

        public Ring(double inner, double outer)
        {
            InnerRadius = inner;
            OuterRadius = outer;
        }
    }
}
