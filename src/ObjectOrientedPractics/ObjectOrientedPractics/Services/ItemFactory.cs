using System;
using Newtonsoft.Json;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    class ItemFactory
    {
        private Item _item;
        private Random _random = new Random();
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
