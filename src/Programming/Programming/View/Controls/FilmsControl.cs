using Programming.Model.Classes;
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
        private Film[] films;

        private Film _currentFilm;

        public FilmsControl()
        {
            InitializeComponent();
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {

        }
    }
}
