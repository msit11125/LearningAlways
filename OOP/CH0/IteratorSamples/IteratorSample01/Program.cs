using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorSample01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 一開始指向 -1
            var data = GetNext();
            data.MoveNext();
            Console.WriteLine(data.Current);
            data.MoveNext();
            Console.WriteLine(data.Current);
            data.MoveNext();
            Console.WriteLine(data.Current);
            data.MoveNext();
            Console.WriteLine(data.Current);

            Console.ReadLine();

            var list = GetNextString().ToList();

            foreach (string s in list)
            {
                var index = list.IndexOf(s);

                Console.WriteLine(s);
            }
            Console.ReadLine();


            List<string> numList = new List<string>() { "A", "A", "B", "C" };

            var numList2 = numList.Where(x => x == "A").ToList();
            foreach(var k in numList2)
            {
                numList.Remove(k); // 要ToList才可以
            }
        }

        public static IEnumerator<string> GetNext()
        {
            yield return "A";
            yield return "B";
            yield return "C";
            yield return "D";
            yield return "E";
        }

        //這個比較常見
        public static IEnumerable<string> GetNextString()
        {
            yield return "A";
            yield return "B";
            yield return "C";
            yield return "D";
            yield return "E";
        }
    }

    
}
