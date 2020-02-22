using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Address
    {
        public int PostCode { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public int Flat { get; set; }


        public override string ToString()
        {
            return $"Addres: {PostCode}, {Town}, {Street}, {House}, {Flat}";
        }

        public Address(int postCode, string town, string street, int house, int flat)
        {
            PostCode = postCode;
            Town = town;
            Street = street;
            House = house;
            Flat = flat;
        }
    }
}
