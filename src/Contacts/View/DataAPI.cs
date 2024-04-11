using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    /// <summary>
    /// Содержит методы для работы с API.
    /// </summary>
    public class DataAPI
    {
        /// <summary>
        /// URL сайта.
        /// </summary>
        readonly private string url = "https://api.randomdatatools.ru/?unescaped=false&params=";

        /// <summary>
        /// Запрос для сайта.
        /// </summary>
        private HttpWebRequest _request;

        /// <summary>
        /// Ответ от сайта.
        /// </summary>
        private HttpWebResponse _response;

        /// <summary>
        /// Параметры.
        /// </summary>
        public string Parameters { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="DataAPI"./>
        /// </summary>
        /// <param name="parameters">Параметры.</param>
        public DataAPI(string parameters)
        {
            Parameters = parameters;
        }

        /// <summary>
        /// Получает данные с сайта в формате JSON.
        /// </summary>
        /// <returns>Данные в формате JSON.</returns>
        public string GetJsonData()
        {
            string jsonText;

            _request = (HttpWebRequest)WebRequest.Create(url + Parameters);

            _response = (HttpWebResponse)_request.GetResponse();

            Stream stream = _response.GetResponseStream();

            using (StreamReader reader = new StreamReader(_response.GetResponseStream()))
            {
                jsonText = reader.ReadToEnd();
            }

            return jsonText;
        }
    }
}
