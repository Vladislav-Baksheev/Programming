using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Cart
    {
        private List<Item> _items;

        /// <summary>
        /// Возвращает и задает товары в корзине.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Возвращает общую цену всех товаров.
        /// </summary>
        public double Amount
        {
            get
            {
                double sum = 0.0;

                if (Items.Count == 0 || Items == null)
                {
                    return 0.0;
                }
                foreach (var item in Items)
                {
                    sum += item.Cost;
                }

                return sum;
            }
        }

        /// <summary>
        /// Создает экземпляр объекта <see cref="Cart"/>.
        /// </summary>
        public Cart()
        {
            Items = new List<Item>();
        }
    }
}
