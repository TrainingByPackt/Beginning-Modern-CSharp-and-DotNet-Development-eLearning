using System.Text.RegularExpressions;
using static System.Console;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter the page number you are in: ");
            string input = ReadLine();
            Regex pageChecker = new Regex(@"^\d");
            if (pageChecker.IsMatch(input))
            {
                WriteLine("Thank you!");
            }
            else
            {
                WriteLine($"This is not a valid page number: {input}");
            }
        }
    }
}
