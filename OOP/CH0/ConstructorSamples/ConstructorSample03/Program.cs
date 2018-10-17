using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSample03
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck t1 = new Truck();
            Console.WriteLine(t1.ToString());
            Truck t2 = new Truck(10);
            Console.WriteLine(t2.ToString());
            Truck t3 = new Truck(12, 5000);
            Console.WriteLine(t3.ToString());

            Console.ReadLine();
        }
    }
}
