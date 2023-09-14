namespace csharp_lista_indirizzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Address> addressList = new List<Address>();   
            try
            {
                string path = "C:\\Users\\leoni\\source\\repos\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\my-addresses.csv";
                StreamReader addressStreamFile = File.OpenText(path);
                
                int actualLine = 0;
                while (!addressStreamFile.EndOfStream)
                {
                   
                        AddressFileReader.AddressReader(addressStreamFile);
                        string[] addressFields = addressStreamFile.ReadLine().Split(",");
                        if (addressFields.Length < 6)
                        {
                            Console.WriteLine("Indirizzo non valido.");
                        }
                        else
                        {
                            if(actualLine > 0)
                            {
                                string name = addressFields[0];
                                string surname = addressFields[1];
                                string street = addressFields[2];
                                string city = addressFields[3];
                                string province = addressFields[4];
                                string zipCode= addressFields[5];
                                
                                Address address = new Address(name, surname, street, city, province, zipCode);
                                Console.WriteLine(address);
                            }
                        }

                    
                    actualLine++;
                }

                addressStreamFile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemi con l'apertura file");
            }
        }
    }
}