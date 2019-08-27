using System;

namespace Opg_105_1_Arv_polymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arv polymorfi");

            Faktura f = new Faktura();
            f.Nr = 17;
            f.Dato = DateTime.Now.Date;
            f.Kunde = "Hans";
            Console.WriteLine(f.ToString());

        }
    }

    class Faktura
    {
        public int Nr { get; set; }
        public DateTime Dato { get; set; }
        public string Kunde { get; set; }

        public override string ToString()
        {
            return $"Faktura til {Kunde} nr {Nr} fra {Dato:D}";
        }
    }
}
