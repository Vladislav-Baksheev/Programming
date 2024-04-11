using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel.DataAnnotations;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для контакта.
    /// </summary>
    public class ContactVM : ObservableValidator
    {
        /// <summary>
        /// Хранит контакт.
        /// </summary>
        public Contact Contact { get; set; }

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string? FirstName
        {
            get => Contact.FirstName;

            set => SetProperty(Contact.FirstName, value, Contact, (contact, name) => Contact.FirstName = name, true);
        }

        /// <summary>
        /// Возвращает и задает номер телефона контакта.
        /// </summary>
        [Required]
        [Phone]
        public string? Phone
        {
            get => Contact.Phone;

            set => SetProperty(Contact.Phone, value, Contact, (contact, phone) => Contact.Phone = phone, true);
        }

        /// <summary>
        /// Возвращает и задает электронную почту контакта.
        /// </summary>
        [Required]
        [EmailAddress]
        public string? Email
        {
            get => Contact.Email;

            set => SetProperty(Contact.Email, value, Contact, (contact, email) => Contact.Email = email, true);
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
    }
}
