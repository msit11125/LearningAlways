using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingSample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass o1 = new MyDerivedClass();
            o1.Add(1, 1);
            o1.Add("A", "B");

            Console.ReadLine(); 
        }
    }
}
