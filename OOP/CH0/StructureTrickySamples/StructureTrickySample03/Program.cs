using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureTrickySample03
{
    class Program
    {
        static void Main(string[] args)
        {
            // array 是直接取位置   和   List 取內容值不同
            MyStruct[] array = new MyStruct[2];
            array[0].X = 100;
            var o = array[0];
            o.X = 888;

            Console.WriteLine(o.X); // array[0].X

            
            array[0].X = 999;
            Console.WriteLine(array[0].X);
            Console.ReadLine();
        }
    }


    public struct MyStruct
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
