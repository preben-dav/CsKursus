using System;

namespace Opg_120_1_Delegates_grundlæggende
{
    public delegate void MinDelegate1(string s);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate - simpel");

            MinDelegate1 f1 = new MinDelegate1(MinSkrivTilConsole);
            f1.Invoke("test");


            MinDelegate1 f2 = MinSkrivTilConsole;
            f2("test");

            MinDelegate1 f3 = MinSkrivTilConsole;
            f3 += Console.WriteLine;
            f3("dav");

            f1 -= MinSkrivTilConsole;
            f2 -= MinSkrivTilConsole;
            f3 -= MinSkrivTilConsole;
            f3 -= MinSkrivTilConsole;

            //f1("q");
            //f2("w");
            //f3("z");
        }

        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }
    }
}
