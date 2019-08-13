using System;

namespace BrugAfVariabler
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            a++;
            a--;
            a += 20;
            Console.WriteLine(a.ToString("N2"));

            double b = 12.5;
            Console.WriteLine(b);
            b++;
            b--;
            b *= 2;
            Console.WriteLine(b);
        }
    }
}
