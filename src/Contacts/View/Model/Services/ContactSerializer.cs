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
        public string Path { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\contacts.json";

        public ContactSerializer()
        {

        }
        public void Save(Contact? contact)
        {
            using (StreamWriter wr = new StreamWriter(Path))
            {
                wr.Write(JsonConvert.SerializeObject(contact));
            }
        }

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
