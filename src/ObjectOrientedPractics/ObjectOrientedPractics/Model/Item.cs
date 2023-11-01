using System;
using System.Linq.Expressions;
using ObjectOrientedPractics.Services;
namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товарах.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Id товара.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Имя товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Информация о товаре.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает и задает id товара.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Возвращает и задает имя товара
        /// Не больше 200 символов.
        /// </summary>
        public string Name 
        { 
            get 
            { 
                return _name; 
            }
            set
            {
                Validator.AssertStringOnLength(value, 200, nameof(value));
                _name = value;
            }

        }
        /// <summary>
        /// Возвращает и задает информацию о товаре
        /// Не больше 1000 символов.
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set 
            { 
                Validator.AssertStringOnLength(value, 1000, nameof(value));
                _info = value; 
            }
        }
        /// <summary>
        /// Возвращает и задает стоимость товара
        /// От 0 до 100000.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 100000, nameof(value));
                _cost = value;
            }

        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="info">Описание товара.</param>
        /// <param name="cost">Цена товара.</param>
        public Item(string name, string info, double cost)
        {
            Id = IdGenerator.GetIdNext();
            Name = name;
            Info = info;
            Cost = cost;
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            Id = IdGenerator.GetIdNext();
            Name = "None";
            Info = "None";
            Cost = 0;
        }       
    }
}
