using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyCollectionSample
{
    public class Person
    {
        public String Name
        { get; set; }

        public int Age
        { get; set; }
    }


    public class People
    {
        private List<Person> _items = new List<Person>();

        public List<Person> Items
        {
            get { return _items; }
        }

        public People()
        {
            SetDataToItems();
        }

        private void SetDataToItems()
        {
            _items = new List<Person>();
            _items.Add(new Person() { Name = "Andy", Age = 28 });
            _items.Add(new Person() { Name = "Bill", Age = 30 });

        }
    }

    public class ReadonlyPeople
    {
        private List<Person> _items = new List<Person>();

        public ReadonlyPeople()
        {
            SetDataToItems();
        }
        public Person this[int index]
        {
            get { return _items[index]; }

        }

        private void SetDataToItems()
        {
            _items = new List<Person>();
            _items.Add(new Person() { Name = "Andy", Age = 28 });
            _items.Add(new Person() { Name = "Bill", Age = 30 });

        }

        public void Add(Person person)
        {
            var result = _items.Any((x) => x.Name == person.Name);

            if (result)
            {
                Console.WriteLine("不要瞎搞 !!!");
            }
            else
            {
                _items.Add(person);
                Console.WriteLine("成功");
            }


        }


    }
}
