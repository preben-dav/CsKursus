using System;

namespace Opg_65_1_SimpelFejlhåndtering
{
    class Program
    {
        static void Main(string[] args)
        {

            bool success = false;
            int i = 0;

            while (!success && i<3)
            {
                try
                {
                    Run();
                    success = true;
                }
                catch (Exception ex)
                {
                    i++;
                    Console.WriteLine("Kun heltal accepteres...");
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void Run()
        {
            Console.WriteLine("Indtast 1. tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast 2. tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            int res = tal1 + tal2;
            Console.WriteLine("resultatet er " + res);
        }
    }
}
