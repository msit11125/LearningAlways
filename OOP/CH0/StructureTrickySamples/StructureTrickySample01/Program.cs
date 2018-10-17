using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureTrickySample01
{
    class Program
    {
        static void Main(string[] args)
        {
          
            MyStruct a = new MyStruct() { X = 1, Y = 1 };
            var b = a;
            b.X = 2;
            Console.WriteLine(string.Format("a.X = {0}", a.X));
            Console.WriteLine(string.Format("b.X = {0}", b.X));
            Console.ReadLine();
        }
    }

    public struct MyStruct
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
