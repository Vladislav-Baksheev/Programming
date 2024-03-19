using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Film
    {
        private string _name;
        private int _duration;
        private int _yearOfRelease;
        private string _genre;
        private double _rating;

        public string Name { get; set; }
        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                if (value > 0)
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
                if (value > 1900 && value <= 2024)
                    _yearOfRelease = value;
            }
        }

        public string Genre { get; set; }

        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value > 0 && value <= 10)
                    _rating = value;
            }
        }

        public Film(string name, int duration, int yearOfRelease, string genre, double rating)
        {
            Name = name;
            Duration = duration;
            YearOfRelease = yearOfRelease;
            Genre = genre;
            Rating = rating;
        }

        public Film()
        {
            Name = string.Empty; ;
            Duration = 0;
            YearOfRelease = 0;
            Genre = string.Empty;
            Rating = 0;
        }
    }
}
