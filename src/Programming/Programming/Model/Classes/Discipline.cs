namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о дисциплине.
    /// </summary>
    public class Discipline
    {
        /// <summary>
        /// Оценка.
        /// </summary>
        private int _mark;

        /// <summary>
        /// Часы.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Возвращает и задает название дисциплины.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Минимальная оценка по дисциплине.
        /// </summary>
        private int _minMark = 2;

        /// <summary>
        /// Максимальная оценка по дисциплине.
        /// </summary>
        private int _maxMark = 5;

        /// <summary>
        /// Возвращает и задает оценку по дисциплине.
        /// </summary>
        public int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                if(value >= _minMark && value <= _maxMark)
                    _mark = value;
            }
        }

        /// <summary>
        /// Возвращает и задает количество часов по дисциплине.
        /// </summary>
        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if(value >= 0 && value <= 23)
                    _hours = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Discipline"/>.
        /// </summary>
        /// <param name="name">Название дисциплины.</param>
        /// <param name="mark">Оценка дисциплины.</param>
        /// <param name="hours">Часы дисциплины.</param>
        public Discipline(string name, int mark, int hours)
        {
            Name = name;
            Mark = mark;
            Hours = hours;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Discipline"/>.
        /// </summary>
        public Discipline()
        {
            Name = string.Empty;
            Mark = _minMark;
            Hours = 0;
        }
    }
}
