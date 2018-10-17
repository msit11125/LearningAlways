using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewModifierSample02
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass2 o1 = new MyDerivedClass2();
            o1.ShowText();


            // 遮蔽 => 盡量不要用
            MyBaseClass o2 = o1;
            o2.ShowText(); // 會找到有overide的方法

            Console.ReadLine();
        }
    }
}
