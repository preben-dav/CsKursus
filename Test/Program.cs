using System;
using System.Collections.Generic

namespace Test
{

    public enum Køn
    {
        Kvinde,
        Mand
    }
    class Program
    {

        static void Main(string[] args)
        {

            string[] a = { "1", "a", "c" };

            System.Collections.Generic.List<string> b = new System.Collections.Generic.List<string>();

            b.Add("a");
            b.Add("b");
            b.Add("c");
            b.Insert(1, "x");

            List<int> i = new List<int>();

            try
            {
                Console.WriteLine("Test");

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
