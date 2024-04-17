using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для контакта.
    /// </summary>
    public class ContactVM : ObservableValidator, ICloneable
    {
        /// <summary>
        /// Хранит контакт.
        /// </summary>
        public Contact Contact { get; set; }

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        [Required (ErrorMessage = "Name is not specified")]
        [MinLength(2 , ErrorMessage = "The length must be over 2 symbols")]
        [MaxLength(100, ErrorMessage = "The length must be lower 100 symbols")]    
        public string? FirstName
        {
            get => Contact.FirstName;
            set => SetProperty(Contact.FirstName, 
                value, Contact, 
                (contact, name) => 
                Contact.FirstName = name, 
                true);
        }

        /// <summary>
        /// Возвращает и задает номер телефона контакта.
        /// </summary>
        [Required (ErrorMessage = "Phone is not specified")]       
        [Phone (ErrorMessage = "Phone must contains only numbers ans +, -, (, ) symbols")]
        [MaxLength(100, ErrorMessage = "The length must be lower 100 symbols")]
        public string? Phone
        {
            get => Contact.Phone;
            set => SetProperty(Contact.Phone, 
                value, Contact, 
                (contact, phone) => 
                Contact.Phone = phone, 
                true);
        }

        /// <summary>
        /// Возвращает и задает электронную почту контакта.
        /// </summary>
        [Required (ErrorMessage = "Email is not specified")]
        [EmailAddress (ErrorMessage = "Email must contains @ symbol")]
        [MaxLength(100, ErrorMessage = "The length must be lower 100 symbols")]     
        public string? Email
        {
            get => Contact.Email;
            set => SetProperty(Contact.Email, 
                value, Contact, 
                (contact, email) => 
                Contact.Email = email, 
                true);
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="ContactVM"./>
        /// </summary>
        /// <param name="contact">Контакт.</param>
        public ContactVM(Contact contact)
        {
            Contact = contact;
            ValidateAllProperties();
        }

        /// <summary>
        /// Создает клон объекта.
        /// </summary>
        /// <returns>Возвращает объект класса <see cref="ContactVM"/></returns>
        public object Clone()
        {
            return new ContactVM((Contact)Contact.Clone());
        }
    }
}
