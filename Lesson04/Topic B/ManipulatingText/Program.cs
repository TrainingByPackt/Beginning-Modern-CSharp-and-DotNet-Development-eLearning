using System;
using static System.Console;

namespace ManipulatingText
{
    class Program
    {
        static void Main(string[] args)
        {
            //string city = "London";
            //WriteLine($"{city} is {city.Length} characters long.");

            //CheckStringForContent();

            // Activity B-1
            StripContent();
        }

        private static void StripContent()
        {
            string xmlCities = "<root>" +
                                "<City>New York</City>" +
                                "<City>Chicago</City>" +
                                "<City>S. Francisco</City>" +
                                "<City>New Orleans</City>" +
                                "<City>Dallas</City>" +
                                "</root>";

            string[] cities = xmlCities.Split(new String[] { "<City>", "</City>" }, StringSplitOptions.RemoveEmptyEntries);
            WriteLine("Cities in the xmlCities variable");
            WriteLine("--------------------------------");
            foreach (var city in cities)
            {
                if (city.StartsWith("<")) continue;
                WriteLine(city);
            }
        }

        //Demo: Checking a String for Content
        private static void CheckStringForContent()
        {
            string company = "Microsoft";
            bool startsWithM = company.StartsWith("M");
            bool containsN = company.Contains("N");
            WriteLine($"Starts with M: {startsWithM}, contains an N:{ containsN}");
        }
    }
}
