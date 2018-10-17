using FactoryLibrary;
using InterfaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFactorySample02
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = GenericFactory.CreateInastance<Human>("ImplementationLibrary", "ImplementationLibrary.Woman");
            human.Height = 1.72;
            human.Weight = 58;
            Console.WriteLine(human.BMI);
            Console.WriteLine(human.Result);

            Console.ReadLine();
        }
    }
}
