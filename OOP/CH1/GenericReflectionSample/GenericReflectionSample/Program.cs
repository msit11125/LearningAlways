using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GenericReflectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = AppDomain.CurrentDomain.Load("GenericLibrary");
            Type type1 = asm.GetType("GenericLibrary.GernericType`1"); // `1   代表: 1個泛型參數
            Type type11 = type1.MakeGenericType(new Type[] { typeof(String) }); // 把String給T: GernericType<string>
            Console.WriteLine(type11.FullName);
            Console.WriteLine("=======================");
            Console.WriteLine();


            Object obj = Activator.CreateInstance(type11);
            foreach (var t in obj.GetType().GetGenericArguments())
            {
                Console.WriteLine(t.ToString());
            }

            Console.WriteLine("=======================");
            Console.WriteLine();


            Type type2 = asm.GetType("GenericLibrary.DualGenericType`2"); // `2   代表: 2個泛型參數
            Type type21 = type2.MakeGenericType(new Type[] { typeof(Object), typeof(Int32) });
            Console.WriteLine(type21.FullName);
            Console.WriteLine("=======================");
            Console.WriteLine();

            obj = Activator.CreateInstance(type21);
            foreach (var t in obj.GetType().GetGenericArguments())
            {
                Console.WriteLine(t.ToString());
            }
            Console.WriteLine("=======================");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
