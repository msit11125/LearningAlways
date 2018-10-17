using SampleLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human() { Age = 19, Gender = GenderType.Woman, Height = 1.72, Weight = 58 };
            IBMIFactory bmifactory = new WomanBMIFactory();
            BMIStrategy bmistrategy = bmifactory.GetStrategy(human);
            Console.WriteLine(bmistrategy.BMI.ToString());
            Console.WriteLine(bmistrategy.Result);
            Console.WriteLine();

            IStandardWeightFactory weightFactory = new WomanStandardWeightFactory();
            StandardWightStrategy weightStrategy = weightFactory.GetStrategy(human);
            Console.WriteLine(weightStrategy.StandardWeight.ToString());  

            Console.ReadLine();
        }
    }
}
