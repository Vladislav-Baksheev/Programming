using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию о скидочных баллах.
    /// </summary>
    public class PointsDiscount
    {
        /// <summary>
        /// Кол-во скидочных баллов.
        /// </summary>
        private int _points;

        /// <summary>
        /// Возвращает и задает кол-во скидочных баллов.
        /// </summary>
        public int Points 
        { 
            get 
            { 
                return _points; 
            } 
            private set 
            { 
                if (value > 0)
                {
                    _points = value;
                }   
            } 
        }

        /// <summary>
        /// Возвращает информацию о кол-ве скидочных баллов и название скидки.
        /// </summary>
        public string Info { get => $"Накопительная - {Points} баллов"; }

        /// <summary>
        /// Инициализирует экземпляр класса <see cref="PointsDiscount"/>
        /// </summary>
        public PointsDiscount()
        {
            Points = 0;
        }

        /// <summary>
        /// Подсчитывает возможную скидку для списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки.</returns>
        public double Calculate(List<Item> items)
        {
            if(Points == 0)
            {
                return 0;
            }

            double sum = 0;

            foreach(var item in items)
            {
                sum += item.Cost;
            }

            int discountMaxSize = (int)sum / 100 * 30;

            if(Points >= discountMaxSize)
            {
                return discountMaxSize;
            }
            return Points;
        }

        /// <summary>
        /// Применяет скидки к товарам и списывает накопленные баллы.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки.</returns>
        public double Apply(List<Item> items)
        {
            double sum = 0;

            foreach (var item in items)
            {
                sum += item.Cost;
            }

            int discountMaxSize = (int)(sum / 100 * 30);

            if (Points >= discountMaxSize)
            {
                Points -= discountMaxSize;
                return discountMaxSize;
            }

            return 0;
        }

        /// <summary>
        /// Добавляет баллы на основе списка с товарами.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            double sum = 0;

            foreach (var item in items)
            {
                sum += item.Cost;
            }

            Points += (int)(sum / 100 * 10);
        }
    }
}
