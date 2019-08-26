using System;
using System.Collections.Generic;

namespace Opg_75_1_Samlinger_simpel
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Samlinger (simpel)");

            List<int> il = new List<int>();
            il.Add(2);
            il.Add(5);
            il.Add(42);

            foreach (int item in il)
            {
                Console.WriteLine(item);
            }

            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Et");
            d.Add(2, "To");
            d.Add(3, "Tre");

            Console.WriteLine(d[2]);


        }
    }
}
