using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookFileIo
{
    internal class PersonInput
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public int Zip { get; set; }
        public long PhoneNumber { get; set; }
    }
}
