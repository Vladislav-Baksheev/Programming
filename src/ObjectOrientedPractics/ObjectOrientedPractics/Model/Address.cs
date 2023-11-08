using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model
{
    public class Address
    {
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна/регион.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город (населенный пункт).
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры/помещения.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и получает почтовый индекс.
        /// Состоит из 6 символов.
        /// </summary>
        public int Index
        {
            get 
            { 
                return _index; 
            }
            set
            {
                Validator.AssertCountSymbols(value, 6, nameof(value));
                if (value != _index) 
                    _index = value;
            }
        }

        /// <summary>
        /// Вовзращает и получает страну/регион.
        /// Не более 50 символов.
        /// </summary>
        public string Country
        {
            get 
            { 
                return _country; 
            }
            set
            {
                Validator.AssertStringOnLength(value, 50, nameof(value));
                if (value != _country)
                    _country = value;
            }
        }

        /// <summary>
        /// Возвращает и получает город (населенный пункт).
        /// Не более 50 символов.
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                Validator.AssertStringOnLength(value, 50, nameof(value));
                if (value != _city)
                    _city = value;
            }
        }

        /// <summary>
        /// Возвращает и получает улицу.
        /// Не более 100 символов.
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                Validator.AssertStringOnLength(value, 100, nameof(value));
                if (value != _street)
                    _street = value;
            }
        }

        /// <summary>
        /// Возвращает и получает номер дома.
        /// Не более 10 символов.
        /// </summary>
        public string House
        {
            get 
            { 
                return _building;
            }
            set
            {
                Validator.AssertStringOnLength(value, 10, nameof(value));
                if (value != _building)
                    _building = value;
            }
        }

        /// <summary>
        /// Возвращает и получает номер квартиры.
        /// Не более 10 символов.
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                Validator.AssertStringOnLength(value, 10, nameof(value));
                if (value != _apartment)
                    _apartment = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>
        /// </summary>
        /// <param name="index">Почтовый индекс.</param>
        /// <param name="country">Страна.</param>
        /// <param name="city">Город.</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Строение.</param>
        /// <param name="apartment">Номер квартиры.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            House = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>.
        /// </summary>
        public Address()
        {
            Index = 100000;
            Country = "None";
            City = "None";
            Street = "None";
            House = "None";
            Apartment = "None";
        }
    }
}
