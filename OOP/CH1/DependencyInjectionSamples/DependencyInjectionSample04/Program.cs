using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 屬性注入
/// </summary>
namespace DependencyInjectionSample04
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public interface ICar
    {
        void Run();
    }

    public class Benz : ICar
    {

        public void Run()
        {
            Console.WriteLine("Benz Run");
        }
    }

    public class BMW : ICar
    {
        public void Run()
        {
            Console.WriteLine("BMW Run");
        }
    }

    public class Driver
    {
        public ICar Car
        { get; set; }


        public void Run()
        {
            Car.Run();
        }
    }
}
