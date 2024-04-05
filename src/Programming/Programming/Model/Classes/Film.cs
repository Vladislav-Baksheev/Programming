using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит информацию о фильмах.
    /// </summary>
    public class Film
    {
        /// <summary>
        /// ID фильма.
        /// </summary>
        private int _id;

        /// <summary>
        /// Общее количество фильмов.
        /// </summary>
        private static int _allFilmsCount = 0;

        /// <summary>
        /// Название фильма.
        /// </summary>
        private string _name;

        /// <summary>
        /// Длительность фильма.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Год выхода фильма.
        /// </summary>
        private int _yearOfRelease;

        /// <summary>
        /// Жанр фильма.
        /// </summary>
        private string _genre;
        
        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private int _rating;

        /// <summary>
        /// Возвращает и задает название фильма.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает ID фильма.
        /// </summary>
        public int Id
        {
            get => _id;
        }

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
                Validator.AssertValueInRange(value, 1900, 2024, nameof(YearOfRelease));
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
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Film"/>
        /// </summary>
        /// <param name="name">Название фильма.</param>
        /// <param name="duration">Длительность фильма.</param>
        /// <param name="yearOfRelease">Год выпуска фильма.</param>
        /// <param name="genre">Жанр фильма.</param>
        /// <param name="rating">Рейтинг фильма.</param>
        public Film(string name, int duration, int yearOfRelease, string genre, int rating)
        {
            Name = name;
            Duration = duration;
            YearOfRelease = yearOfRelease;
            Genre = genre;
            Rating = rating;
            _allFilmsCount++;
            _id = _allFilmsCount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Film"/>
        /// </summary>
        public Film()
        {
            Name = string.Empty; ;
            Duration = 0;
            YearOfRelease = 0;
            Genre = string.Empty;
            Rating = 0;
            _allFilmsCount++;
            _id = _allFilmsCount;
        }

        public override string ToString()
        {
            return $"Film {Id}";
        }
    }
}
