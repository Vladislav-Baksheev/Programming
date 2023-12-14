using Newtonsoft.Json;
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
        /// <summary>
        /// Покупатель.
        /// </summary>
        private Customer _customer;

        private DataAPI dataAPI;

        private string _parametres = "LastName,FirstName,FatherName,Country,City,Street,Apartment,House";

        public CustomerFactory()
        {
            dataAPI = new DataAPI(_parametres);
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <returns>Экземпляр класса <see cref="Customer"/>.</returns>
        public Customer CreateCustomer()
        {
            
            _customer = JsonConvert.DeserializeObject<Customer>(dataAPI.GetJsonData());
            _customer.Address = JsonConvert.DeserializeObject<Address>(dataAPI.GetJsonData());

            return _customer;
        }
    }
}
