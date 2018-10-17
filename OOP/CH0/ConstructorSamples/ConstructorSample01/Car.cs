using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSample01
{

    public class Car
    {
        protected int _wheels;
        public Car()
        { _wheels = 4; }
    }

    public class Coupe : Car
    {
        public Coupe()
        { Console.WriteLine("Coupe" + _wheels.ToString()); }
    }

    public class Truck : Car
    {
        public Truck(int wheels)
        {
            _wheels = wheels;
            Console.WriteLine("Truck: " + _wheels.ToString());
        }
    }



}
