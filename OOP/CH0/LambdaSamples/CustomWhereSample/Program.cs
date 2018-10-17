using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomWhereSample.TestLIB;

namespace CustomWhereSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<string>() { "bill", "david", "john" };
            var result = data.DoWhere((x) => x == "john");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
