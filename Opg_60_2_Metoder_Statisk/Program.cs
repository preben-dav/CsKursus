using System;

namespace Opg_60_2_Metoder_Statisk
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "c:/temp/test.txt";

            Console.WriteLine("Metoder (statisk)");

            bool res_exists = System.IO.File.Exists(path);
            Console.WriteLine(res_exists);

            string s = System.IO.File.ReadAllText(path);
            Console.WriteLine(s);

            var fil = new System.IO.FileInfo(path);
            DateTime tid = fil.LastAccessTime;
            Console.WriteLine($"Tid: {tid}");
            string ext = fil.Extension;
            Console.WriteLine($"Extension: {ext}");
        }
    }
}
