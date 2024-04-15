using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    public class Product
    {
        private string? _name;

        private string? _manufacturer;

        private int _amount;

        public Category Category { get; set; }

        public string? Name 
        { 
            get 
            { 
                return _name; 
            } 
            set
            {
                if (_name != value && _name.Length < 100)
                {
                    _name = value;
                }   
            }
        }

        public string? Manufacturer
        {
            get
            {
                return _manufacturer;
            }
            set
            {
                if (_manufacturer != value && _manufacturer.Length < 100)
                {
                    _manufacturer = value;
                }
            }
        }

        public int Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }

        public Product(string name, string manufacturer, Category category, int amount)
        {
            Name = name;
            Manufacturer = manufacturer;
            Category = category;
            Amount = amount;
        }

        public Product()
        {
            Name = string.Empty;
            Manufacturer = string.Empty;
            Amount = 0;
        }
    }
}
