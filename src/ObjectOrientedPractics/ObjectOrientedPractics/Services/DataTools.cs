using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Реализует методы по обработке данных.
    /// </summary>
    public static class DataTools
    {
        /// <summary>
        /// Делегат критерия сортировки.
        /// </summary>
        /// <param name="firstItem">Первый товар.</param>
        /// <param name="secondItem">Следующий товар.</param>
        public delegate bool CompareItems(Item firstItem, Item secondItem);

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

        /// <summary>
        /// Сортирует товары.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="sorter">Делегат для методов сортировки.</param>
        public static List<Item> Sorter(List<Item> items, CompareItems compare)
        {
            List<Item> newItems = new List<Item>(items);

            for (int i = 0; i < newItems.Count; i++)
            {
                for (int j = 1; j < newItems.Count; j++)
                {
                    if (compare(newItems[j], newItems[j - 1]))
                    {
                        Item temp = newItems[j];
                        newItems[j] = newItems[j - 1];
                        newItems[j - 1] = temp;
                    }
                }
            }

            return newItems;
        }
    }
}
