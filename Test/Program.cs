using System;

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
            string person1Navn = "Mathias";
            int person1Alder = 12;
            Test.Køn person1Køn = Test.Køn.Mand;

            string person2Navn = "Lene";
            int person2Alder = 53;
            Test.Køn person2Køn = Test.Køn.Kvinde;


            // Fra enum til tekst, til nummer og retur
            Test.Køn køn = Test.Køn.Kvinde;
            Console.WriteLine($"køn = {køn.ToString()}");
            int kode = (int)køn;
            Console.WriteLine($"kode = {kode}");
            kode = 1;
            Test.Køn køn2 = (Test.Køn)kode;
            Console.WriteLine($"køn2 = {køn2}");
            Console.WriteLine($"kode køn2 = {(int)køn2}");

        }
    }
}
