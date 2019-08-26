using System;

namespace Opg_80_1_KLasse_simpel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Klasser (simpel");

            Person P1 = new Person();
            P1.Fornavn = "Ib";
            P1.Efternavn = "Dam";
            Console.WriteLine(P1.FuldtNavn());
            P1.Fødselsår = 1981;
            Console.WriteLine(P1.Alder());

            Person P2 = new Person();
            Console.WriteLine(P2.FuldtNavn());
            Console.WriteLine(P2.Alder());

            Person P3 = new Person("Bo","Bak",2000);
            Console.WriteLine(P3.FuldtNavn());
            Console.WriteLine(P3.Alder());

        }

    }

    class Person
    {

        //Felter
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        //Metoder
        public string FuldtNavn()
        {
            return this.Fornavn + " " + this.Efternavn;
        }

        public int Alder()
        {
            DateTime idag = System.DateTime.Today;
            int iår = idag.Year;
            return iår - this.Fødselsår;
        }

        public Person() : this("","",0)
        {
        }

        public Person(string fn, string en, int få)
        {
            this.Fornavn = fn;
            this.Efternavn = en;
            this.Fødselsår = få;
        }
    }


}
