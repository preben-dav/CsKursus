using System;
using System.Linq;

namespace Opg_150_1_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ");

            var people = MCronberg.PersonRepositoryStatic.JustGetPeople();
            //foreach (var person in people)
            //    Console.WriteLine(person.Name);

            Console.WriteLine("----- Top 10 usorteret ------");

            foreach (var person in people.Take(10)) Console.WriteLine(person.Name);

            Console.WriteLine("----- Top 10 navne ------");

            foreach (var person in people.OrderBy(p => p.Name).Take(10)) Console.WriteLine(person.Name);

            Console.WriteLine("----- Top 10 køn ------");

            foreach (var person in people.OrderBy(p => p.Gender).ThenBy(p => p.Name).Take(10)) Console.WriteLine(person.Name + " " + person.Gender);

            Console.WriteLine("----- Højde < 170 ------");

            foreach (var person in people.Where(p => p.Height < 170)) Console.WriteLine(person.Name + " " + person.Height);

            Console.WriteLine("----- Højde <= 170 og rask ------");

            foreach (var person in people.Where(p => (p.Height < 170) && (p.IsHealthy))) Console.WriteLine(person.Name + " " + person.IsHealthy);

            Console.WriteLine("----- grupperet på køn ------");

            var res = people.GroupBy(p => p.Gender);
            foreach (var grp in res)
            {
                Console.WriteLine(grp.Key);
                foreach (var person in grp)
                {
                    Console.WriteLine(" - " + person.Name + " " +person.Gender );
                }
            }

            Console.WriteLine("----- returner kun navn og højde ------");

            var a = people.OrderBy(p => p.Name).Select(p => new { Name = p.Name, Height = p.Height });
            foreach (var person in a) Console.WriteLine(person.Name);

            var g = people.GroupBy(p => p.Height / 10).OrderBy(x => x.Key);
            foreach (var grp in g)
            {
                Console.WriteLine(grp.Key * 10);
                foreach (var person in grp)
                {
                    Console.WriteLine(" - " + person.Name);
                }
            }

        }
    }
}
