using static System.Console;

namespace secondsPerYear
{
    internal class Program
    {
        static void Main(string[] args)
        {   /* Tilldelningar av data
            double daysPerYear = 365.2422, hoursPerDay = 24.0, minutesPerHour = 60.0, secondsPerMinute = 60.0, monthsPerYear = 12.0;
            WriteLine("Månader/år  = " + monthsPerYear + " mån.");

            // Uträkningar
            double hoursPerYear = hoursPerDay * daysPerYear;                // Timmar per år
            WriteLine("Timmar/år   = " + hoursPerYear + " h.");
            double minutesPerYear = minutesPerHour * hoursPerYear;          // Minuter per år
            WriteLine("Minuter/år  = " + minutesPerYear + " min.");
            double secondsPerYear = secondsPerMinute * minutesPerYear;      // Sekunder per år
            WriteLine("Sekunder/år = " + secondsPerYear + " sek.");
            Console.Beep(520, 278);
            Console.Beep(780, 789);
            */
            double i = 13.12 / 1.5;
            int y = (int)i;
            Console.WriteLine($"i = {y}");


            double i = 13.12 / 1.5;
            Console.WriteLine($"i = {Convert.ToInt32(i)}");
        }
    }
}