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
                
                while (!addressStreamFile.EndOfStream)
                {
                   
                    string addressLine = addressStreamFile.ReadLine();
                    try
                    {
                        addressList.Add(AddressFileReader.AddressReader(addressLine));

                    }catch (Exception ex) { 
                        Console.WriteLine("Indirizzo non valido.\n");
                    }
                    
                    
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