using System;
using System.IO;
using System.Xml;

namespace Numbers
{
    // Write code to explore numbers
    class Program
    {
        static void Main(string[] args)
        {
            // ExploreNumbers();
            // CompareDoubleToDecimal();
            // DynamicType();

            AssignLocalVariables(); //sg 50
            InferringVariables();   //sg 51
            MakingValueTypeNullable();  // sg 52
            StoreMultipleValuesInAnArray(); // sg 53
            Console.ReadLine();
        }

        private static void StoreMultipleValuesInAnArray()
        {
            // sg 53
            // declaring the size of the array
            string[] names = new string[4];
            // storing items at index positions
            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Rebecca";
            names[3] = "Tom";
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]); // read the item at this index
            }
        }

        private static void MakingValueTypeNullable()
        {
            // sg 52
            Console.WriteLine($"{default(int)}"); // 0
            Console.WriteLine($"{default(bool)}"); // False
            Console.WriteLine($"{default(DateTime)}"); // 1/01/0001 00:00:00
            //---
            int ICannotBeNull = 4;
            int? ICouldBeNull = null;
            Console.WriteLine(ICouldBeNull.GetValueOrDefault()); // 0
            ICouldBeNull = 4;
            Console.WriteLine(ICouldBeNull.GetValueOrDefault()); // 4
        }

        private static void InferringVariables()
        {
            // sg 50
            var population = 66_000_000; // 66 million in UK
            var weight = 1.88; // in kilograms
            var price = 4.99M; // in pounds sterling
            var fruit = "Apples"; // strings use double-quotes
            var letter = 'Z'; // chars use single-quotes
            var happy = true; // Booleans have value of true or false
        }

        private static void AssignLocalVariables()
        {
            int population = 66_000_000; // 66 million in UK
            double weight = 1.88; // in kilograms
            decimal price = 4.99M; // in pounds sterling
            string fruit = "Apples"; // strings use double-quotes
            char letter = 'Z'; // chars use single-quotes
            bool happy = true; // Booleans have value of true or false
        }

        private static void DynamicType()
        {
            // storing a string in a dynamic object
            dynamic anotherName = "Ahmed";
            // this compiles but might throw an exception at run-time!
            int length = anotherName.Length;
            Console.WriteLine($"Length is : {length}");
        }

        private static void CompareDoubleToDecimal()
        {
            double a = 0.1;
            double b = 0.2;
            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does NOT equal 0.3");
            }
        }

        private static void ExploreNumbers()
        {
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range:\n\n" +
                $"{ int.MinValue:N0} to { int.MaxValue:N0}.\n");

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range:\n\n" +
                $"{ double.MinValue:N0} \n\n  to \n\n { double.MaxValue:N0}.\n");

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range:\n\n " +
                $"{ decimal.MinValue:N0} \n\n to \n\n { decimal.MaxValue:N0}.\n");
        }
    }
}
