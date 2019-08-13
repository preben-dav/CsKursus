using System;

namespace Opg_48_1_Enum
{

     class Program
    {
        static void Main(string[] args)
        {

            int kort1Værdi = 2;
            kortKulør kort1Kulør = kortKulør.Hjerter;

            int kort2Værdi = 2;
            kortKulør kort2Kulør = kortKulør.Klør;

            Console.WriteLine(kort1Kulør);
            Console.WriteLine(kort1Kulør.ToString());
            Console.WriteLine((int)kort1Kulør);
            Console.WriteLine(System.Convert.ToInt32(kort1Kulør));
            Console.WriteLine();
            Console.WriteLine(kort1Værdi);

            Console.WriteLine();
            Console.WriteLine(kort2Kulør);
            Console.WriteLine(kort2Værdi);
        }
    }
}
