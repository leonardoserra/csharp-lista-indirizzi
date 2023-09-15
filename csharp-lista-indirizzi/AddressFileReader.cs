using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public class AddressFileReader
    {
        public static Address AddressReader(string addressLine)
        {
            string[] addressFields = addressLine.Split(",");
            if (addressFields.Length != 6)
            {
                throw new Exception("Indirizzo non valido.\n");
            }
            else
            {
                for (int i = 0; i < addressFields.Length; i++)
                {
                    if (addressFields[i] == "")
                    {
                        addressFields[i] = "DATI_MANCANTI";

                    }
                }
                string name = addressFields[0];
                string surname = addressFields[1];
                string street = addressFields[2];
                string city = addressFields[3];
                string province = addressFields[4];
                string zipCode = addressFields[5];
                Address address = new Address(name, surname, street, city, province, zipCode);
                Console.WriteLine(address);
                return address;
                    
                }
            }
        }
    }

