using System;

namespace Opg_120_2_Delegates_beregner
{

    public delegate int Beregn(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegates beregner");

            int res = Beregner(1, 1, Plus); // lægger sammen
            Console.WriteLine(res);
            res = Beregner(1, 1, Minus);	// trækker fra
            Console.WriteLine(res);


            // Find tilfældig
            var f = FindTilfældigFunktion();
            int res4 = f(5, 5);
            // eller
            // int res4 = FindTilfældigFunktion()(5,5);
            Console.WriteLine(res4);

        }


        public static int Beregner(int a, int b, Beregn f)
        {
            return f(a, b);
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }

        public static Beregn FindTilfældigFunktion()
        {
            if (System.DateTime.Now.Millisecond <= 250)
                return Plus;
            if (System.DateTime.Now.Millisecond <= 500)
                return Minus;
            if (System.DateTime.Now.Millisecond <= 750)
                return Gange;

            return Divider;

        }

    }
}
