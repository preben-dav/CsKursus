using System;

namespace Opg_90_4_Egenskaber_terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Egenskaber terning");



            Terning t = new Terning();

            for (int i = 0; i < 20; i++)
            {
                t.Ryst();
                t.Skriv();
            }

        }

    }

    public class Terning
    {
        private int værdi;

        public int Værdi
        {
            get
            {
                return this.værdi;
            }
            set
            {
                if ((value < 1) || (value > 6))
                {
                    this.værdi = value;
                }
                else
                {
                    this.værdi = 1;
                }
            }
        }

        private static Random rnd = new Random();

        public void Ryst()
        {
              this.værdi = rnd.Next(1,7);
        }
        
        public void Skriv()
        {
            Console.Write($"[{this.værdi}]");
        }

        public Terning()
        {

        }


    }
}
