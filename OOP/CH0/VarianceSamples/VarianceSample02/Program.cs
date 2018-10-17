using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarianceSample02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Coupe> coupes = new List<Coupe>() { new Coupe() };
            List<Truck> trucks = new List<Truck>() { new Truck() };
            // 以下穩死  => 泛型類別內 沒有共變性
            // List<Car> cars = coupes;

            // 以下可以 => 泛型介面內 可以有共變性
            IEnumerable<Car> cars = coupes;

            coupes.RunIEnumerableCars();
            // 這樣也是不行
            // trucks.RunListCars();
            Console.ReadLine();
        }
    }

    public static class ExtenaionClass
    {
        public static void RunListCars(this List<Car> cars)
        {
            foreach (var car in cars)
            {
                car.Run();
            }
        }


        public static void RunIEnumerableCars(this IEnumerable<Car> cars)
        {
            foreach (var car in cars)
            {
                car.Run();
            }
        }
    }
    public abstract class Car
    {
        public abstract void Run();
    }
    public class Coupe : Car
    {
        public override void Run()
        {
            Console.WriteLine("雙門跑車跑得快");
        }
    }
    public class Truck : Car
    {
        public override void Run()
        {
            Console.WriteLine("卡車跑得慢");
        }
    }
}
