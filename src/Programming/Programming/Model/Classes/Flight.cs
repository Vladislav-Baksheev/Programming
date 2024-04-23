namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит информацию о рейсах.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Время полета.
        /// </summary>
        private int _time;

        /// <summary>
        /// Возвращает и задает точку вылета.
        /// </summary>
        public string DeparturePoint { get; set; }

        /// <summary>
        /// Возвращает и задает пункт прибытия.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Возвращает и задает время полета.
        /// </summary>
        public int Time
        {
            get
            {
                return _time;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Time));
                _time = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="departurePoint">Точка вылета.</param>
        /// <param name="destination">Пункт прибытия.</param>
        /// <param name="time">Время полета.</param>
        public Flight(string departurePoint, string destination, int time)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            Time = time;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Flight"/>.
        /// </summary>
        public Flight()
        {
            DeparturePoint = string.Empty;
            Destination = string.Empty;
            Time = 0;
        }
    }
}
