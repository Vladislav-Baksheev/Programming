using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Services;

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

        private string _lastName = "";

        private string _firstName = "";

        private string _fatherName = "";

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private string _address;

        /// <summary>
        /// Возвращает и задает id покупателя.
        /// </summary>
        public int Id { get; set;}

        /// <summary>
        /// Возвращает и задает полное имя покупателя.
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
        public Customer(string fullname, Address address)
        {
            Id = IdGenerator.GetIdNext();
            FullName = fullname;
            Address = address;
        }
        public Customer()
        {
            Id = IdGenerator.GetIdNext();
            FullName = "None";
            Address = new Address();
            Cart = new Cart();
        }
    }
}
