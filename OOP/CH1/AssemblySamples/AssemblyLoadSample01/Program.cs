using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyLoadSample01
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadTestLibrary01();
            Console.WriteLine("-------------------------");
            LoadTestLibrary02();

            Console.ReadLine();
        }


        // 以下兩方法作用相同

        private static void LoadTestLibrary01()
        {
            // load by Assembly name [同一個目錄(DEBUG)下]
            AssemblyName name = new AssemblyName("TestLibrary01");
            Assembly asm = Assembly.Load(name);
            Console.WriteLine(asm.FullName);

        }

        private static void LoadTestLibrary02()
        {
            // load by assembly name string
            Assembly asm = Assembly.Load("TestLibrary02");
            Console.WriteLine(asm.FullName);

        }
    }
}
