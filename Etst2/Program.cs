namespace Etst2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            double i = 13.12 / 1.5;
            int y = (int)i;
            Console.WriteLine($"i = {i}");

            double b = 13.12 / 1.5;
            Console.WriteLine($"b = {Convert.ToInt32(b)}");
        }
    }
}