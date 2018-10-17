using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionSample01
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "ABC" + Environment.NewLine + " " + Environment.NewLine + "CDE";
              var result = str.Splitline();
             // string[] result = ExtensionClass.Splitline(str);
             
            foreach (var s in result)
            {
                Console.WriteLine(s);
            }

            System.Collections.Generic.List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            //System.Linq.Enumerable.Any(System.Linq.Enumerable.Where(list,   (x) => x == 1), (x) => x==7); 
            list.Where((x) => x > 6).Any((x) =>x == 7);

            Console.ReadLine();
        }
    }
}
