using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyCollectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
           // people.Items = new List<Person>();
            people.Items[0] = new Person() { Name = "Jack", Age = 29 };

            ReadonlyPeople readonlyPeople = new ReadonlyPeople();
           // people[0] = new Person() { Name = "Jack", Age = 29 };
            readonlyPeople.Add(new Person() { Name = "Jack", Age = 29 });
            readonlyPeople.Add(new Person() { Name = "Jack", Age = 31 });
            Console.ReadLine();
        }
    }
}
