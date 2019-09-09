using System;

namespace Opg_105_3_Arv_Abstrakt_klasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("opg 105.3 Arv (Abstrakt klasse)");

            Person p = new Person() { Id = 1, Navn = "a" };
            Kursist k = new Kursist() { Id = 1, Navn = "a" };
            k.Skriv1();
            k.Skriv2();

        }
    }


    class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }

        public void Skriv1()
        {
            Console.WriteLine($"Person med ID {Id} og navn {Navn}");
        }
    }

    class Kursist : Person
    {
        public void Skriv2()
        {
            Console.WriteLine($"Kursist med ID {Id} og navn {Navn}");
        }
    }
}
