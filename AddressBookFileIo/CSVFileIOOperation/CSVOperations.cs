using CsvHelper;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookFileIo.CSVFileIOOperation
{
    internal class CSVOperations
    { 
        public static void WriteRecordsInCSVFile(string path, PersonInput input)
        {
            if (Program.IsFileExists(path))
            {
                List<PersonInput> list = new List<PersonInput>();
                list.Add(input);
                StreamWriter stream = new StreamWriter(path);
                CsvWriter csv = new CsvWriter(stream, CultureInfo.InvariantCulture);
                csv.WriteRecords<PersonInput>(list);
                stream.Flush();
            }
        }
        public static void ReadRecordsInCSVFile(string path)
        {
            if (Program.IsFileExists(path))
            {
                StreamReader stream = new StreamReader(path);
                CsvReader csv = new CsvReader(stream, CultureInfo.InvariantCulture);
                List<PersonInput> list = csv.GetRecords<PersonInput>().ToList();
                foreach (PersonInput record in list)
                {
                    Console.WriteLine(record);
                }
            }
        }
    }
}
