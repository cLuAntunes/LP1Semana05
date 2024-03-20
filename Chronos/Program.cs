using System;
using System.Diagnostics;
using System.Threading; 

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();
            Thread.Sleep(600);

            crono2.Start();
            Thread.Sleep(200);

            crono1.Stop();
            crono2.Stop();

            double tempoC1 = crono1.Elapsed.TotalSeconds;
            double tempoC2 = crono2.Elapsed.TotalSeconds;
            
            Console.WriteLine($"{tempoC1:f3}");
            Console.WriteLine($"{tempoC2:f3}");
        }
    }
}
