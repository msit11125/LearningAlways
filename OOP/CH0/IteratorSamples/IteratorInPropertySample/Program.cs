using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorInPropertySample
{
    class Program
    {
        static void Main(string[] args)

        {
            CustomClass obj = new CustomClass();
            foreach (var item in obj.StringIterator)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
