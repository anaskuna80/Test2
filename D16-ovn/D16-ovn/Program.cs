using System.Drawing;
using System.Runtime.CompilerServices;

namespace D16_ovn
{
    class Webbs
    {

        void PrintArray(int[] items)
        {

            for (int i = 0; i < items.Length; i++)
            {
                Console.Write($"{items[i]} ");
            }
        }

        class Cirkel
        {
            private double radius, diam;
            public Cirkel(double radius, double diam)
            {
                Console.WriteLine($"r:{radius} a: {diam}");
            }
            public double Area()
            {
                return Math.PI * radius * radius;
            }
        }
        class Rektangel
        {
            private double bredd, lengd;
            public Rektangel(double Bredd, double Lengd)
            {
                bredd = Bredd; lengd = Lengd;
            }
            public double Area()
            {
                return lengd * bredd;
            }
            public double TaBredden()
            {
                return bredd;
            }
            public double TaLengden()
            {
                return lengd;
            }
            public void SetBredd(double nyBredd)
            {
                bredd = nyBredd;
            }
            public void Print()
            {
                Console.WriteLine($"Utskrift av Rektangel där bredden är = {bredd}\n\t\t\t och längden = {lengd}");
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Rektangel r = new Rektangel(1.3, 4.2);
                r.Print();
                Console.WriteLine($"Area hämtad av metoden Area() \t     = {r.Area()}");
                Console.WriteLine($"Bredden igen via TaBredden           = {r.TaBredden()}");
                Console.WriteLine($"Längden igen via TaLengden           = {r.TaLengden()}");
                r.SetBredd(6.7);
                r.Print();
                Console.WriteLine($"Bredden igen via TaBredden och Set   = {r.TaBredden()}");
               
            }
        }
    }
}