using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSample01
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Benz
    {
        public void Run()
        {
            Console.WriteLine("Benz Run");
        }
    }

    public class BMW
    {
        public void Run()
        {
            Console.WriteLine("BMW Run");
        }
    }

    public class Driver
    {
        private Benz car;
        public Driver()
        {
            car = new Benz();
        }

        public void Drive()
        {
            car.Run();
        }
    }
}
