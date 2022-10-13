using System;

namespace inl3_uppg1
{
    internal class Program
    {
        static double Func(double x, double y) // static-metod för uppgift 4
        {
            double Z = 2 * x + y / 4;
            return Z;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("**************************** Uppgift 1 **************************** ");
            // Uppgift 1: Korrigera nedanstående rad så att nästa rad ger utskrift 0.4!
            double a = (2.0 / 5.0); 
            Console.WriteLine($"a = {a}\n2,0 delat med 5,0)\n"); // <-- Ger "a = 0.4"

            Console.WriteLine("**************************** Uppgift 2 **************************** \n");
            // Uppgift 2. Gör en loop som skriver ut int-arrayen:
            int[] I = new int[] { 99, 12, 4, 7, 33 };
            foreach (int count1 in I)
            {
                Console.Write($"{count1} \n");
            }
            Console.WriteLine("Matar ut Arrayen med Foreach.\n");

            Console.WriteLine("**************************** Uppgift 3 **************************** \n");
            // Uppgift 3: Gör en loop som skriver ut de element i int-arrayen som är större än 5:
            int[] J = new int[] { 2, 1, 5, 0, 4, 2, 7, 2, 7, 2, 0, 2, 8, 3, 2 };
            foreach (int count2 in J)
            {
                if (J[count2] < 5)
                    Console.Write(".");
                else
                    Console.Write($"{J[count2]}");
            }
            Console.WriteLine("\nDe med punkter (.) blir \"dolda\" då dessa nummer är lägre än 5.\n");
            // [NYI] lägg in loopen här!

            Console.WriteLine("**************************** Uppgift 4 **************************** ");
            // 4. Gör en static-metod Func som ersätter beräkningsuttrycket 2 * X + Y / 4: 
            double X = 2.3, Y = 12.8;
            Console.WriteLine($"{Func(X,Y)} <-- Kallar på metoden \"Func()\""); // Detta ger 7.8                                                                         
            double Z = Func(X, Y);
            Console.WriteLine($"{Z} <-- Räknar ut i Main()");
            Console.WriteLine("\n\n\t\tEND OF INLÄMNINGSUPPGIFT!");
        }
    }
}