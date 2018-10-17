using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerSample01
{
    public class Person
    {
        public String Name
        { get; set; }

        public int Age
        { get; set; }
    }

    // 聚合 Collection 的用法
    public class People
    {
        private List<Person> _items = new List<Person>();
        public List<Person> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        // 可以用原有的 Index
        public Person this[int index]
        {
            get { return _items[index]; }
            set { _items[index] = value; }
        }

        // 也可以自訂
        public Person this[string name]
        {

            get
            {
                return _items.FirstOrDefault((x) => x.Name == name);
            }
            set
            {
                var item = _items.FirstOrDefault((x) => x.Name == name);
                if (item != null)
                {
                    item = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
    }


    // 繼承 Collection 的用法 (但一般比較不會用，通常使用上面的)
    public class PeopleCollection : List<Person>
    {
        public Person this[String name]
        {
            get
            {
                return this.FirstOrDefault((x) => x.Name == name);
            }
            set
            {
                var item = this.FirstOrDefault((x) => x.Name == name);
                if (item != null)
                {
                    item = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
    }
}
