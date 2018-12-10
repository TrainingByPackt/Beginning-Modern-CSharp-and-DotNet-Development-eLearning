using System;
using static System.Console;

namespace Ch02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayOutput();    //sg 57

            GetInput();         //sg 58

            ImportNamespace();  //sg 59
        }

        private static void ImportNamespace()
        {
            // Follow steps on sg 59-60
            throw new NotImplementedException();
        }

        private static void GetInput() 
        {
            //sg 58
            Write("Type your first name and press ENTER: ");
            string firstName = ReadLine();
            Write("Type the page number you are in and press ENTER: ");
            string pg = ReadLine();
            WriteLine($"Hello {firstName}, your page number is {pg}.");
        }

        private static void DisplayOutput() 
        {
            //sg 57
            var population = 66_000_000; // 66 million in UK
            var weight = 1.88; // in kilograms
            var price = 4.99M; // in pounds sterling
            var fruit = "Apples"; // strings use double-quotes
            WriteLine($"The UK population is {population}.");
            Write($"The UK population is {population:N0}. ");
            WriteLine($"{weight}kg of {fruit} costs {price:C}.");
            Console.ReadLine();
        }
    }
}
