using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ActivatorSample01
{
    class Program
    {
        static void Main(string[] args)
        {
            Object obj;
            // Activator.CreateInstance (String, String) , 這個回傳是 ObjectHandle
            obj = Activator.CreateInstance("TestLibrary", "TestLibrary.Class1").Unwrap();
            Console.WriteLine(obj.GetType().GetProperty("Text").GetValue(obj).ToString());
            Console.WriteLine();

            // Activator.CreateInstance(Type), 這個回傳是 Object
            Assembly asm = Assembly.Load("TestLibrary");
            Type type = asm.GetType("TestLibrary.Class1");
            obj = Activator.CreateInstance(type);
            Console.WriteLine(obj.GetType().GetProperty("Text").GetValue(obj).ToString());
            Console.WriteLine();

            //  Activator.CreateInstance(Type, Object[]), 這個回傳是 Object
            obj = Activator.CreateInstance(type, new Object[] { "XYZ" });
            Console.WriteLine(obj.GetType().GetProperty("Text").GetValue(obj).ToString());
            Console.WriteLine();

            //  Activator.CreateInstance(Type, Boolean), 這個回傳是 Object, 呼叫 私有建構式
            Type ptype = asm.GetType("TestLibrary.Class2");
            Object pobj = Activator.CreateInstance(ptype, true);
            Console.WriteLine(pobj.GetType().GetProperty("Text").GetValue(pobj).ToString());
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
