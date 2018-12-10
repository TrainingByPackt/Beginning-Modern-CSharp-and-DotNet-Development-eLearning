using Packt.CS7;
using System;
using System.Collections.Generic;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person();
            p1.Name = "Jane Smith";
            p1.DateOfBirth = new DateTime(1975, 12, 22);

            // DemoPerson(p1);

            // SetSharedInterestRate();

            // DemoConstantsConstructors(p1);

            // DemoWriteMethod(p1);

            // DemoMethodWithTuples(p1);

            // DemoPassParameters(p1);

            // DemoOptionalParams(p1);

            // DemoParameterPassing(p1);

            // DemoReadOnlyAndSettablePropertiesIndexers();

            // DemoEvent();
        }

        private static void DemoEvent()
        {
            // Exercise: Define an event
            var harry = new Person
            {
                Name = "Harry",
                DateOfBirth = new DateTime(1982, 1, 7)
            };

            harry.Shout += Harry_Shout;
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();
        }

        private static void Harry_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
        }

        private static void DemoReadOnlyAndSettablePropertiesIndexers()
        {
            //Exercise: Define readonly properties
            var max = new Person
            {
                Name = "Max",
                DateOfBirth = new DateTime(1972, 1, 27)
            };
            //WriteLine(max.Origin);
            //WriteLine(max.Greeting);
            //WriteLine(max.Age);

            //// Exercise: Create a settable property
            //max.FavoriteIceCream = "Chocolate Fudge";
            //WriteLine($"Max's favorite ice-cream flavor is { max.FavoriteIceCream}."); max.FavoritePrimaryColor = "Red";
            //WriteLine($"Max's favorite primary color is { max.FavoritePrimaryColor}.");
            
            // Exercise: Define an indexer
            max.Children.Add(new Person { Name = "Charlie" });
            max.Children.Add(new Person { Name = "Ella" });
            WriteLine($"Max's first child is {max.Children[0].Name}");
            WriteLine($"Max's second child is {max.Children[1].Name}");
            WriteLine($"Max's first child is {max[0].Name}");
            WriteLine($"Max's second child is {max[1].Name}");
        }

        private static void DemoParameterPassing(Person p1)
        {
            // Exercise: Check how parameters are passed
            int a = 10;
            int b = 20;
            int c = 30;
            WriteLine($"Before: a = {a}, b = {b}, c = {c}");
            p1.PassingParameters(a, ref b, out c);
            WriteLine($"After: a = {a}, b = {b}, c = {c}");

            // simplified C# 7 syntax for out parameters
            int d = 10;
            int e = 20;
            WriteLine($"Before: d = {d}, e = {e}, f doesn't exist yet!");
            p1.PassingParameters(d, ref e, out int f);
            WriteLine($"After: d = {d}, e = {e}, f = {f}");
        }

        private static void DemoOptionalParams(Person p1)
        {
            // Exercise: Create a method with optional parameters
            p1.OptionalParameters();
            p1.OptionalParameters("Jump!", 98.5);
            p1.OptionalParameters(number: 52.7, command: "Hide!");
            p1.OptionalParameters("Poke!", active: false);
        }

        private static void DemoPassParameters(Person p1)
        {
            // Exercise: Pass parameters to methods
            WriteLine(p1.SayHello());
            WriteLine(p1.SayHello("Emily"));
        }

        private static void DemoMethodWithTuples(Person p1)
        {
            // Exercise: Define methods with tuples
            Tuple<string, int> fruit4 = p1.GetFruitCS4();
            WriteLine($"There are {fruit4.Item2} {fruit4.Item1}.");
            (string, int) fruit7 = p1.GetFruitCS7();
            WriteLine($"{fruit7.Item1}, {fruit7.Item2} there are.");

            // Exercise: Specify the name of the fields
            var fruitNamed = p1.GetNamedFruit();
            WriteLine($"Are there {fruitNamed.Number} { fruitNamed.Name}?");

            //Exercise: Deconstruct tuples into separate variables
            (string fruitName, int fruitNumber) = p1.GetFruitCS7();
            WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

        }

        private static void DemoWriteMethod(Person p1)
        {
            // Exercise: Write a method
            p1.WriteToConsole();
            WriteLine(p1.GetOrigin());
        }

        private static void DemoConstantsConstructors(Person p1)
        {
            // Exercise: Make a field constant
            WriteLine($"{p1.Name} is a {Person.Species}");

            // Exercise: Make a field read-only
            WriteLine($"{p1.Name} was born on {p1.HomePlanet}");

            // Exercise: Initialize fields with constructors
            var p3 = new Person();
            WriteLine($"{p3.Name} was instantiated at { p3.Instantiated:hh: mm: ss} on { p3.Instantiated:dddd, d MMMM yyyy}");

            var p4 = new Person("Aziz");
            WriteLine($"{p4.Name} was instantiated at { p4.Instantiated:hh: mm: ss} on {p4.Instantiated:dddd, d MMMM yyyy}");
        }

        private static void DemoPerson(Person p1)
        {

            p1.Name = "Bob Smith";
            p1.DateOfBirth = new DateTime(1965, 12, 22);
            WriteLine($"{p1.Name} was born on " +
                $"{p1.DateOfBirth:dddd, d MMMM yyyy}");

            var p2 = new Person
            {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1998, 3, 17)
            };
            WriteLine($"{p2.Name} was born on{ p2.DateOfBirth:d MMM yy}");

            // Exercise: Store a value by using the enum keyword
            p1.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
            WriteLine($"{p1.Name}'s favorite wonder is { p1.FavoriteAncientWonder}");

            // Exercise: Use the enum keyword
            p1.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
            // p1.BucketList = (WondersOfTheAncientWorld)18;
            WriteLine($"{p1.Name}'s bucket list is {p1.BucketList}");

            // Exercise: Use collections to store multiple values
            p1.Children.Add(new Person());
            WriteLine($"{p1.Name} has {p1.Children.Count} children.");
        }

        private static void SetSharedInterestRate()
        {
            // Exercise: Exercise Make a static field
            BankAccount.InterestRate = 0.012M;
            var ba1 = new BankAccount();
            ba1.AccountName = "Mrs. Jones";
            ba1.Balance = 2400;
            WriteLine($"{ba1.AccountName} earned {ba1.Balance * BankAccount.InterestRate:C} interest.");
            var ba2 = new BankAccount();
            ba2.AccountName = "Ms. Gerrier";
            ba2.Balance = 98;
            WriteLine($"{ba2.AccountName} earned {ba2.Balance * BankAccount.InterestRate:C} interest.");
        }
    }
}
