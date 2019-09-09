using System;


namespace Test
{


    class Program
    {

        static void Main(string[] args)
        {

            Kæledyr k = new Kæledyr() { Navn = "a" };
            Fugl f = new Fugl() { Navn = "Hans", HåndTam = true };
            Hund h = new Hund() { Navn = "Mille", HundeRegisterId = "17" };
            Console.WriteLine(k.Kendelyd());    // ?
            Console.WriteLine(f.Kendelyd());    // ?
            Console.WriteLine(h.Kendelyd());    // 

            Kæledyr t = new Kæledyr() { Navn = "t" };
            t = h;
            Console.WriteLine(t.Kendelyd());    // 
            Hund n = t as Hund;
            Console.WriteLine(n.HundeRegisterId);    // 

        }
    }

    internal class Kæledyr
    {
        public string Navn { get; set; }
        public virtual string Kendelyd()    // bemærk - virtual
        {
            return "?";
        }
    }

    internal class Fugl : Kæledyr
    {
        public bool HåndTam { get; set; }
        public override string Kendelyd()   // bemærk override
        {
            return "Pip";
        }
    }

    internal class Hund : Kæledyr
    {
        public string HundeRegisterId { get; set; }
        public override string Kendelyd()   // bemærk override
        {
            return "Vov";
        }
    }
}
