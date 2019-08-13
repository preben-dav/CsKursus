using System;

namespace Opg_65_2_EgneExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(SmartToUpper("mikkel"));
                Console.WriteLine(SmartToUpper("mAtHiAs"));

                // prøv også 
                Console.WriteLine(SmartToUpper(""));
                // eller
                Console.WriteLine(SmartToUpper(null));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Der er sket en fejl: " + ex.Message);
            }
        }

        static string SmartToUpper(string tekst)
        {
            string s1,s2,s;
            s1 = tekst.Substring(0, 1).ToUpper();
            s2 = tekst.Substring(1, tekst.Length-1).ToLower();
            s = s1 + s2;

            return s;
        }
    }
}
