using System;

namespace Opg_80_2_Klasse_terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
            Console.WriteLine("Ryster terning...");
            t.Ryst();
            t.Skriv();

            Console.WriteLine("Test");

            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            Terning t2 = new Terning(true);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();
        }
    }

    class Terning
    {
        public int Værdi;
        private bool Snyd;
        private static Random rnd = new Random();

        public void Ryst()
        {
            if (this.Snyd)
            {
                this.Værdi = 6;
            }
            else
            {
                this.Værdi = rnd.Next(1, 7); 
            }
        }

        public void Skriv()
        {
            Console.WriteLine($"Værdien er: {this.Værdi}");
        }

        public Terning() : this(1,false)
        {
        }

        public Terning(bool b) : this(1, b)
        {
        }

        public Terning(int a, bool b)
        {
            this.Værdi = a;
            this.Snyd = b;
        }


    }
}
