using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                if (value >= 2 && value <= 5)
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
                if (value >= 0 && value <= 23)
                    _hours = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Discipline"/>
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
        /// Создает экземпляр класса <see cref="Discipline"/>
        /// </summary>
        public Discipline()
        {
            Name = string.Empty;
            Mark = 2;
            Hours = 0;
        }
    }
}
