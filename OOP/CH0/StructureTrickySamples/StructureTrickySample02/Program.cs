using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureTrickySample02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MyStruct> list = new List<MyStruct>();
            MyStruct o = new MyStruct() { X = 1, Y = 1 };
            list.Add(o);  // 此時已複製一份MyStruct 到 List 之中
            o.X = 99;
            Console.WriteLine(list[0].X);  // than print 1
            // list[0].X = 100;  // -> 此行無法成立 struct所引子只能取值
            var a = list[0];
            a.X = 777;
            list[0] = a;
            Console.WriteLine(list[0].X);
            Console.ReadLine();
        }
    }


    public struct MyStruct
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
