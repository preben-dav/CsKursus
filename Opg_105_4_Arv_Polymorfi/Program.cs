using System;
using System.Collections.Generic;

namespace Opg_105_4_Arv_Polymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opg 105.4 Arv (polymorfi)");

            Hund h = new Hund();
            h.SigNoget();

            Kat k = new Kat();
            k.SigNoget();

            List<Dyr> zoo = new List<Dyr>();
            zoo.Add(new Hund());
            zoo.Add(new Kat());
            zoo.Add(new Hund());
            zoo.Add(new Kat());

            foreach (var item in zoo)
            {
                item.SigNoget();
            }

            for (int i = 0; i < 20; i++)
            {
                //Dyr d = new Dyr();
                
            }
        }
    }

    abstract class Dyr
    {
        public string Navn { get; set; }
        public abstract void SigNoget();

        private static System.Random rnd = new Random();
        public static Dyr TilfældigtDyr()
        {
            
            string data = "Freja;Bella;Emma;Mille;Fie;Molly;Lady;Trine;Trunte;Luna;Amanda;";
            data += "Bonnie;Laika;Ronja;Sally;Trille;Zita;Tøsen;Bianca;Zenta;Victor;Buller;";
            data += "Buster;King;Simba;Thor;Charlie;Samson;Bamse;Mickey;Max;Rasmus;Sofus;Anton;";
            data += "Laban;Basse;Bølle;Oliver;Oscar;Balder";
            string[] navne = data.Split(';');
            int index = rnd.Next(0, navne.Length);
            if (index % 2 == 0)
            {
                return new Hund() { Navn = navne[index] };
            }
            else
            {
                return new Kat() { Navn = navne[index] };
            }
        }
    }

    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine($"Jeg er en hund og hedder {Navn}");
        }
    }


    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine($"Jeg er en kat og hedder {Navn}");
        }

    }
}
