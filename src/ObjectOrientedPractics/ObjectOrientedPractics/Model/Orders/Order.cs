using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Model.Enums;
namespace ObjectOrientedPractics.Model.Orders
{
    public class Order : IEquatable<Order>
    {
        /// <summary>
        /// Возвращает ID заказа.
        /// </summary>
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
        /// Сумма скидок.
        /// </summary>
        public double DiscountAmount { get; set; }

        /// <summary>
        /// Возвращает стоимость заказа после применения скидок.
        /// </summary>
        public double Total 
        {
            get
            {
                return TotalCost - DiscountAmount;
            }
        }

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

                return sum - DiscountAmount;
            }
        }

        public Order()
        {
            Id = IdGenerator.GetIdNext();
            Items = new List<Item>();
            OrderStatus = OrderStatus.New;
            OrderCreationDate = DateTime.Now.ToString();
        }

        public bool Equals(Order other)
        {
            if (other == null)
                return false;

            if (!(other is Order))
                return false;

            if (object.ReferenceEquals(this, other))
                return true;

            var order2 = (Order)other;

            return (this.Id == order2.Id);
        }
    }
}
