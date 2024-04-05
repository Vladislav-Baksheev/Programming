using Programming.Model.Classes;
using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    public partial class FilmsControl : UserControl
    {
        /// <summary>
        /// Массив фильмов.
        /// </summary>
        private Film[] _films;

        /// <summary>
        /// Текущий фильм.
        /// </summary>
        private Film _currentFilm;

        Random random = new Random();

        /// <summary>
        /// Массив жанров.
        /// </summary>
        private string[] _genres;

        /// <summary>
        /// Массив названий.
        /// </summary>
        private string[] _names = { "Evangelion", "Breaking Bad", "The Walking Dead", "Schindler's List", "Godfather" };

        public FilmsControl()
        {
            InitializeComponent();

            _films = new Film[5];
            _genres = Enum.GetNames(typeof(Genre));
            for (int i = 0; i < _films.Length; i++)
            {
                _films[i] = new Film(_names[i], random.Next(1, 1000), random.Next(1900, 2024), _genres[random.Next(_genres.Length)], random.Next(1, 10));

                FilmsListBox.Items.Add(_films[i].ToString());
            }
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            FilmsListBox.SelectedIndex = FindFilmWithMaxRating(_films);
        }

        /// <summary>
        /// Ищет фильмы с максимальным рейтингом.
        /// </summary>
        /// <param name="films">Фильмы.</param>
        /// <returns>Индекс фильма с самым большим рейтингом.</returns>
        private int FindFilmWithMaxRating(Film[] films)
        {
            int indexMaxWidth = 0;
            double maxRating = 0;

            for (int i = 0; i < films.Length; i++)
            {
                if (films[i].Rating > maxRating)
                {
                    maxRating = films[i].Rating;
                    indexMaxWidth = i;
                }
            }

            return indexMaxWidth;
        }

        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentFilm = _films[FilmsListBox.SelectedIndex];
            NameTextBox.Text = _currentFilm.Name;
            DurationTextBox.Text = _currentFilm.Duration.ToString();
            YearTextBox.Text = _currentFilm.YearOfRelease.ToString();
            GenreTextBox.Text = _currentFilm.Genre.ToString();
            RatingTextBox.Text = _currentFilm.Rating.ToString();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Name = NameTextBox.Text;
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFilm.Duration = Convert.ToInt32(DurationTextBox.Text);
                DurationTextBox.BackColor = AppColor.NormalBackColor;
            }
            catch (Exception ex)
            {
                DurationTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFilm.YearOfRelease = Convert.ToInt32(YearTextBox.Text);
                YearTextBox.BackColor = AppColor.NormalBackColor;
            }
            catch (Exception ex)
            {
                YearTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Genre = GenreTextBox.Text;
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFilm.Rating = Convert.ToInt32(RatingTextBox.Text);
                RatingTextBox.BackColor = AppColor.NormalBackColor;
            }
            catch (Exception ex)
            {
                RatingTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }
    }
}
