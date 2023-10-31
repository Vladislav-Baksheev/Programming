using System;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателях
    /// </summary>
    internal class Customer
    {
        /// <summary>
        /// Id покупателя
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес доставки
        /// </summary>
        private string _address;

        /// <summary>
        /// Возвращает и задает id покупателя
        /// </summary>
        public int Id { get; set;}

        /// <summary>
        /// Возвращает и задает полное имя покупателя
        /// </summary>
        public string FullName 
        {
            get 
            { 
                return _fullname;
            }
            set
            {
                Validator.AssertStringOnLength(value, 200, nameof(value));
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес покупателя
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                Validator.AssertStringOnLength(value, 500, nameof(value));
                _address = value;
            }
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Полное имя покупателя</param>
        /// <param name="address">Адрес покупателя</param>
        /// <param name="id">ID покупателя</param>
        public Customer(string fullname, string address, int id)
        {
            Id = IdGenerator.GetIdNext();
            FullName = fullname;
            Address = address;
        }
    }
}
