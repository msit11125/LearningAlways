using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample03
{
    class Program
    {
        private delegate int SomeDelegate();
        static void Main(string[] args)
        {

            SomeDelegate method = Method01;
            method += Method02;
            method += Method03;
            int value = method.Invoke();   //這裡回傳結果只會是3
            Console.WriteLine("Result : " + value.ToString());
            Console.ReadLine();
            // click enter


            foreach (var d in method.GetInvocationList())  //取出來一個一個執行 就可以顯示 1 2 3
            { Console.WriteLine(d.Method.Invoke(null, null)); }
            //{ Console.WriteLine(d.DynamicInvoke()); }
            Console.ReadLine();
        }

        private static int Method01()
        { return 1; }

        private static int Method02()
        { return 2; }

        private static int Method03()
        { return 3; }
    }
}
