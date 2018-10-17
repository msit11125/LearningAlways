using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionSample04
{
    /// <summary>
    /// 取得類別所實作的介面
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Object obj = AppDomain.CurrentDomain.CreateInstanceAndUnwrap("TestLibrary", "TestLibrary.Class1");

            Type[] types;
            Console.WriteLine("==GetInterfaces()==");
            types = obj.GetType().GetInterfaces();
            ShowResult(types);

            Console.WriteLine("==GetInterface()==");
            Type type = obj.GetType().GetInterface("IText", true); 
            type.GetMethods()[0].Invoke(obj, null);  // 引發實作的方法

            Console.ReadLine();

        }

        static void ShowResult(Type[] types)
        {
            foreach (var t in types)
            {
                Console.WriteLine(t.Name);
            }
            Console.WriteLine("=======================");
            Console.WriteLine();
        }
    }
}
