using SimpleLibrary01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory01
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human() { Age = 19, Gender = GenderType.Woman, Height = 1.72, Weight = 58 };
            BMIStrategy strategy = human.GetStrategy();

            //在外部看不到衍生的 Strategy
            //BMIStrategy s = new ManBMIStrategy();

            Console.WriteLine(strategy.BMI.ToString());
            Console.WriteLine(strategy.Result);

            Console.ReadLine();
        }
    }
}
