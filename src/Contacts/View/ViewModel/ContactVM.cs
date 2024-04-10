using System.ComponentModel;
using View.Model;

namespace View.ViewModel
{
    public class ContactVM : INotifyPropertyChanged
    {
        public Contact Contact { get; set; }

        public string? Name
        {
            get => Contact.Name;

            set => Contact.Name = value;
        }

        public string? PhoneNumber
        {
            get => Contact.PhoneNumber;

            set => Contact.PhoneNumber = value;
        }

        public string? Email
        {
            get => Contact.Email;

            set => Contact.Email = value;
        }

        public ContactVM(Contact contact)
        {
            Contact = contact;
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
