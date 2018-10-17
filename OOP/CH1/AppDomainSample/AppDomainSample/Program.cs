using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Object obj1 = AppDomain.CurrentDomain.CreateInstanceAndUnwrap("TestLibrary01", "TestLibrary01.Class1");
            Console.WriteLine(obj1.GetType().ToString());
            Console.WriteLine("============================");
            Object obj2 = AppDomain.CurrentDomain.CreateInstanceAndUnwrap("TestLibrary02", "TestLibrary02.Class2");
            Console.WriteLine(obj2.GetType().ToString());
            Console.WriteLine("============================");

            //  CreateInstance 方法 型別會得到 ObjectHandle

            Object obj3 = Activator.CreateInstance("TestLibrary02", "TestLibrary02.Class2");
            Object obj4 = Activator.CreateInstance("TestLibrary02", "TestLibrary02.Class2").Unwrap();

            Console.WriteLine(obj3.GetType().ToString());
            Console.WriteLine(obj4.GetType().ToString());

            Console.WriteLine("============================");

            ObjectHandle objhandle = AppDomain.CurrentDomain.CreateInstance("TestLibrary02", "TestLibrary02.Class2");
            Console.WriteLine(objhandle.GetType().ToString());
            Console.WriteLine(objhandle.Unwrap().GetType().ToString());

            Console.ReadLine();
        }
    }
}
