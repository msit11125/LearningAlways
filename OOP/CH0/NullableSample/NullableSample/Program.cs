using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> i;
            //int? i;
            //System.Int32? i;
            i = 100;
            Console.WriteLine(i.HasValue.ToString());
            Console.WriteLine(i.Value.ToString());
            Console.WriteLine(i.GetValueOrDefault().ToString());
            i = null;
            Console.WriteLine(i.GetValueOrDefault().ToString());
            Console.ReadLine();
        }
    }
}
