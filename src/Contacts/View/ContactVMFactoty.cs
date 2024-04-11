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
    /// <summary>
    /// Содержит методы для автоматической генеирации контакта.
    /// </summary>
    public class ContactVMFactoty
    {
        /// <summary>
        /// Параметры для запроса.
        /// </summary>
        private string _parameters = "FirstName,Phone,Email";

        /// <summary>
        /// Экземпляр класса, предоставляющий доступ к методам, работающим с API.
        /// </summary>
        private DataAPI _dataAPI;

        /// <summary>
        /// Создает экземпляр класса <see cref="ContactVMFactoty"./>
        /// </summary>
        public ContactVMFactoty()
        {
            _dataAPI = new DataAPI(_parameters);
        }
        
        /// <summary>
        /// Создает сгенерированный контакт.
        /// </summary>
        /// <returns>Сгенерированный контакт</returns>
        public ContactVM CreateContact()
        {
            string json = _dataAPI.GetJsonData();

            var contact = JsonConvert.DeserializeObject<Contact>(json);

            var contactVM = new ContactVM(contact);

            return contactVM;
        }
    }
}
