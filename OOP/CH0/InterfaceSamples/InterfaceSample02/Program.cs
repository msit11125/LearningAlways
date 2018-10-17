using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample02
{
    class Program
    {
        static void Main(string[] args)
        {
            ImplementIPublicProtectedX x = new ImplementIPublicProtectedX();
            Console.WriteLine(x.GetString());
            Console.WriteLine(((IProtected)x).GetString());


            ImplementIPublic obj = new ImplementIPublic();

            // obj.GetString(); => 無法使用
            // 明確實作要確定的介面型別才可使用
            ((IPublic)obj).GetString(); 
            Console.ReadLine();
        }
    }


    public class ReStructInterface : IReStructInterface
    {
        public void AAA()
        {
            
        }

        public void BBB(int i)
        {

        }
    }

    public interface IReStructInterface
    {

        void AAA();
        void BBB(int i);
    }

}
