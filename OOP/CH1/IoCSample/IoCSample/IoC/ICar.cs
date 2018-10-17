using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCSample.IoC
{
    public interface ICar
    {
        void WhoIs();
    }

    internal class Benz : ICar
    {

        public void WhoIs()
        {
            Console.WriteLine("I am Benz");
        }
    }

    internal class BMW : ICar
    {
        public void WhoIs()
        {
            Console.WriteLine("I am BMW");
        }
    }

    public class CarFactory
    {
        public static ICar GetCar(string name)
        {
            switch (name)
            {
                case "BenZ":
                    return new Benz();
                case "BMW":
                    return new BMW();
                default:
                    return null;
            }
        }
    }
}
