namespace csharp_lista_indirizzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = "C:\\Users\\leoni\\source\\repos\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\my-addresses.csv";
                StreamReader address = File.OpenText(path);





                address.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problemi con l'apertura file");
            }
        }
    }
}