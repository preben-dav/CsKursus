using System;

namespace Opg_87_1_Struct_vs_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Struct vs Class");

            Person k1 = new Person();
            Person k2 = new Person();

            k1.Id = 1;
            k2.Id = 2;
            Console.WriteLine($"k1: { k1.Id}   k2: {k2.Id}");

            k1 = k2;
            Console.WriteLine($"k1: { k1.Id}   k2: {k2.Id}");

            k1.Id = 3;
            Console.WriteLine($"k1: { k1.Id}   k2: {k2.Id}");

        }
        class Person  //struct
        {
            public int Id;
        }
    }
}
