using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    class CustomerFactory
    {
        private Customer _customer;
        private Random _random = new Random();
        public Customer CreateCustomer()
        {
            string[] fullname = { "Анатольев Владислав Андреевич", "Шоколадов Антон Валерьевич", "Лучших Филипп Казаков", "Худших Дмитрий Олегов"};
            string[] address = {"ул. Школьная 26", "ул. Ленина 17"};
            _customer = new Customer();
            _customer.FullName = fullname[_random.Next(fullname.Length)];
            _customer.Address = address[_random.Next(address.Length)];
            return _customer;
        }
    }
}
