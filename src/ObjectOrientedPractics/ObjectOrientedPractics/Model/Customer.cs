using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателях.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Id покупателя.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Фамилия покупателя.
        /// </summary>
        private string _lastName = "";

        /// <summary>
        /// Имя покупателя.
        /// </summary>
        private string _firstName = "";

        /// <summary>
        /// Отчество покупателя.
        /// </summary>
        private string _fatherName = "";

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private string _address;

        /// <summary>
        /// Список скидок пользователя.
        /// </summary>
        public List<IDiscount> Discounts { get; set; } = new List<IDiscount>();

        /// <summary>
        /// Накопительная скидка.
        /// </summary>
        PointsDiscount pointsDiscount = new PointsDiscount();

        /// <summary>
        /// Возвращает и задает id покупателя.
        /// </summary>
        public int Id { get; set;}

        /// <summary>
        /// Приоритетный покупатель.
        /// </summary>
        public bool IsPriority { get; set; }

        /// <summary>
        /// Возвращает и задает фамилию покупателя.
        /// </summary>
        public string LastName
        {
            get 
            { 
                return _lastName; 
            }
            set
            {
                _lastName = value;
            }
        }

        /// <summary>
        /// Возвращает и задает имя покупателя.
        /// </summary>
        public string FirstName
        {
            get 
            { 
                return _firstName; 
            }
            set 
            { 
                _firstName = value; 
            }
        }

        /// <summary>
        /// Возвращает и задает отчество покупателя
        /// </summary>
        public string FatherName
        {
            get
            {
                return _fatherName;
            }
            set
            {
                _fatherName = value;
            }
        }

        /// <summary>
        /// Возвращает и задает полное имя покупателя.
        /// </summary>
        public string FullName
        {
            get
            {
                if (FirstName != "" || LastName != "" || FatherName != "")
                {
                    FullName = $"{LastName} {FirstName} {FatherName}";
                }
                return _fullname;
            }
            set
            {
                Validator.AssertStringOnLength(value, 200, nameof(value));
                _fullname = value;
            }
        }
        /// <summary>
        /// Возвращает и задает адрес пользователя.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Возвращает и задает корзину товаров покупателя. 
        /// </summary>
        public Cart Cart { get; set; }

        /// <summary>
        /// Возвращает и задает заказы покупателя.
        /// </summary>
        public List<Order> Orders { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Полное имя покупателя.</param>
        /// <param name="address">Адрес покупателя.</param>
        /// <param name="id">ID покупателя.</param>
        public Customer(string fullname, Address address, List<IDiscount> Discounts)
        {
            Id = IdGenerator.GetIdNext();
            FullName = fullname;
            Address = address;
            Cart = new Cart();
            Orders = new List<Order>();
            Discounts.Add(pointsDiscount);
        }
        public Customer()
        {
            Id = IdGenerator.GetIdNext();
            FullName = "None";
            Address = new Address();
            Cart = new Cart();
            Orders = new List<Order>();
            IsPriority = false; 
            Discounts.Add(pointsDiscount);
        }
    }
}
