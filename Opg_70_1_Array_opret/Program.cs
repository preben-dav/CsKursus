using System;

namespace Opg_70_1_Array_simpel
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] månedsløn = { 10000, 20000, 15000, 20000, 30000, 15000 };

            double sum = 0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                Console.WriteLine(månedsløn[i].ToString("N2"));
                sum = sum + månedsløn[i];
            }
            double gennemsnit = sum / månedsløn.Length;
            Console.WriteLine($"Sum: {sum.ToString("N2")}");
            Console.WriteLine($"Antal: {månedsløn.Length}");
            Console.WriteLine($"Gennemsnit: {gennemsnit.ToString("N2")}");

            Console.WriteLine("Sorteret:");
            int[] sorteret = (int[])månedsløn.Clone();
            System.Array.Sort(sorteret);
            for (int i = 0; i < månedsløn.Length; i++)
            {
                Console.WriteLine(sorteret[i].ToString("N2"));
            }

        }
    }
}
