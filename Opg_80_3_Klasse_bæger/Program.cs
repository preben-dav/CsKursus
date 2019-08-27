using System;

namespace Opg_80_3_Klasse_bæger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bæger med terninger");

            Bæger b = new Bæger();
            b.Skriv();
            b.Ryst();
            b.Skriv();

        }
    }

    public class Terning
    {
        // Ved .NET Core behøver den ikke være statisk!!
        private static Random rnd = new Random();
        public int værdi;

        public Terning()
        {
            this.værdi = 1;
        }

        public void Skriv()
        {
            Console.Write("[" + this.værdi + "]");
        }

        public void Ryst()
        {
            this.værdi = rnd.Next(1, 7);
        }
    }

    public class Bæger
    {
        public Terning[] terninger = new Terning[5];

        public Bæger()
        {
            for (int i = 0; i < 5; i++)
            {
                this.terninger[i] = new Terning();
                this.terninger[i].Ryst();
            }
        }


        public void Ryst()
        {
            foreach (var item in this.terninger)
            {
                item.Ryst(); 
            }
        }

        public void Skriv()
        {
            foreach (var item in this.terninger)
            {
                item.Skriv();
            }
            Console.WriteLine();
        }

    }
}
