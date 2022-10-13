using System.Xml.Schema;

namespace D12ovn
{
    internal class Program
    {
        static double Cot(double x)
        {
            return 1/Math.Tan(x);   
        }
        static double Factorial(double x)
        {
            double fact = 1;
            for (int i = 1; i <= x; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        static long SumSquares(long n)
        {
            long sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i*i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
 /*
            Console.WriteLine("\nUppgift 1:\n");
            for (double c = 0; c <= 2.0; c += 0.2)
            {
                Console.WriteLine($"Cotangent (c) --> {c} får {Cot(c)}");
            }
            Console.WriteLine("\nUppgift 2:\n");
            for (double f = 0; f <= 15.0; f++)
            {
                Console.WriteLine($"{Factorial(f)}");
            }
            Console.WriteLine("\nUppgift 3:\n");
            for (long n = 1; n <= 10; n++)
            {
                long tot = SumSquares(n);
                Console.WriteLine($"{tot}");
            }
 */
            //Arrays
            Console.WriteLine("\nUppgift 1.2.1:\n");
            // string[] names = new string[6];
            string[] names = { "Adam", "Berith", "Caesar", "Deborah", "Erik", "Fanny" };
            int[] phoneList = { 26378, 11895, 55500, 66666, 12345, 33770 };
            for (int q = 0; q < names.Length; q++)
            {
                Console.Write($"{names[q]} - ");
                Console.WriteLine(phoneList[q]);
            }

            Console.WriteLine("\nUppgift 1.2.2:\n");
            foreach (string s in names)
            {
                foreach (int u in phoneList)
                {
                    Console.WriteLine(s);
                    Console.Write(u);
                }
            }
            /*
                         Console.WriteLine("\nUppgift 1.2.3:\n");

                         for (int t = 0; t < names.Length; t++)
                         { 
                             Console.WriteLine($"{names.Length} - {phoneList.Length}");
                             for (int r = 0; r < phoneList.Length; r++)
                             {
                                 Console.WriteLine($" - {phoneList[r]}");
                                 Console.Write(names[t]);
                             } 
         }
         Console.WriteLine($"{names[0]} - {phoneList[0]}");
             Console.WriteLine($"{names[1]} - {phoneList[1]}");
             Console.WriteLine($"{names[2]} - {phoneList[2]}");
             Console.WriteLine($"{names[3]} - {phoneList[3]}");
             Console.WriteLine($"{names[4]} - {phoneList[4]}");
             Console.WriteLine($"{names[5]} - {phoneList[5]}");
             Console.WriteLine("\n--END--"); */
        }
    }
}