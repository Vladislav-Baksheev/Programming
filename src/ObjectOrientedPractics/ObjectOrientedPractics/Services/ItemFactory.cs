using System;
using Newtonsoft.Json;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы для автоматического создания экземпляров объекта
    /// <see cref="Item"/>.
    /// </summary>
    class ItemFactory
    {
        /// <summary>
        /// Товар.
        /// </summary>
        private Item _item;

        private Random _random = new Random();

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <returns>Экземпляр класса <see cref="Item"/></returns>
        public Item CreateItem()
        {
            string[] items = {"хлеб","лук" };
            _item = new Item();
            _item.Name = items[_random.Next(items.Length)];
            _item.Cost = _random.Next(1, 99999);
            
            return _item;
        }
    }
}
