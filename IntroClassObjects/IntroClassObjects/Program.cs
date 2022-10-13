
namespace ClassObjects1
{
    internal class Program
    {
        public class Countrys
        {
            public string land = "tom";
            public string styre= "tom";
            public string huvudstad = "tom";
            public string population = "tom";
            public void Utskrift2()
            {
                Console.WriteLine($"Landet {land} har {styre} som styre.\nHuvudstaden heter {huvudstad} och {land} har " +
                $"{population} invånare.\n");
            }
        }
        public class Individ
        {
            public string namn="tom";
            public string alder = "tom";
            public string adress = "tom";
            public string telefon = "tom";
            public string stad = "tom";
            public string intresse = "tom";
            public void Utskrift()
            {
                Console.WriteLine($"Namn: {namn}, {alder} år.\nBoende i {stad} på {adress}.\n" +
                $"Telefonnummer: {telefon}\nHuvudintresset är att {intresse}!\n");
            }
        }
        public static void Main(string[] args)
        {
            Individ andreas = new Individ()
            {
                namn = "Andreas Kuylenstierna",
                alder = "42",
                telefon = "073 723 98 52",
                adress = "Anna Särströms Gata 1E",
                stad = "Norrköping",
                intresse = "spela retrospel"
            };

            Individ arne = new Individ()
            {
                namn = "Arne Svensson",
                alder = "59",
                telefon = "013-113 13 13",
                adress = "Datasvängen 23",
                stad = "Linköping",
                intresse = "programmera i Python"
            };

            Individ berith = new Individ()
            {
                namn = "Berith Qvist",
                alder = "59",
                telefon = "014 114 14 14",
                adress = "Telegränd 45",
                stad = "Minköping",
                intresse = "påta i trädgården"
            };

            Countrys swe = new Countrys()
            {
                land = "Sverige",
                styre = "Monarki",
                huvudstad = "Stockholm",
                population = "10 512 820",
            };
            Countrys ger = new Countrys()
            {
                land = "Tyskland",
                styre = "Republik",
                huvudstad = "Berlin",
                population = "83 783 902",
            };
            Countrys san = new Countrys()
            {
                land = "San Marino",
                styre = "Republik",
                huvudstad = "San Marino",
                population = "33 600",
            };
            andreas.Utskrift();
            arne.Utskrift();
            berith.Utskrift();
            swe.Utskrift2();
            ger.Utskrift2();
            san.Utskrift2();
        }
    }
}