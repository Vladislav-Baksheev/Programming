using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Contact
    {
        private string _firstName;
        private string _lastName;
        private string _number;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Number { get; set; }

        public Contact(string firstName, string lastName, string number) 
        { 
            FirstName = firstName;
            LastName = lastName;
            Number = number;
        }

        public Contact() 
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Number = string.Empty;
        }
    }
}
