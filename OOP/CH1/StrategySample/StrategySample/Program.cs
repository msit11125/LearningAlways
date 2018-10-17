using StrategeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySample
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human() { Age = 19, Gender = GenderType.Woman, Height = 1.72, Weight = 58 };
            BMIContext bmicontext = new BMIContext(human);
            Console.WriteLine(bmicontext.BMI);
            Console.WriteLine(bmicontext.Result);

            Console.ReadLine();
        }
    }
}
