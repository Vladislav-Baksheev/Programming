using System.Collections.Generic;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Реализует методы по обработке данных.
    /// </summary>
    public class DataTools
    {
        /// <summary>
        /// Фильтрует товары с ценой выше 5000.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Новый список товаров.</returns>
        public List<Item> FilterByCost(List<Item> items)
        {
            List<Item> newItems = new List<Item>();

            foreach (var item in items) 
            { 
                if(item.Cost > 5000)
                    newItems.Add(item);
            }

            return newItems;
        }

        /// <summary>
        /// Фильтрует товары по первой категории.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Новый список товаров.</returns>
        public List<Item> FilterByCategory(List<Item> items)
        {
            List<Item> newItems = new List<Item>();

            foreach (var item in items)
            {
                if (item.Category == Category.None)
                    newItems.Add(item);
            }

            return newItems;
        }
    }
}
