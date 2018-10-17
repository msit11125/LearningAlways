using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodModifierSample01
{
    public abstract class MyBaseClass
    {
        //  abstract 方法只能存在於 abstract class 中
        public abstract int Add(int x, int y);

        public virtual void Draw()
        {
            Console.WriteLine("Draw base");
        }

        public void Play()
        {

        }
    }

    public class MyDerivedClass1 : MyBaseClass
    {

        public override int Add(int x, int y)
        {
            return x + y;
        }

    }

    public class MyDerivedClass2 : MyBaseClass
    {
        public sealed override int Add(int x, int y)
        {
            return x + y;
        }

        public override void Draw()
        {
            Console.WriteLine("Draw 2");
        }

        public void CXO()
        {

        }
    }

    public class MyDerivedClass3 : MyDerivedClass2
    {
       
        public override void Draw()
        {
            Console.WriteLine("Draw 3");
        }

    }
}
