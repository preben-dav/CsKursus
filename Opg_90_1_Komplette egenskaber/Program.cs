using System;

namespace Opg_90_1_Komplette_egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Komplette egenskaber");

            Vare v1 = new Vare("Vare1", 100);
            Console.WriteLine(v1.Navn);
            Console.WriteLine(v1.Pris);
            Console.WriteLine(v1.PrisMedMoms());
            v1.Pris = 1000;
            Console.WriteLine(v1.Pris);
            Console.WriteLine(v1.PrisMedMoms());

        }
    }

    class Vare
    {
        private string navn;

        public string Navn
        {
            get
            {
                Console.WriteLine("get navn");
                return navn;
            }
            set
            {
                navn = value;
                Console.WriteLine("set navn");
            }
        }

        private double pris;

        public double Pris
        {
            get
            {
                Console.WriteLine("get pris");
                return pris;
            }
            set
            {
                Console.WriteLine("set pris");
                pris = value;
            }
        }

        public double PrisMedMoms()
        {
            return 1.25 * this.pris;
        }

        public Vare()
        {
                 }

        public Vare(string s, double d)
        {
            navn = s;
            pris = d;
        }

    }
}
