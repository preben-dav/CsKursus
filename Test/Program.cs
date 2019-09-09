using System;

namespace Demo
{
    // Defination af delegates
    public delegate void MinDelegate1();
    public delegate void MinDelegate2(string txt);
    public delegate int MinDelegate3(int a, int b);

    internal class Program
    {
        private static void Main(string[] args)
        {


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

}