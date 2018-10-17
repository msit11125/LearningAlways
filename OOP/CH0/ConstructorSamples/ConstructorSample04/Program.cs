using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSample04
{
    class Program
    {
        static void Main(string[] args)
        {
            // 會出現 NullReferenceException
            Truck truck = new Truck();

            Console.ReadLine();
        }
    }
}
