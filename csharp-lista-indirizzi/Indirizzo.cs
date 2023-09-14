using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    internal class Indirizzo
    {
        public string Name{ get; private set; }
        public string Surname{ get; private set; }
        public string Street { get; private set; }
        public string City { get; private set; }
        public string Province { get; private set; }
        public string ZipCode { get; private set; }

        public Indirizzo(string name, string surname, string street, string city, string province, string zipCode)
        {
            this.Name = name;
            this.Surname = surname; 
            this.Street = street;
            this.City = city;
            this.Province = province;
            this.ZipCode = zipCode;
        }
    }
}
