using System;

namespace Opg_90_3_Egenskaber_automatisk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Egenskaber automatisk");

            Person p = new Person();

            p.ForNavn = "Ib";
            p.EfterNavn = "Bæk";
            Console.WriteLine(p.FuldtNavn());
            Console.WriteLine(p.FN);

        }

    }

    class Person
    {
        public string ForNavn { get; set; }

        private string _efterNavn;

        public string EfterNavn
        {
            get { return _efterNavn; }
            set { _efterNavn = value; }
        }

        public string FuldtNavn()
        {
            return this.ForNavn + " " + this.EfterNavn;
        }

        private string _fn;

        public string FN
        {
            get { return this.FuldtNavn(); }
//            set { _fn = value; }
        }



    }
}
