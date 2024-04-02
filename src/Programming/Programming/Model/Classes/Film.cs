using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Film
    {
        private int _id;
        private static int _allFilmsCount = 0;
        private string _name;
        private int _duration;
        private int _yearOfRelease;
        private string _genre;
        private int _rating;

        public string Name { get; set; }

        public int Id
        {
            get => _id;
        }

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

        public string Genre { get; set; }

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
