using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSample03
{
    public class Truck
    {
        protected int _wheels;
        protected int _displacement;

        public Truck()
            : this(8, 3500)
        { }

        public Truck(int wheels)
            : this(wheels, 3500)
        { }

        public Truck(int wheels, int displacement)

        {
            _wheels = wheels;
            _displacement = displacement;
        }

        public override string ToString()
        {
            return string.Format("{0} : {1}", _wheels, _displacement);
        }
    }
}
