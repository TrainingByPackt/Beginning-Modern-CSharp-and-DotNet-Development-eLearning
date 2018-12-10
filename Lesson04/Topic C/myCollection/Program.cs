using System;
using System.Collections.Generic;

namespace myCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person> {
                                    new Person { Name = "John" },
                                    new Person { Name = "Sandy" },
                                    new Person { Name = "Kim" }};
            ShowCollection(people);
        }


       static private void ShowCollection(List<Person> collection)
        {
            foreach (var person in collection)
            {
                Console.WriteLine(person.Name);                
            }

            Console.WriteLine(collection.Count + " " + "people in this collection.");
        }
    }

    class Person {
        public string Name { get; set; }
    }
}
