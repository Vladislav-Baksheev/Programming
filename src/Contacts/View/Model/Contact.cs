namespace View.Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Имя.
        /// </summary>
        public string? FirstName { get; set; }

        /// <summary>
        /// Номер телефона.
        /// </summary>
        public string? Phone { get; set; }

        /// <summary>
        /// Электронная почта.
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="phone">Номер телефона.</param>
        /// <param name="email">Электронная почта.</param>
        public Contact(string? name, string? phone, string? email)
        {
            FirstName = name;
            Phone = phone;
            Email = email;
        }
    }
}
