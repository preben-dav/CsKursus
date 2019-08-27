using System;

namespace Opg_80_4_Klasser_statisk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

          //  Beregninger b = new Beregninger();

            //Console.WriteLine(b.LægSammen(2, 2));
            //Console.WriteLine(b.TrækFra(10, 4));

            Console.WriteLine(Beregninger.LægSammen(2, 2));
            Console.WriteLine(Beregninger.TrækFra(10, 4));

        }
    }

    class Beregninger
    {
        public static int LægSammen(int a, int b)
        {
            return a + b;
        }

        public static int TrækFra(int a, int b)
        {
            return a - b;
        }

        private Beregninger()
        {

        }
    }
}
