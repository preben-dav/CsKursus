using System;
using System.Collections.Generic;

namespace Opg_90_0_Konto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konto");

            Konto k = new Konto();

            k.TilføjTransaktion(new Transaktion(new DateTime(2019, 1, 1), "Indsat", 100));
            k.TilføjTransaktion(new Transaktion(new DateTime(2019, 1, 1), "Indsat", 100));
            k.TilføjTransaktion(new Transaktion(new DateTime(2019, 1, 1), "Hævet", -75));
            Console.WriteLine(k.Saldo());

            List<Transaktion> l = k.KopiAfTransaktioner();
            
        }
    }

    public class Transaktion
    {
        //felter
        public DateTime dato;
        public string tekst;
        public decimal beløb;

        public Transaktion(DateTime dato, string tekst, decimal beløb)
        {
            this.dato = dato;
            this.tekst = tekst;
            this.beløb = beløb;
        }
    }

    public class Konto
    {
        private List<Transaktion> transaktioner;

        public decimal Saldo()
        {
            decimal  sum = 0;
            foreach (var item in transaktioner)
            {
                sum += item.beløb;
            }
            return sum;
        }

        public List<Transaktion> KopiAfTransaktioner()
        {
            return transaktioner;
        }


        public void TilføjTransaktion(Transaktion t)
        {
            transaktioner.Add(t);
        }


        public Konto()
        {
            transaktioner = new List<Transaktion>();
        }
    }
}
