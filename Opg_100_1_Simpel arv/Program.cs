using System;

namespace Opg_100_1_Simpel_arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simpel arv");

            Person p = new Person();
            p.ForNavn = "Ib";
            p.EfterNavn = "Bak";
            Console.WriteLine(p.FuldtNavn());

            Elev e = new Elev();
            e.ForNavn = "Bo";
            e.EfterNavn = "Dam";
            Console.WriteLine(e.FuldtNavn());

            Instruktør i = new Instruktør();
            i.ForNavn = "Jens";
            i.EfterNavn = "Jensen";
            Console.WriteLine(i.FuldtNavn());
        }
    }

    class Person
    {
        public string ForNavn { get; set; }
        public string EfterNavn { get; set; }

        public string FuldtNavn()
        {
            return this.ForNavn + " " + this.EfterNavn;
        }
    }

    class Elev : Person
    {
        public string Klasselokale { get; set; }
    }

    class Instruktør : Person
    {
        public int NøgleId { get; set; }

    }
}

