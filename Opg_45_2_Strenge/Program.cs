using System;

namespace Opg_45_2_Strenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Preben";
            Console.WriteLine(fornavn);
            string efternavn = "Bertelsen";
            Console.WriteLine(efternavn);
            string samletNavn = fornavn + " " + efternavn;
            Console.WriteLine(samletNavn);
            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);
            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);
            string kortEfternavn = efternavn.Substring(0, 4);
            Console.WriteLine(kortEfternavn);

            string test = fornavn + "\t" + efternavn + "\n" + "ny linie";
            Console.WriteLine(test);

            System.IO.File.WriteAllText("c:\\kursus\\CsKursus\\Opg_45_2_Strenge\\test.txt", samletNavn);

            string samletNavn2 = $"{fornavn} {efternavn}";
            Console.WriteLine(samletNavn2);
        }
    }
}
