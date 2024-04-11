using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel.DataAnnotations;
using View.Model;

namespace View.ViewModel
{
    public class ContactVM : ObservableValidator
    {
        public Contact Contact { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string? FirstName
        {
            get => Contact.FirstName;

            set => SetProperty(Contact.FirstName, value, Contact, (contact, name) => Contact.FirstName = name, true);
        }

        [Required]
        [Phone]
        public string? Phone
        {
            get => Contact.Phone;

            set => SetProperty(Contact.Phone, value, Contact, (contact, phone) => Contact.Phone = phone, true);
        }

        [Required]
        [EmailAddress]
        public string? Email
        {
            get => Contact.Email;

            set => SetProperty(Contact.Email, value, Contact, (contact, email) => Contact.Email = email, true);
        }
        public ContactVM(Contact contact)
        {
            Contact = contact;
            ValidateAllProperties();
        }
    }
}
