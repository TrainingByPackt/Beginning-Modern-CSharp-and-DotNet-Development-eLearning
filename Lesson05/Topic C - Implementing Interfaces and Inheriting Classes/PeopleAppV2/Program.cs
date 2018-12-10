using System;
using Packt.CS7;
using static System.Console;

namespace PeopleAppV2
{
    class Program
    {
        static void Main(string[] args)
        {
            var harry = new Person { Name = "Harry" };
            Person[] people =
            {
                new Person { Name = "Simon" },
                new Person { Name = "Jenny" },
                new Person { Name = "Adam" },
                new Person { Name = "Richard" }
            };
            // DemoImpementingOperator(harry);

            // DemoLocalFunction(harry);

            // DemoIComparable(people);

            // DemoDefiningComparer(people);

            // Exercise: Create class to inherit from Person.
            Employee e1 = new Employee
            {
                Name = "John Jones",
                DateOfBirth = new DateTime(1990, 7, 28)
            };

            // DemoExtendingAndInheritingClasses(e1);

            // Exercise:  Inherit from an exception
            try
            {
                e1.TimeTravel(new DateTime(1999, 12, 31));
                e1.TimeTravel(new DateTime(1950, 12, 25));
            }
            catch (PersonException ex)
            {
                WriteLine(ex.Message);
            }
        }

        private static void DemoExtendingAndInheritingClasses(Employee e1)
        {
            e1.WriteToConsole();

            // Exercise: Add some employee-specific members to extend the class
            e1.EmployeeCode = "JJ001";
            e1.HireDate = new DateTime(2014, 11, 23);
            WriteLine($"{e1.Name} was hired on {e1.HireDate:dd/MM/yy}");

            // Exercise: Override a method
            WriteLine(e1.ToString());

            // Exercise: Implement polymorphism
            Employee aliceInEmployee = new Employee
            { Name = "Alice", EmployeeCode = "AA123" };
            Person aliceInPerson = aliceInEmployee;
            aliceInEmployee.WriteToConsole();
            aliceInPerson.WriteToConsole();
            WriteLine(aliceInEmployee.ToString());
            WriteLine(aliceInPerson.ToString());
        }

        private static void DemoDefiningComparer(Person[] people)
        {
            // Exercise: Define a comparer
            WriteLine("Use PersonComparer's sort implementation:");
            Array.Sort(people, new PersonComparer());
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }
        }

        private static void DemoIComparable(Person[] people)
        {
            // Exercise: Use Icomparable for comparing objects
            WriteLine("Initial list of people:");
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }
            WriteLine("Use Person's sort implementation:");
            Array.Sort(people);
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }
        }

        private static void DemoLocalFunction(Person harry)
        {
            WriteLine($"5! is {harry.Factorial(5)}");
        }

        private static void DemoImpementingOperator(Person harry)
        {
            // Exercise : Implement an operator functionality with a method
            var mary = new Person { Name = "Mary" };
            var baby1 = harry.Procreate(mary);
            var baby2 = harry * mary;
            WriteLine($"{mary.Name} has {mary.Children.Count} children.");
            WriteLine($"{harry.Name} has {harry.Children.Count} children.");
            WriteLine($"{harry.Name}'s first child is named \"{harry.Children[0].Name}\".");
        }
    }
}
