using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public class DataAPI
    {
        readonly private string url = "https://api.randomdatatools.ru/?unescaped=false&params=";

        private HttpWebRequest _request;

        private HttpWebResponse _response;

        public string Parameters { get; set; }

        public DataAPI(string parameters)
        {
            Parameters = parameters;
        }

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
