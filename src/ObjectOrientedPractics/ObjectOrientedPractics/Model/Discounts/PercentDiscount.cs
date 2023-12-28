using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enums;
namespace ObjectOrientedPractics.Model.Discounts
{
    public class PercentDiscount : IDiscount
    {
        /// <summary>
        /// Текущая скидка.
        /// </summary>
        double _currentDiscount = 0.01;

        /// <summary>
        /// Максимальная скидка.
        /// </summary>
        double _maxDiscount = 0.1;

        /// <summary>
        /// Cуммa денег потраченная на товары.
        /// определенной категории.
        /// </summary>
        private double _totalSpent;

        /// <summary>
        /// Категория товара.
        /// </summary>
        Category Category { get; set; }

        /// <summary>
        /// Возвращает и задает кол-во скидочных баллов.
        /// </summary>
        public double CurrentDiscount
        {
            get
            {
                return _currentDiscount;
            }
            private set
            {
                if (value > 0)
                {
                    _currentDiscount = value;
                }
            }
        }

        /// <summary>
        /// Возвращает информацию о кол-ве скидочных баллов и название скидки.
        /// </summary>
        public string Info { get => $"Процентная {Category} - {CurrentDiscount * 100}%"; }

        /// <summary>
        /// Инициализирует экземпляр класса <see cref="PointsDiscount"/>
        /// </summary>
        public PercentDiscount(Category category)
        {
            Category = category;
        }
        
        /// <summary>
        /// Возвращает и задает сумму денег потраченную на товары.
        /// определенной категории.
        /// </summary>
        public double TotalSpent
        {
            get
            {
                return _totalSpent;
            }
            private set
            {
                _totalSpent = value;
            }
        }

        /// <summary>
        /// Подсчитывает возможную скидку для списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки.</returns>
        public double Calculate(List<Item> items)
        {
            double sumCost = 0;

            foreach (var item in items)
            {
                if (item.Category == Category)
                {
                    sumCost += item.Cost;
                }
            }

            return sumCost * CurrentDiscount;
        }

        /// <summary>
        /// Применяет скидки к товарам и списывает накопленные баллы.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки.</returns>
        public double Apply(List<Item> items)
        {
            double sumCost = 0;

            foreach (var item in items)
            {
                if (item.Category == Category)
                {
                    sumCost += item.Cost;
                }
            }

            return sumCost * CurrentDiscount;
        }

        /// <summary>
        /// Добавляет баллы на основе списка с товарами.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            foreach (var item in items)
            {
                TotalSpent += item.Cost;
            }

            if (_currentDiscount < _maxDiscount)
            {
                double discount = Math.Truncate(TotalSpent / 1000) / 100;

                if (_maxDiscount - _currentDiscount >= discount)
                {
                    _currentDiscount = discount;
                }
                else
                {
                    _currentDiscount += _maxDiscount - _currentDiscount;
                }
            }
        }
    }
}

