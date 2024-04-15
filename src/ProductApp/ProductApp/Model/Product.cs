using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    public class Product
    {
        private string _name;

        private string _manufacturer;

        private int _amount;

        private int _maxSymbols = 100;

        public Category Category { get; set; }

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

        public Product(string name, string manufacturer, Category category, int amount)
        {
            Name = name;
            Manufacturer = manufacturer;
            Category = category;
            Amount = amount;
        }

        public Product()
        {
            Name = "None";
            Manufacturer = "None";
            Amount = 0;
        }
    }
}
