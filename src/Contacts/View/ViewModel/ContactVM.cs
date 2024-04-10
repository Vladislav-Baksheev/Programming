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
        public string? Name
        {
            get => Contact.Name;

            set => SetProperty(Contact.Name, value, Contact, (contact, name) => Contact.Name = name, true);
        }

        [Required]
        [Phone]
        public string? PhoneNumber
        {
            get => Contact.PhoneNumber;

            set => SetProperty(Contact.PhoneNumber, value, Contact, (contact, Name) => Contact.PhoneNumber = Name, true);
        }

        [Required]
        [EmailAddress]
        public string? Email
        {
            get => Contact.Email;

            set => SetProperty(Contact.Email, value, Contact, (contact, name) => Contact.Email = name, true);
        }
        public ContactVM(Contact contact)
        {
            Contact = contact;
            ValidateAllProperties();
        }
    }
}
