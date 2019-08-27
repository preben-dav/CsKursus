using System;

namespace Opg_100_2_Arv_random
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arv random");

            UdvidetRandom r = new UdvidetRandom();
            Console.WriteLine(r.NextBool()); // true eller false
            Console.WriteLine(r.NextBool()); // true eller false
            Console.WriteLine(r.NextBool()); // true eller false
            Console.WriteLine(r.NextBool()); // true eller false
            Console.WriteLine(r.NextBool()); // true eller false
            Console.WriteLine(r.NextBool()); // true eller false
            Console.WriteLine(r.NextBool()); // true eller false
            Console.WriteLine(r.NextBool()); // true eller false
            Console.WriteLine(r.NextBool()); // true eller false
            Console.WriteLine(r.NextBool()); // true eller false
        }
    }

    class UdvidetRandom : Random
    {

        public bool NextBool()
        {
            int i = this.Next(1002);
            if (i<=500)
                {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
