using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodModifierSample01
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass1 o1 = new MyDerivedClass1();
            o1.Draw();

            MyBaseClass  o2 = o1;
            o2.Draw();

            MyBaseClass o3 = new MyDerivedClass2();
            o3.Draw();
            //o3.CXO -> 不成立，要轉型  => ((MyDerivedClass2)o3).CXO

            //這就是依賴抽象

            Console.ReadLine();

        }
    }
}
