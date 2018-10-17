using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterSample01
{
    class Program
    {
        static void Main(string[] args)
        {          
            int x = 0;
            Console.WriteLine(string.Format("x 的初始值為 {0}", x));
            int y = ChangeX(x);
            Console.WriteLine(string.Format("退出 ChangeX 方法回到 Main 方法後, x 的值為 {0}", x));
            Console.ReadLine();
        }

        private static int ChangeX(int x)
        {
            Console.WriteLine(string.Format("進入 ChangeX 方法的時候, x 的值為 {0}", x));
            x = 10;
            Console.WriteLine(string.Format("在 ChangeX 方法重新指派後, x 的值為 {0}", x));
            return x;
        }

    }
}
