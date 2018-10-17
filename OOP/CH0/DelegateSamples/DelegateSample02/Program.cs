using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample02
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            SomeAction a = Show;
            obj.DoAction(a, "pass delegate");
            Console.ReadLine();
        }

        public static void Show(string text)
        {
            Console.WriteLine("Show " + text);
        }
    }
}
