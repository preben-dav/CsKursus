using System;

namespace Opg_110_1_Eget_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eget interface");

            IDbFunktioner t = new Hund();

            //IDbFunktioner x = new IDbFunktioner();

            IDbFunktioner[] ia = new IDbFunktioner[10];

            for (int i = 0; i < ia.Length; i++)
            {
                if (i % 2 == 0)
                {
                    ia[i] = new Hund();
                }
                else
                {
                    ia[i] = new Ubåd();
                }
            }

            foreach (var item in ia)
            {
                item.Gem();
            }

        }
    }

    interface IDbFunktioner
    {
        void Gem();

    }


    class Hund : IDbFunktioner 
    {

        public string Navn { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer Hund...");
        }
    }

    class Ubåd : IDbFunktioner 
    {

        public int Nummer { get; set; }
        public double Tubine { get; set; }
        public void Gem()
        {
            Console.WriteLine("Gemmer Ubåd...");
        }
    }
}
