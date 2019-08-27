using System;

namespace Opg_90_Egenskab_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Person
    {
        private int alder;

        public int Alder
        {
            get { return alder; }
            set { alder = value; }
        }

        private string _navn;

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }


    }
}
