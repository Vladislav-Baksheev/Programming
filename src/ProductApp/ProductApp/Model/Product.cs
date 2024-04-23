namespace ProductApp.Model
{
    public class Product
    {
        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Производитель товара.
        /// </summary>
        private string _manufacturer;

        /// <summary>
        /// Количество товара.
        /// </summary>
        private int _amount;

        /// <summary>
        /// Максимальное количество символов для названия и производителя товара.
        /// </summary>
        private int _maxSymbols = 100;

        /// <summary>
        /// Категория товара.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает и задает название товара.
        /// </summary>
        public string? Name 
        { 
            get 
            { 
                return _name; 
            } 
            set
            {  
                Validator.AssertOnValue(value, _maxSymbols, nameof(Name));
                Validator.AssertOnEmptyValue(value, nameof(Name));
                _name = value; 
            }
        }

        /// <summary>
        /// Возвращает и задает производителя товара.
        /// </summary>
        public string? Manufacturer
        {
            get
            {
                return _manufacturer;
            }
            set
            {

                Validator.AssertOnValue(value, _maxSymbols, nameof(Manufacturer));
                _manufacturer = value;
                
            }
        }

        /// <summary>
        /// Возвращает и задает количество товара.
        /// </summary>
        public int Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Amount));
                _amount = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Product"/>.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="manufacturer">Производитель.</param>
        /// <param name="category">Категория.</param>
        /// <param name="amount">Количество.</param>
        public Product(string name, string manufacturer, Category category, int amount)
        {
            Name = name;
            Manufacturer = manufacturer;
            Category = category;
            Amount = amount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Product"/>.
        /// </summary>
        public Product()
        {
            Name = "None";
            Manufacturer = "None";
            Amount = 0;
        }
    }
}
