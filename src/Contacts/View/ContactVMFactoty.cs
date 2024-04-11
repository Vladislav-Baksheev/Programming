using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Model;
using View.ViewModel;

namespace View
{
    public class ContactVMFactoty
    {
        private string _parameters = "FirstName,Phone,Email";

        private DataAPI _dataAPI;

        public ContactVMFactoty()
        {
            _dataAPI = new DataAPI(_parameters);
        }

        public ContactVM CreateContact()
        {
            string json = _dataAPI.GetJsonData();

            var contact = JsonConvert.DeserializeObject<Contact>(json);

            var contactVM = new ContactVM(contact);

            return contactVM;
        }
    }
}
