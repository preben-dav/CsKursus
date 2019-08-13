using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime a,b;
            a = DateTime.Now;
            a = new DateTime(2019, 8, 12);
            Console.WriteLine($"a = {a}");
            b=a.AddDays(1);
            Console.WriteLine($"b = {b}");

            Console.WriteLine($"Dag på året {a.DayOfYear}");

            Console.WriteLine($"Ugedag {a.DayOfWeek.ToString()}");
            Console.WriteLine($"Lille dato streng {a.ToShortDateString()}");
            Console.WriteLine($"Stor dato streng {a.ToLongDateString()}");
            Console.WriteLine($"Lille tid streng {a.ToShortTimeString()}");
            Console.WriteLine($"Stor tid streng {a.ToLongTimeString()}");

        }
    }
}
