using System;

namespace Opg_40_2_Regnemaskine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast tal 1");
            string tal1 = Console.ReadLine();
            Console.WriteLine("Indtast tal 2");
            string tal2 = Console.ReadLine();

            double t1 = Convert.ToDouble(tal1);
            double t2 = Convert.ToDouble(tal2);
            double t3 = t1 + t2;

            Console.WriteLine("Summen af de to tal er:");
            Console.WriteLine(t3);
            Console.WriteLine(t3.ToString("N2"));
            Console.WriteLine(t3.ToString("F2"));
            Console.WriteLine(t3.ToString("N2", new System.Globalization.CultureInfo("en-US")));
            Console.WriteLine(t3.ToString("N2"));
            
        }
    }
}

