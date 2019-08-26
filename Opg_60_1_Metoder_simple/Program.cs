using System;

namespace Opg_60_1_Metoder_simple
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = LægSammen(2, 5);
            Console.WriteLine(res);

            double res2 = BeregnAreal(5);
            Console.WriteLine(res2);

            Console.WriteLine("Dette er en test");
        }

        static int LægSammen(int a, int b)
        {
            int c = a + b;
            return c;
        }

        static double BeregnAreal(double r)
        {
            double a = System.Math.PI * r * r;
            return a;
        }
    }
}
