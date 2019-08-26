﻿using System;

namespace Opg_80_3_Klasse_bæger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bæger med terninger");
        }
    }

    public class Terning
    {
        // Ved .NET Core behøver den ikke være statisk!!
        private static Random rnd = new Random();
        public int værdi;

        public Terning()
        {
            this.værdi = 1;
        }

        public void Skriv()
        {
            Console.Write("[" + this.værdi + "]");
        }

        public void Ryst()
        {
            this.værdi = rnd.Next(1, 7);
        }
    }

    public class Bæger
    {
        public Terning[] terninger;

        public Bæger()
        {

        }


        public Ryst()
        {

        }

        public Skriv()
        {

        }

    }
}
