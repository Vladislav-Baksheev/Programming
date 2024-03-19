using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Song
    {
        private string _name;
        private string _artist;
        private bool _isPlaying;

        public string Name { get; set; }

        public string Artist { get; set; }

        public bool IsPlaying { get; set; }

        public Song(string name, string artist, bool isPlaying)
        {
            Name = name;
            Artist = artist;
            IsPlaying = isPlaying;
        }

        public Song()
        {
            Name = string.Empty;
            Artist = string.Empty;
            IsPlaying = false;
        }
    }
}
