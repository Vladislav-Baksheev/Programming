using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о песне.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Название песни.
        /// </summary>
        private string _name;

        /// <summary>
        /// Исполнитель песни.
        /// </summary>
        private string _artist;

        /// <summary>
        /// Играет ли песня.
        /// </summary>
        private bool _isPlaying;

        /// <summary>
        /// Возвращает и задает название песни.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает исполнителя.
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        /// Возвращает и задает играет ли песня.
        /// </summary>
        public bool IsPlaying { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/>
        /// </summary>
        /// <param name="name">Название песни.</param>
        /// <param name="artist">Исполнитель.</param>
        /// <param name="isPlaying">Играет ли песня.</param>
        public Song(string name, string artist, bool isPlaying)
        {
            Name = name;
            Artist = artist;
            IsPlaying = isPlaying;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/>
        /// </summary>
        public Song()
        {
            Name = string.Empty;
            Artist = string.Empty;
            IsPlaying = false;
        }
    }
}
