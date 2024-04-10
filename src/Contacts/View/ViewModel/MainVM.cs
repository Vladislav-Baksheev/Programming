using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm;
using System.Windows.Input;
using View.Model;
using View.Model.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для главного окна.
    /// </summary>
    public partial class MainVM : ObservableObject
    {
        /// <summary>
        /// Сериализатор.
        /// </summary>
        ContactSerializer _serializer = new ContactSerializer();

        /// <summary>
        /// Возвращает и задает контакт.
        /// </summary>
        public Contact Contact { get; set; } = new Contact();

        /// <summary>
        /// Объект, хранящий текущий контакт.
        /// </summary>
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(AddContactCommand), nameof(EditContactCommand))]
        private ContactVM _currentContact;

        /// <summary>
        /// Создает экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {

        }

        public ObservableCollection<ContactVM> Contacts { get; set; } = new ObservableCollection<ContactVM>();

        [RelayCommand]
        private void AddContact()
        {
            CurrentContact = new ContactVM(new Contact());
        }

        [RelayCommand]
        private void RemoveContact()
        {

        }

        [RelayCommand]
        private void EditContact()
        {

        }

        [RelayCommand]
        private void ApplyContact()
        {
            Contacts.Add(CurrentContact);
        }
    }
}
