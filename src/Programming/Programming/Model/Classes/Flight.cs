using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private string _departurePoint;
        private string _destination;
        private int _time;

        public string DeparturePoint { get; set; }

        public string Destination { get; set; }

        public int Time
        {
            get
            {
                return _time;
            }
            set
            {
                if (value > 0)
                    _time = value;
            }
        }

        public Flight(string departurePoint, string destination, int time)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            Time = time;
        }

        public Flight()
        {
            DeparturePoint = string.Empty;
            Destination = string.Empty;
            Time = 0;
        }
    }
}
