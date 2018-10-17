using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableCompareSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            int y = 0;
            Console.WriteLine(x == y);
            Console.WriteLine(x != null); // !(x == null) 這樣寫在ef會有問題
            Console.WriteLine(x.HasValue);
            Console.ReadLine();
        }
    }
}
