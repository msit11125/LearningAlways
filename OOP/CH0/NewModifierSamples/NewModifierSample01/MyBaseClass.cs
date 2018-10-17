using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewModifierSample01
{
    internal class MyBaseClass
    {
        public void ShowText()
        {
            Console.WriteLine("Run by MyBaseClass");
        }
    }

    internal class MyDerivedClass : MyBaseClass
    {
        new public void ShowText()
        {
            Console.WriteLine("Run by MyDerivedClass");
        }
    }
}
