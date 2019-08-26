using System;

namespace Opg_60_3_Metoder_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Overload opg");

        }

        public static int Beregn(int a, int b)
        {
            return a + b;
        }

        public static int Beregn(int a, int b, int c)
        {
            return Beregn(a ,b) + c;
        }

        public static int Beregn(int a, int b, int c, int d)
        {
            return a + Beregn(b, c, d);
        }

    }
}
