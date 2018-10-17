using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDependencySample.Library
{
    public interface ITest
    {
        void Do();
    }

    internal class ATestClass : ITest
    {
        public void Do()
        {
            Console.WriteLine("ATest Class Action");
        }
    }

    internal class BTestClass : ITest
    {
        public void Do()
        {
            Console.WriteLine("BTest Class Action Begin");
            Console.WriteLine("Running");
            Console.WriteLine("BTest Class Action End");
        }
    }

    public class TestFactory
    {
        public static ITest GetTestInstance()
        {
            return new ATestClass();
        }
    }
}
