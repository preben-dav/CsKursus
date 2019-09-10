using System;

namespace Opg_120_4_Delegates_beregner_func
{

    //  public delegate int Beregn(int a, int b);


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegates beregner");
          
            int res = Beregner(2, 4, Plus); // lægger sammen
            Console.WriteLine(res);
            res = Beregner(2, 4, Minus);	// trækker fra
            Console.WriteLine(res);

            // Find tilfældig
            var f = FindTilfældigFunktion();
            int res4 = f(2, 4);
            // eller
            // int res4 = FindTilfældigFunktion()(5,5);
            Console.WriteLine(res4);

        }

        
        public static int Beregner(int a, int b, Func<int,int,int> f)
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

        public static Func<int,int,int> FindTilfældigFunktion()
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
