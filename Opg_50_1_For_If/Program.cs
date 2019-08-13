using System;

namespace Opg_50_1_For_If
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10 ; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int ij = i * j;

                    if (ij>50)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    string s;
                    s = ij.ToString();
                    s = s.PadLeft(4);
                    Console.Write(s);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
