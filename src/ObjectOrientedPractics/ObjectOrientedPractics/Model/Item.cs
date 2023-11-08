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
        /// Бренд машины.
        /// </summary>
        private string _carBrand = "";

        /// <summary>
        /// Модель машины
        /// </summary>
        private string _carModel = "";

        /// <summary>
        /// Год выпуска маишны.
        /// </summary>
        private string _carYear = "";

        /// <summary>
        /// Цвет машины.
        /// </summary>
        private string _carColor = "";

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
                if(CarBrand != "")
                {
                    Name = CarBrand;
                }
                return _name;
            }
            set
            {
                Validator.AssertStringOnLength(value, 200, nameof(value));
                if(value != _name) 
                { 
                    _name = value;
                }
                
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
                if (CarColor != "" || CarModel != "" || CarYear != "")
                    Info = $"{CarColor} {CarModel} {CarYear}";
                return _info;
            }
            set
            {
                Validator.AssertStringOnLength(value, 1000, nameof(value));
                if(value != _info)
                {
                    _info = value;
                }
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
        /// Возвращает и задает значения модели машины.
        /// </summary>
        public string CarModel
        {
            get
            {
                return _carModel;
            }
            set
            {
                Validator.AssertStringOnLength(value, 333, nameof(CarModel));
                _carModel = value;
            }
        }
        
        /// <summary>
        /// Возвращает и задает значения цвета машины. 
        /// </summary>
        public string CarColor
        {
            get
            {
                return _carColor;
            }
            set
            {
                Validator.AssertStringOnLength(value, 333, nameof(CarColor));
                _carColor = value;
            }
        }

        /// <summary>
        /// Возвращает и задает значения бренда машины.
        /// </summary>
        public string CarBrand
        {
            get
            {
                return _carBrand;
            }
            set
            {
                Validator.AssertStringOnLength(value, 200, nameof(CarBrand));
                _carBrand = value;
            }
        }

        /// <summary>
        /// Возвращает и задает значения года выпуска машины.
        /// </summary>
        public string CarYear
        {
            get
            {
                return _carYear;
            }
            set
            {
                Validator.AssertStringOnLength(value, 333, nameof(CarYear));
                _carYear = value;
            }
        }

        /// <summary>
        /// Возвращает и задает категорию товара.
        /// </summary>
        public Category Category {get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="info">Описание товара.</param>
        /// <param name="cost">Цена товара.</param>
        /// <param name="category">Категория товара</param>
        public Item(string name, string info, double cost, Category category)
        {
            Id = IdGenerator.GetIdNext();
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
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
            Category = Category.None;
        }       
    }
}
