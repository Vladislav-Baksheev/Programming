using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace View.Model.Services
{
    class ContactSerializer
    {
        /// <summary>
        /// Возвращает и задает путь сохранения файла.
        /// </summary>
        public string Path { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\contacts.json";

        /// <summary>
        /// Создает экземпляр класса <see cref="ContactSerializer"/>.
        /// </summary>
        public ContactSerializer()
        {

        }

        /// <summary>
        /// Сохраняет объект в файл.
        /// </summary>
        /// <param name="contact">Контакт.</param>
        public void Save(Contact? contact)
        {
            using (StreamWriter wr = new StreamWriter(Path))
            {
                wr.Write(JsonConvert.SerializeObject(contact));
            }
        }

        /// <summary>
        /// Загружает данные из файла в приложение. 
        /// </summary>
        /// <returns>Объект класса <see cref="ContactSerializer"/>.</returns>
        public Contact? Load() 
        {
            var contact = new Contact();

            if (File.Exists(Path))
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    contact = JsonConvert.DeserializeObject<Contact?>(sr.ReadToEnd());
                }
            }

            return contact;
        }
    }
}
