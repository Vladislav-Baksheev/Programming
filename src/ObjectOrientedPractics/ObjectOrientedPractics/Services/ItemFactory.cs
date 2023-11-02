using System;
using Newtonsoft.Json;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    class ItemFactory
    {
        private Item _item;

        public Item CreateItem()
        {
            Random random = new Random();
            string[] items = {"хлеб","лук" };
            _item = new Item();
            _item.Name = items[random.Next(items.Length)];
            _item.Cost = random.Next(1, 99999);
            
            return _item;
        }
    }
}
