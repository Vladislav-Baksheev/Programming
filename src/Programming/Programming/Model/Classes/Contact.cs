namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о контакте человека.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Имя.
        /// </summary>
        private string _firstName;

        /// <summary>
        /// Фамилия.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _number;

        /// <summary>
        /// Возвращает и задает имя человека.
        /// </summary>
        public string FirstName 
        {
            get
            {
                return _firstName;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(FirstName));
                _firstName = value;
            }
        }

        /// <summary>
        /// Возвращает и задает фамилию человека.
        /// </summary>
        public string Surname 
        {
            get
            {
                return _surname;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Surname));
                _surname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона человека.
        /// </summary>
        public string Number 
        {
            get
            {
                return _number;
            }
            set 
            {
                if(value.Length != 11)
                {
                    throw new ArgumentException("Некорректная длина номера телефона");
                }
                if(!long.TryParse(value, out long result))
                {
                    throw new ArgumentException("Некорректные символы в номере телефона");
                }
                _number = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="firstName">Имя.</param>
        /// <param name="surname">Фамилия.</param>
        /// <param name="number">Номер телефона.</param>
        public Contact(string firstName, string surname, string number)
        {
            FirstName = firstName;
            Surname = surname;
            Number = number;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {
            FirstName = string.Empty;
            Surname = string.Empty;
            Number = string.Empty;
        }
    }
}
