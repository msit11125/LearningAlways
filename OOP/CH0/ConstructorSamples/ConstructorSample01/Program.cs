using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSample01
{
    class Program
    {
        static void Main(string[] args)
        {
            Coupe coupe = new Coupe();
            Truck truck = new Truck(10);
            Console.ReadLine();
        }
    }
}
