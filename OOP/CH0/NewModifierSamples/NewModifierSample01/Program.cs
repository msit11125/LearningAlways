using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewModifierSample01
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass o1 = new MyDerivedClass();
            o1.ShowText();

            MyBaseClass o2 = o1;
            o2.ShowText();

            Console.ReadLine();
        }
    }
}
