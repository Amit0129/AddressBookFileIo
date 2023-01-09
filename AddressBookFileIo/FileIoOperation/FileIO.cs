using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookFileIo.FileIoOperation
{
    internal class FileIO
    {
        public static void WriteRecordsInFile(string path, PersonInput person)
        {

            if (File.Exists(path))
            {
                StreamWriter sw = File.AppendText(path);
                sw.WriteLine("\nFirst Name : " + person.fName);
                sw.WriteLine("Last Name : " + person.lName);
                sw.WriteLine("Address : " + person.address);
                sw.WriteLine("City : " + person.city);
                sw.WriteLine("State : " + person.state);
                sw.WriteLine("Email : " + person.email);
                sw.WriteLine("Zip code : " + person.zip);
                sw.WriteLine("Mobile Number : " + person.phoneNumber);
                sw.WriteLine();
                sw.Close();
                Console.WriteLine("\nData added successfully in file");
            }
            else
            {
                Console.WriteLine("\nFile Not Found");
            }
        }
        public static void ReadRecordsFromFile(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine(File.ReadAllText(path));
            }
            else
            {
                Console.WriteLine("\nFile Not Found");
            }
        }
    }
}
