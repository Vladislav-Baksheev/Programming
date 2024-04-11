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
        private ContactSerializer _serializer = new ContactSerializer();

        /// <summary>
        /// Экземпляр класса, предоставляющий доступ к методам для создания контакта с случайными данными.
        /// </summary>
        private ContactVMFactoty _contactVMFactoty = new ContactVMFactoty();

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
        /// Объект, хранящий контакты.
        /// </summary>
        public ObservableCollection<ContactVM> Contacts { get; set; } = new ObservableCollection<ContactVM>();

        /// <summary>
        /// Доступен ли элемент только на чтение.
        /// </summary>
        [ObservableProperty]
        private bool _isReadOnly = true;

        /// <summary>
        /// Доступен ли элемент для нажатия.
        /// </summary>
        [ObservableProperty]
        private bool _isEnabled = false;

        /// <summary>
        /// Виден ли элемент.
        /// </summary>
        [ObservableProperty]
        private bool _isVisible = false;

        /// <summary>
        /// Проверяет, была ли нажата кнопка Edit.
        /// </summary>
        private bool IsEdit { get; set; }

        /// <summary>
        /// Проверяет, была ли нажата кнопка Apply
        /// </summary>
        [ObservableProperty]
        private bool _isApply = false;

        /// <summary>
        /// Хранит текущий индекс контакта.
        /// </summary>
        private int CurrentIndex { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="MainVM"./>.
        /// </summary>
        public MainVM()
        {
            Contacts = _serializer.Load();
        }

        /// <summary>
        /// Команда добавления контакта.
        /// </summary>
        [RelayCommand]
        private void AddContact()
        {
            CurrentContact = new ContactVM(new Contact());

            IsApply = false;
        }

        /// <summary>
        /// Проверяет, может ли выполняться команда удаления контакта.
        /// </summary>
        /// <returns>True, если количество контактов больше 0 и если текущий контакт не равен null, иначе false.</returns>
        private bool CanExecuteRemove()
        {
            return Contacts.Count > 0 && CurrentContact != null;
        }

        /// <summary>
        /// Команда удаления контакта.
        /// </summary>
        [RelayCommand(CanExecute = nameof(CanExecuteRemove))]
        private void RemoveContact()
        {
            if (Contacts.Count == 1)
            {
                Contacts.Remove(CurrentContact);
            }
            else if (CurrentIndex < Contacts.Count - 1)
            {
                Contacts.Remove(CurrentContact);
                CurrentContact = Contacts[CurrentIndex + 1];
            }
            else
            {
                Contacts.Remove(CurrentContact);
                CurrentContact = Contacts[CurrentIndex - 1];
            }
        }

        /// <summary>
        /// Проверяет, может ли выполняться команда редактирования контакта.
        /// </summary>
        /// <returns>True, если количество контактов больше 0 и если текущий контакт не равен null, иначе false.</returns>
        private bool CanExecuteEdit()
        {
            return Contacts.Count > 0 && CurrentContact != null;
        }

        /// <summary>
        /// Команда редактирования контакта.
        /// </summary>
        [RelayCommand(CanExecute = nameof(CanExecuteEdit))]
        private void EditContact()
        {
            IsEdit = true;

            IsApply = false;
        }

        /// <summary>
        /// Команда принятия изменений контакта.
        /// </summary>
        [RelayCommand]
        private void ApplyContact()
        {
            if (!IsEdit)
            {
                Contacts.Add(CurrentContact);
                CurrentContact = null;
                CurrentContact = Contacts[Contacts.Count - 1];
            }
            else
            {
                Contacts[CurrentIndex] = CurrentContact;
                CurrentContact = Contacts[CurrentIndex];
            }
            IsApply = true;
        }

        /// <summary>
        /// Команда сохранения контакта.
        /// </summary>
        [RelayCommand]
        private void SaveContacts()
        {
            _serializer.Save(Contacts);
        }

        /// <summary>
        /// Команда автоматической генерации контакта.
        /// </summary>
        [RelayCommand]
        private void AutoGenerateContact()
        {
            var tempContact = _contactVMFactoty.CreateContact();
            Contacts.Add(tempContact);
            CurrentContact = tempContact;
        }

        /// <summary>
        /// Содержит логику, которая вызывается при изменении текущего контакта.
        /// </summary>
        /// <param name="value">Текущий контакт.</param>
        partial void OnCurrentContactChanged(ContactVM value)
        {
            if (!IsEdit && Contacts.Contains(value))
            {
                CurrentIndex = Contacts.IndexOf(value);
            }

            if (!IsApply)
            {
                IsApply = true;
            }
        }

        /// <summary>
        /// Содержит логику, которая вызывается при изменении свойства IsApply.
        /// </summary>
        /// <param name="value">Текущий контакт.</param>
        partial void OnIsApplyChanged(bool value)
        {
            if (value)
            {
                IsEdit = false;
                IsVisible = false;
                IsReadOnly = true;
            }
            else
            {
                IsVisible = true;
                IsReadOnly = false;
            }
        }
    }
}
