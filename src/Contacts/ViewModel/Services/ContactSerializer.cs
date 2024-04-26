using System;
using System.Collections.ObjectModel;
using System.IO;
using Newtonsoft.Json;
using View.ViewModel;

namespace ViewModel.Services
{
    /// <summary>
    /// Представляет реализацию для сериализации.
    /// </summary>
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
        /// <param name="contacts">Контакты.</param>
        public void Save(ObservableCollection<ContactVM>? contacts)
        {
            if (!File.Exists(Path))
            {
                File.Create(Path).Close();
            }

            using (StreamWriter wr = new StreamWriter(Path))
            {
                wr.Write(JsonConvert.SerializeObject(contacts));
            }
        }

        /// <summary>
        /// Загружает данные из файла в приложение. 
        /// </summary>
        /// <returns>Объект класса <see cref="ContactSerializer"/>.</returns>
        public ObservableCollection<ContactVM>? Load()
        {
            var contacts = new ObservableCollection<ContactVM>();

            if (File.Exists(Path))
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    contacts = JsonConvert.DeserializeObject<ObservableCollection<ContactVM>?>(sr.ReadToEnd());
                }
            }

            return contacts;
        }
    }
}
