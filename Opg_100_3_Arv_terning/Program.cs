using System;

namespace Opg_100_3_Arv_terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arv terning");

            Terning t = new Terning();

            t.Skriv();
            t.Ryst();
            t.Skriv();
            t.Ryst();
            t.Skriv();
        }
    }


    class Terning
    {
        private int værdi;

        public int Værdi
        {
            get { return værdi; }
            set { værdi = value; }
        }

        private static System.Random rnd = new System.Random();

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine($"[{this.værdi}]");
        }

        public Terning()
        {
            Ryst();
        }

        public Terning(int Værdi)
        {
            this.Værdi = Værdi;
        }

    }

}
