using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _firstName;
        private string _surname;
        private string _number;

        public string FirstName 
        {
            get
            {
                return _firstName;
            }

            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(FirstName));
                _firstName = value;
            }
        }

        public string Surname 
        {
            get
            {
                return _surname;
            }

            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Surname));
                _surname = value;
            }
        }

        public string Number 
        {
            get
            {
                return _number;
            }
            set 
            {
                if (value.Length != 11)
                {
                    throw new ArgumentException("Некорректная длина номера телефона");
                }
                if (!long.TryParse(value, out long result))
                {
                    throw new ArgumentException("Некорректные символы в номере телефона");
                }
                _number = value;
            }
        }

        public Contact(string firstName, string surname, string number)
        {
            FirstName = firstName;
            Surname = surname;
            Number = number;
        }

        public Contact()
        {
            FirstName = string.Empty;
            Surname = string.Empty;
            Number = string.Empty;
        }
    }
}
