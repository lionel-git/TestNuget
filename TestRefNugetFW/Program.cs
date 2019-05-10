using System;
using TestNuget;

namespace TestRefNuget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var w = new Worker();
            int r = w.DoSumLength(5, 6);
            Console.WriteLine(r);
        }
    }
}
