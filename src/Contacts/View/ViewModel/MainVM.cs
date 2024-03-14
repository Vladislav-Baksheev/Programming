using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    class MainVM : INotifyPropertyChanged
    {
        ContactSerializer _serializer = new ContactSerializer();

        public Contact Contact { get; set; } = new Contact();

        public string? Name
        {
            get => Contact.Name;
            set
            {
                Contact.Name = value;
                OnPropertyChanged(nameof (Name));
            }
        }

        public string? PhoneNumber
        {
            get => Contact.PhoneNumber;
            set
            {
                Contact.PhoneNumber = value;
                OnPropertyChanged(nameof (PhoneNumber));
            }
        }
        public string? Email
        {
            get => Contact.Email;
            set
            {
                Contact.Email = value;
                OnPropertyChanged(nameof (Email));
            }
        }
       
        public ICommand LoadCommand { get; }

        public ICommand SaveCommand { get; }

        public MainVM()
        {
            SaveCommand = new SaveCommand(SaveContact);
            LoadCommand = new LoadCommand(LoadContact);
        }

        private void SaveContact(object? parameter)
        {
            _serializer.Save(Contact);
        }

        private void LoadContact(object? parameter)
        {
            var contact = _serializer.Load();
            Name = contact.Name;
            PhoneNumber = contact.PhoneNumber;
            Email = contact.Email;
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
