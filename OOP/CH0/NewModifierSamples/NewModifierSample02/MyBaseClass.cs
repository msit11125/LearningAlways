using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewModifierSample02
{
    internal class MyBaseClass
    {
        public virtual void ShowText()
        {
            Console.WriteLine("Run by MyBaseClass");
        }
    }

    internal class MyDerivedClass1 : MyBaseClass
    {
        public override  void ShowText()
        {
            Console.WriteLine("Run by MyDerivedClass1");
        }
    }

    internal class MyDerivedClass2 : MyDerivedClass1
    {
        // 遮蔽
        new public void ShowText()
        {
            Console.WriteLine("Run by MyDerivedClass2");
        }
    }

    
}
