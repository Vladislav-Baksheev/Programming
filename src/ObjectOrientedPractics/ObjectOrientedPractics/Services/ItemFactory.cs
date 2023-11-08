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

        private DataAPI dataAPI;

        private string _parametres = "CarBrand,CarModel,CarYear,CarColor";

        private Random _random = new Random();

        public ItemFactory()
        {
            dataAPI = new DataAPI(_parametres);
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <returns>Экземпляр класса <see cref="Item"/></returns>
        public Item CreateItem()
        {
            _item = JsonConvert.DeserializeObject<Item>(dataAPI.GetJsonData());
            _item.Cost = _random.Next(1, 99999);
            _item.Category = Category.Car;
            return _item;
        }
    }
}
