using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectMany
{

    class Program
    {

        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> list2 = new List<int>() { 6, 4, 2, 7, 9, 0 };

            // SelectMany with list2.    
            // query1 等同 query2
            var query1 = list1.SelectMany(o => list2, (a, b) => new { a, b });
            var query2 = from item1 in list1
                         from item2 in list2
                         select new { a = item1, b = item2 };



            foreach (var q in query1)
            {
                Console.WriteLine("{0}", q);
            }

            Console.WriteLine("============================================================");

            foreach (var q in query2)
            {
                Console.WriteLine("{0}", q);
            }
            // 結果: 6, 4, 2, 7, 9, 0 會輸出6次
            Console.ReadLine();



        }
    }
}
