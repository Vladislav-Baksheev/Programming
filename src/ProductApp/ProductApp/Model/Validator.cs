using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    public static class Validator
    {
        public static void AssertOnValue(string value, int max, string propertyName)
        {
            if(value.Length > max) 
            {
                throw new ArgumentException($"Некорректное значение в поле: {propertyName}.");
            }
        }

        public static void AssertOnPositiveValue(int value, string propertyName) 
        { 
            if(value < 0)
            {
                throw new ArgumentException($"Некорректное значение в поле: {propertyName}.");
            }
        }

        public static void AssertOnEmptyValue(string value, string propertyName)
        {
            if(value == "")
            {
                throw new ArgumentException($"Некорректное значение в поле: {propertyName}.");
            }
        }
    }
}
