using static D15_ovn_1.Program;

namespace D15_ovn_1
{
    internal class Program
    {
        static void PrintPlanetList(Planet[] planets)
        {
            foreach (Planet P in planets)
            {
                if (P != null) P.Print1();
            }
        }
        public class Planet
        {
            public string namn = "";
            public double solavstånd = 0;
            public double massa = 0;
            public int antalMånar = 0;
            public int upptäcksÅr = 0;
            public void Print0()
            {
                Console.WriteLine($"Planet: {namn}\n\tSolavstånd (AE): {solavstånd}\n\tMassa (jordmassor): {massa}\n\tAntal kända månar:" +
                    $" {antalMånar} \n");
            }
            public void Print1()
            {
                if (upptäcksÅr > int.MinValue)
                {
                    Console.WriteLine($" Solavstånd (AE): {solavstånd}");
                }
                Console.WriteLine($"Planet: {namn}\n\tSolavstånd (AE): {solavstånd}\n\tMassa (jordmassor): {massa}\n\tAntal kända månar:" +
                    $" {antalMånar}\n\tUpptäcksår: {upptäcksÅr}\n");
            }
            public Planet(string Namn, double Solavstånd, double Massa)
            {
                namn = Namn; solavstånd = Solavstånd; massa = Massa;
            }
            public Planet(string Namn, double Solavstånd, double Massa, int Upptäcksår)
            {
                namn = Namn; solavstånd = Solavstånd; massa = Massa; upptäcksÅr = Upptäcksår;
            }
            public Planet()
            {


            }
            public static void Main(string[] args)
            {             
                Planet merkurius = new Planet();
                Planet venus = new Planet();
                Planet earth = new Planet();
                Planet mars = new Planet();
                Planet jupiter = new Planet();
                Planet saturnus = new Planet();
                Planet uranus = new Planet();
                Planet neptunus = new Planet();

                Planet[] planets = new Planet[8];
                planets[0] = merkurius; {merkurius.namn = "Merkurius"; merkurius.solavstånd = 0.387; merkurius.massa = 1.00; merkurius.antalMånar = 1; merkurius.upptäcksÅr = -3500; };
                planets[1] = venus;
                planets[2] = earth;
                planets[3] = mars;
                planets[4] = jupiter;
                planets[5] = saturnus;
                planets[6] = uranus;
                planets[7] = neptunus;

                earth.namn = "Jorden"; earth.solavstånd = 1.00; earth.massa = 1.00; earth.antalMånar = 1; earth.upptäcksÅr = int.MinValue;
                mars.namn = "Mars"; mars.solavstånd = 1.523; mars.massa = 0.107; mars.antalMånar = 2; mars.upptäcksÅr = int.MinValue;            
                neptunus.namn = "Neptunus"; neptunus.solavstånd = 30.07; neptunus.massa = 17.147; neptunus.antalMånar = 14; neptunus.upptäcksÅr = 1846;

                earth.Print0(); mars.Print0(); neptunus.Print1();
                PrintPlanetList(planets);

                Planet[] planet2 = new Planet[] {
                    new Planet("Merkurius", 0.387, 0.055),
                    new Planet("Venus", 0.723, 0.815),
                    new Planet("Jorden", 1.0, 1.0) {antalMånar = 1} ,
                    new Planet("Mars", 1.523, 0.107) {antalMånar = 2} ,
                    new Planet("Jupiter", 5.204, 317.8) {antalMånar = 80} ,
                    new Planet("Saturnus", 9.583, 95.16),
                    new Planet("Uranus", 19.191, 14.536) {upptäcksÅr = 1781} ,
                    new Planet("Neptunus", 30.07, 17.147) {upptäcksÅr = 1846}
};


            }
        }
    }
}

    
