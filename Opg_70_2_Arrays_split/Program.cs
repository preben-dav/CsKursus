using System;

namespace Opg_70_2_Arrays_split
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "3;5;22;1;10;15;5";

            string[] sa = txt.Split(";");

            int sum = 0;
            for (int i = 0; i< sa.Length ; i++)
            {
               Console.WriteLine($"{i}: {sa[i]}");
                int a = Convert.ToInt32(sa[i]);
                sum += a;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
