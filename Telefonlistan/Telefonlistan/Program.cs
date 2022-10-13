namespace Telefonlistan
{
    internal class Program
    {
        static void ContainsDot(string surname, string lastname, string tel, string address)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write($"Namn: {surname} {lastname}\nTelefonnummer: {tel}\nAdress: {address}\n");
            Console.ResetColor();  
        }

        static double between(double a, double b, double c)
        { 
            return a, b, c;
        }
        static void Main(string[] args)
        {
            string surname = "Arne";
            string lastname = "Svensson";
            string tel = "013 - 113 13 13";
            string address = "Tomtebacken 113, 698 73 Linköping";
            ContainsDot(surname, lastname, tel, address);
        }
    }
}