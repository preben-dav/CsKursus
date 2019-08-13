using System;

namespace Opg_45_1_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            System.DateTime d1;
            d1 = DateTime.Now;
            Console.WriteLine(d1);
            d1 = d1.AddDays(10);
            Console.WriteLine(d1);
            d1 = d1.AddMinutes(20);
            Console.WriteLine(d1);
            d1 = d1.AddMonths(-1);
            Console.WriteLine(d1);
            
            System.DateTime d2, d3;
            d2 = new DateTime(2019,12,24);
            d3 = DateTime.Today;
            Console.WriteLine(d2.Subtract(d3).Days);

            TimeSpan t2, t3, t4, t5;
            t2 = new TimeSpan(16, 0, 0);
            Console.WriteLine(t2);
            t3 = new TimeSpan(0, 30, 0);
            Console.WriteLine(t3);
            t4 = t2 - t3;
            Console.WriteLine(t4);
            t5 = t2 + t3;
            Console.WriteLine(t5);

        }
    }
}
