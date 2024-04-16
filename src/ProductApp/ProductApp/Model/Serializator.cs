using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    /// <summary>
    /// Содержит методы для сериализации.
    /// </summary>
    public static class Serializator
    {
        /// <summary>
        /// Возвращает и задает путь сохранения файла.
        /// </summary>
        public static string Path { get;} = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\contacts.json";

        /// <summary>
        /// Сохраняет объект в файл.
        /// </summary>
        /// <param name="product">Контакт.</param>
        public static void Save(List<Product>? product)
        {
            using (StreamWriter wr = new StreamWriter(Path))
            {
                wr.Write(JsonConvert.SerializeObject(product));
            }
        }

        /// <summary>
        /// Загружает данные из файла в приложение. 
        /// </summary>
        /// <returns>Объект класса <see cref="Serializator"/>.</returns>
        public static List<Product>? Load()
        {
            var product = new List<Product>();

            if (File.Exists(Path))
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    product = JsonConvert.DeserializeObject<List<Product>>(sr.ReadToEnd());
                }
            }

            return product;
        }
    }
}
