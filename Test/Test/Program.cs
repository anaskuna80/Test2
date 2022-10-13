using static System.Console; //Gör så att du slipper skriva "Console" varje gång

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello, World!"); //Hej världen
            ReadLine(); //Läs in av användare
            Clear(); //Rensa skärm
            WriteLine("Great, You have now passed my little test!");
        }
    }
}