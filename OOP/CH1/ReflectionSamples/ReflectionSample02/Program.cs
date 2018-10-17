using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionSample02
{
    /// <summary>
    /// 取得方法並執行之
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Object obj = AppDomain.CurrentDomain.CreateInstanceAndUnwrap("TestLibrary", "TestLibrary.Class1");
            MethodInfo[] methods;

            Console.WriteLine("==GetMethods()==");
            methods = obj.GetType().GetMethods();
            ShowResult(methods);
            //執行方法
            Console.WriteLine("==Invoke PublicShow==");
            MethodInfo method = methods.FirstOrDefault((x) => x.Name == "PublicShow");
            Object obj2 = AppDomain.CurrentDomain.CreateInstanceAndUnwrap("TestLibrary", "TestLibrary.Class1");

            method.Invoke(obj2, null);  // 如果是static方法 Invoke第一個參數就會是null
            Console.WriteLine("=======================");
            Console.WriteLine();
            Console.WriteLine("==Invoke PublicShow overloading==");
            method = methods.FirstOrDefault((x) => x.Name == "PublicShow" && x.GetParameters().Count() == 2);
            method.Invoke(obj, new object[] { "ABC" , 7});
            Console.WriteLine("=======================");
            Console.WriteLine();

            Console.WriteLine("==GetMethods() BindingFlag==");
            methods = obj.GetType().GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            ShowResult(methods);

            Console.WriteLine("==Invoke PrivateShow==");
            method = methods.Where((x) => x.Name == "PrivateShow").FirstOrDefault();
            method.Invoke(obj, null);
            Console.WriteLine("=======================");
            Console.WriteLine();

            Console.WriteLine("==GetMethod() BindingFlag==");
            Console.WriteLine(obj.GetType().GetMethod("ProtectedShow", BindingFlags.Instance | BindingFlags.NonPublic).Name);
            Console.WriteLine("=======================");
            Console.WriteLine();

            Console.WriteLine("==GetMethod() and Invoke==");
            Type[] types = new Type[] { typeof(String), typeof (int)};
            method = obj.GetType().GetMethod("PublicShow", types);
            method.Invoke(obj, new object[] { "XYZ",1 });
            Console.WriteLine("=======================");
            Console.WriteLine();



            Console.WriteLine("==GetMethod() and Invoke==");
            Type[] t = new Type[] { typeof(int) };
            method = obj.GetType().GetMethod("GetValue",t);
            var value = method.Invoke(obj, new object[] { 100 });
            Console.WriteLine("=======================");
            Console.WriteLine();



            Console.ReadLine();

        }

        static void ShowResult(MethodInfo[] methods)
        {
            foreach (var m in methods)
            {
                Console.WriteLine(m.Name + ":" + m.ReflectedType.ToString());
            }
            Console.WriteLine("=======================");
            Console.WriteLine();
        }
    }
}
