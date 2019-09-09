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
        }
    }

    abstract class Dyr
    {
        public string Navn { get; set; }
        public abstract void SigNoget();
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
