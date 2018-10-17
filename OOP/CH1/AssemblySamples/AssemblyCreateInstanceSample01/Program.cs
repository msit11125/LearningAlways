using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyCreateInstanceSample01
{
    class Program
    {

        // 反射(Reflection)定義: 直接把型別物件拿來用

        static void Main(string[] args)
        {
            Assembly asm = Assembly.Load("TestLibrary02");
            Object obj = asm.CreateInstance("TestLibrary02.Class1");
            Console.WriteLine(obj.GetType().ToString()); //GetType() 可取得Object真正的型別
            Console.ReadLine();
        }
    }
}
