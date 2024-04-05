using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о времени.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Часы.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Минуты.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Секунды.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Возвращает и задает часы.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает минуты.
        /// </summary>
        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                if (value >= 0 && value <= 60)
                    _minutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задает секунды.
        /// </summary>
        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                if (value >= 0 && value <= 60)
                    _seconds = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Time"/>
        /// </summary>
        /// <param name="hours">Часы.</param>
        /// <param name="minutes">Минуты.</param>
        /// <param name="seconds">Секунды.</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Time"/>
        /// </summary>
        public Time()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }
    }
}
