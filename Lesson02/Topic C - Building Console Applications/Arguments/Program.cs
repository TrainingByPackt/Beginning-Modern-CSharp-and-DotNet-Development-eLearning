using System;
using static System.Console;

namespace Ch02_Arguments // sg 60-61
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"There are {args.Length} arguments.");   // sg 62

            foreach (string arg in args)      // sg 63-65 
            {
                WriteLine(arg);
            }
        }
    }
}
