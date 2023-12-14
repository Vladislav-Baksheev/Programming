using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address;

        public Address Address 
        { 
            get 
            { 
                return _address; 
            }
            set
            {
                _address = value;

                if (_address != null)
                {
                    UpdateTextBoxes();
                }
            }
        }
        public AddressControl()
        {
            InitializeComponent();
            
        }

        private void UpdateTextBoxes()
        {

            PostIndexTextBox.Text = Address.Index.ToString();
            CountryTextBox.Text = Address.Country;
            CityTextBox.Text = Address.City;
            StreetTextBox.Text = Address.Street;
            BuildingTextBox.Text = Address.House;
            ApartmentTextBox.Text = Address.Apartment;
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PostIndexTextBox.BackColor = AppColor.GoodBackColor;
                Address.Index = Convert.ToInt32(PostIndexTextBox.Text);
            }
            catch
            {
                PostIndexTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CountryTextBox.BackColor = AppColor.GoodBackColor;
                Address.Country = CountryTextBox.Text;
            }
            catch
            {
                CountryTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                StreetTextBox.BackColor = AppColor.GoodBackColor;
                Address.Street = StreetTextBox.Text;
            }
            catch
            {
                StreetTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BuildingTextBox.BackColor = AppColor.GoodBackColor;
                Address.House = BuildingTextBox.Text;
            }
            catch
            {
                BuildingTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CityTextBox.BackColor = AppColor.GoodBackColor;
                Address.City = CityTextBox.Text;
            }
            catch
            {
                CityTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ApartmentTextBox.BackColor = AppColor.GoodBackColor;
                Address.Apartment = ApartmentTextBox.Text;
            }
            catch
            {
                ApartmentTextBox.BackColor = AppColor.ErrorBackColor;
            }
        }
        /// <summary>
        /// Очищает контрол.
        /// </summary>
        public void Clear()
        {
            PostIndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();

            PostIndexTextBox.BackColor = AppColor.GoodBackColor;
            CountryTextBox.BackColor = AppColor.GoodBackColor;
            CityTextBox.BackColor = AppColor.GoodBackColor;
            StreetTextBox.BackColor = AppColor.GoodBackColor;
            BuildingTextBox.BackColor = AppColor.GoodBackColor;
            ApartmentTextBox.BackColor = AppColor.GoodBackColor;
        }
    }
}
