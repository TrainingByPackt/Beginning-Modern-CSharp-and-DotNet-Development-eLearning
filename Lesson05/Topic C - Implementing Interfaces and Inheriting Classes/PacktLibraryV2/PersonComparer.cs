using System.Collections.Generic;
namespace Packt.CS7
{
    // Exercise: Define a comparer
    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int temp = x.Name.Length.CompareTo(y.Name.Length);
            if (temp == 0)
            {
                return x.Name.CompareTo(y.Name);
            }
            else
            {
                return temp;
            }
        }
    }
}