using System;
using System.Collections.Generic;

namespace Opg_120_5_Delegates_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegates - Lambda");

            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };

            int b = a.FindIndex(i => i == 51);
            Console.WriteLine(b);

            //            Predicate Find(int i); = false;

            int c = a.FindIndex(Find);
            Console.WriteLine(c);

            bool Find(int i)
            {
                return (i == 51);
            }

            Console.WriteLine();

            a.ForEach(ListVærdi);

            Console.WriteLine();

            a.ForEach(i => Console.WriteLine(i)); 

            void ListVærdi(int i)
            {
                Console.WriteLine(i);
            }

        }
    }
}
