﻿using System;

namespace Opg_120_3_Delegates_log
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegates (Log)");

            Maskine m = new Maskine();
            m.Log = Console.WriteLine;
            m.Log += AppendLog;
            m.Start();
            m.Stop();

        }
        static void AppendLog(string txt)
        {
            // Kræver at c:\temp findes i forvejen!
            System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");
            //test
        }
    }

    public delegate void LogDelegate(string s);

    public class Maskine
    {

        public LogDelegate  Log { get; set; }

        public void Start()
    {
        Log?.Invoke         
    }



}

}
