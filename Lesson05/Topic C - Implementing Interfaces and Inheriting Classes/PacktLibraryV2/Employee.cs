using System;
using static System.Console;
namespace Packt.CS7
{

    // Exercise: Create a new class that inherits from Person.
    public class Employee : Person
    {
        public DateTime DateOfBirth;
        // Exercise: Add some employee-specific members to extend the class
        public string EmployeeCode { get; set; }
        public DateTime HireDate { get; set; }

        public void WriteToConsole()
        {
            WriteLine($"{Name}'s birth date is {DateOfBirth: dd/MM/yy} and hire date was { HireDate: dd/MM/yy}");
        }
        
        // Exercise: Implement polymorphism
        public override string ToString()
        {
            return $"{Name}'s code is {EmployeeCode}";
        }

    }
}