using System;

namespace Opg_125_1_FileSystemWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FileSystemWatcher");

            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            w.Changed += (s,e) => Console.WriteLine("Changed");
            //// bind en metode til w.Changed

            Console.ReadLine();
        }
    }
}
