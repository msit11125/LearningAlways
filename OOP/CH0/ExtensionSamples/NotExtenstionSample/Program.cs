using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotExtenstionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            { list.Add(i); }
            var result = Enumerable.Sum(Enumerable.Where(list, (x) => x > 5));
            //var result = list.Where((x) => x > 5).Sum((x) => x);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
