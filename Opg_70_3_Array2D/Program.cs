using System;

namespace Opg_70_3_Array2D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2D array");

            string[,] s = new string[2,2];

            s[0, 0] = "Nul_Nul";
            s[0, 1] = "Nul_Et";
            s[1, 0] = "Et_Nul";
            s[1, 1] = "Et_Et";

            Console.WriteLine(s);

        }
    }
}
