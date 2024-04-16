namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит информацию о фильмах.
    /// </summary>
    public class Film
    {
        /// <summary>
        /// Общее количество фильмов.
        /// </summary>
        private static int _allFilmsCount = 0;

        /// <summary>
        /// Длительность фильма.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Год выхода фильма.
        /// </summary>
        private int _yearOfRelease;

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private int _rating;

        private int _minYearOfrelease = 1900;

        private int _maxYearOfRelease = 2024;

        /// <summary>
        /// Минимальный рейтинг.
        /// </summary>
        private int _minRating = 0;

        /// <summary>
        /// Максимальный рейтинг.
        /// </summary>
        private int _maxRating = 10;

        /// <summary>
        /// Возвращает и задает название фильма.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает ID фильма.
        /// </summary>
        public int Id { get; private set; }


        /// <summary>
        /// Возвращает и задает длительность фильма.
        /// </summary>
        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Duration));
                _duration = value;
            }
        }

        /// <summary>
        /// Возвращает и задает длительность фильма.
        /// </summary>
        public int YearOfRelease
        {
            get
            {
                return _yearOfRelease;
            }
            set
            {
                Validator.AssertValueInRange(value, _minYearOfrelease, _maxYearOfRelease, nameof(YearOfRelease));
                _yearOfRelease = value;
            }
        }

        /// <summary>
        /// Возвращает и задает жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает рейтинг фильма.
        /// </summary>
        public int Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, _minRating, _maxRating, nameof(Rating));
                _rating = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Film"/>.
        /// </summary>
        /// <param name="name">Название фильма.</param>
        /// <param name="duration">Длительность фильма.</param>
        /// <param name="yearOfRelease">Год выпуска фильма.</param>
        /// <param name="genre">Жанр фильма.</param>
        /// <param name="rating">Рейтинг фильма.</param>
        public Film(string name, 
            int duration, 
            int yearOfRelease, 
            string genre, 
            int rating)
        {
            Name = name;
            Duration = duration;
            YearOfRelease = yearOfRelease;
            Genre = genre;
            Rating = rating;
            _allFilmsCount++;
            Id = _allFilmsCount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Film"/>.
        /// </summary>
        public Film()
        {
            Name = string.Empty;
            Duration = 0;
            YearOfRelease = 0;
            Genre = string.Empty;
            Rating = 0;
            _allFilmsCount++;
            Id = _allFilmsCount;
        }

        public override string ToString()
        {
            return $"Film {Id}";
        }
    }
}
