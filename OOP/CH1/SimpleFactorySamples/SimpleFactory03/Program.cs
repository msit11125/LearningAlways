using SimpleLibrary03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory03
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human() { Age = 19, Gender = GenderType.Man, Height = 1.72, Weight = 58 };
            BMIStrategy strategy = StrategyFactory.GetStrategy(human);

            Console.WriteLine(strategy.BMI.ToString());
            Console.WriteLine(strategy.Result);

            Console.ReadLine();
        }
    }
}
