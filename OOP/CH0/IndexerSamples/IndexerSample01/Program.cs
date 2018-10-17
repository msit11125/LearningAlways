using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerSample01
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            people.Items.Add(new Person() { Name = "Andy", Age = 28 });
            people.Items.Add(new Person() { Name = "Bill", Age = 30 });
           

            Console.WriteLine(people[1].Name);
            Console.WriteLine(people["Andy"].Age);
            Console.ReadLine();

            people["Andy"].Age = 17;
            Console.WriteLine(people["Andy"].Age);
            Console.ReadLine();         

            PeopleCollection pcollection = new PeopleCollection();
            pcollection.Add(new Person() { Name = "Andy", Age = 28 });
            pcollection.Add(new Person() { Name = "Bill", Age = 30 });
            Console.WriteLine(pcollection[1].Name);
            Console.WriteLine(pcollection["Andy"].Age);
            Console.ReadLine();
        }
    }
}
