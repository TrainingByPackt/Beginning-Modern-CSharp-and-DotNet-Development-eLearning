using System;

namespace Ch2_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Create3x3Array();   // sg 55
        }

        // Create a 3 x 3 array
        private static void Create3x3Array()
        {
            int[,] array = new int[3, 3];
            Random r = new Random();
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    array[i, j] = r.Next();
                    Console.WriteLine(array[i, j]);
                    Console.ReadLine();
                }
            }
        }
    }
}
