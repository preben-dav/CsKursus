using System;

namespace Opg_110_2_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[2];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund() { Alder = 5, Navn = "Lady" };
            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn);
            }
        }
    }

    class Hund: IComparable< Hund >
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(Hund h)
        {
            Hund h = obj as Hund;
            return this.Alder.CompareTo(h.Alder);
        }
    }
}