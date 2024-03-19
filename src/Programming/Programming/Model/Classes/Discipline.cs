using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Discipline
    {
        string _name;
        int _mark;
        int _hours;

        public string Name { get; set; }

        public int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                if (value >= 2 && value <= 5)
                    _mark = value;
            }
        }

        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if (value >= 0 && value <= 23)
                    _hours = value;
            }
        }

        public Discipline(string name, int mark, int hours)
        {
            Name = name;
            Mark = mark;
            Hours = hours;
        }

        public Discipline()
        {
            Name = string.Empty;
            Mark = 2;
            Hours = 0;
        }
    }
}
