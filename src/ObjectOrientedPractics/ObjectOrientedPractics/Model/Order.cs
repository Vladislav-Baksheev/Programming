using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Order
    {
        public int Id { get; }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public string OrderCreationDate { get; }

        /// <summary>
        /// Возвращает и задает статус заказа.
        /// </summary>
        public OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// Возвращает и задает адрес доставки заказа.
        /// </summary>
        public Address DeliveryAddress { get; set; }

        /// <summary>
        /// Возвращает и задает список товаров заказа.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Возвращает общую стоимость заказа.
        /// </summary>
        public double TotalCost
        {
            get
            {
                double sum = 0.0;

                if (Items.Count == 0)
                {
                    return sum;
                }

                foreach (var item in Items)
                {
                    sum += item.Cost;
                }

                return sum;
            }
        }

        public Order()
        {
            Id = IdGenerator.GetIdNext();
            Items = new List<Item>();
            OrderStatus = OrderStatus.New;
            OrderCreationDate = DateTime.Now.ToString();
        }

    }
}
