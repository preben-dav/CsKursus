using System;

namespace Opg_50_2_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                if (i%3!=0)
                {
                    continue;
                }
                if (i>15)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
        
    }
}
