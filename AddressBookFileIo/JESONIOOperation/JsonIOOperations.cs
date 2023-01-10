using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookFileIo.JESONIOOperation
{
    internal class JsonIOOperations
    {
        public static void WriteRecordsInJSONFile(string path, PersonInput input)
        {
            if (Program.IsFileExists(path))
            {
                string jsonData = JsonConvert.SerializeObject(input);
                if (Program.IsFileExists(path))
                {
                    File.WriteAllText(path, jsonData);
                }
                Console.WriteLine("\nData added in JSON File Successfully");
            }
        }

        public static void ReadRecordsInJSONFile(string path)
        {
            if (Program.IsFileExists(path))
            {
                PersonInput person = JsonConvert.DeserializeObject<PersonInput>(path);
                Console.WriteLine(person);
            }
        }
    }
}
