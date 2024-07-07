using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Реализует методы по обработке данных.
    /// </summary>
    public static class DataTools
    {
        /// <summary>
        /// Сравнение двух цен для фильтрации товаров.
        /// </summary>
        public static bool CompareCost(Item item)
        {
            return item.Cost > 5000;
        }

        /// <summary>
        /// Сравнение двух категорий для фильтрации товаров.
        /// </summary>
        public static bool CompareCategory(Item item)
        {    
            return Convert.ToInt32(item.Category) == Convert.ToInt32(Category.None);
        }

        /// <summary>
        /// Фильтрует товары.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="filter">Делегат для методов фильтрации.</param>
        /// <returns></returns>
        public static List<Item> Filter(List<Item> items, Func<Item, bool> filter)
        {
            List<Item> newItems = new List<Item>();

            foreach (var item in items) 
            { 
                if (filter(item))
                    newItems.Add(item);
            }

            return newItems;
        }
    }
}
