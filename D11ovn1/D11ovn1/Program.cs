using static System.Console;

namespace D11ovn1
{
    internal class Program
    {

        static void No()
        {
            Beep(500, 500);
            Beep(400, 950);
        }
        static void Yes()
        {
            Beep(700, 100);
            Beep(710, 100);
            Beep(790, 100);
            Beep(600, 900);
        }
        static void Main(string[] args)
        {
            int a=-1, b=4, c=6, d=35, e=5, f=7, g=14, h=-4, i=6, j=11, k=2, l=15, m=1;
            double q=14.0, r=-4.0, p=6.0, x=11.0, y=2.0, z=15.0, s=1.0, t=7.0;

            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Övning 1");
            ResetColor();
            WriteLine($"{a} + {b} * {c} \t\t= {a + b * c}");
            WriteLine($"({d} + {e}) % {f} \t\t= {(d+e)%f}");
            WriteLine($"{g} + {h} * {i} / {j} \t= {g+h*i/j}");
            WriteLine($"{k} + {l} / {c} * {m} - {f} % {k} \t= {k + l / c * m - f % k}");
            Write("\n");
  
            ForegroundColor = ConsoleColor.Yellow;
            Write("Övning 2\n");
            ResetColor();
            WriteLine($"{q} + {r} * {p} / {x}\t= {q + r * p / x}");
            WriteLine($"{y} + {z} / {p} * {s} - {t} % {y}\t= {y + z / p * s - t % y}");
            ResetColor();

            ForegroundColor = ConsoleColor.Yellow;
            Write("Övning 3\n");
            ResetColor();
            Write("Mata in ett ord --> ");
            string s1 = ReadLine();
            Write("Mata in ett ord till --> ");
            string s2 = ReadLine();
            string temp = "Empty";
            Write($"Ord 1 = {s1}\t");
            Write($"Ord 2 = {s2}\t");
            Write($"Byte = {temp}\t\nTryck på varlfri tangent för att Swappa...\n");
            ReadKey();
            WriteLine($"Ord 1 = {s1}\t");
            WriteLine($"Ord 2 = {s2}\t");
            WriteLine($"Byte = {temp}\t\n");
            temp = s1;
            s1 = s2;
            s2=temp;
            WriteLine($"Ord 1 = {s1}\t");
            WriteLine($"Ord 2 = {s2}\t");
            WriteLine($"Byte = {temp}\t\n");

            ForegroundColor = ConsoleColor.Yellow;
            Write("Övning 4\n");
            ResetColor();
            bool result=true;
            WriteLine($"false && false = {result=false}");
            WriteLine($"false || true = {result = true}");
            WriteLine($"false && true = {result = false}");
            WriteLine($"! false = {result = true}");
        }
    }
}