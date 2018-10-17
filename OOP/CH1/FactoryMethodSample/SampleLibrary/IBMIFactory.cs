using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLibrary
{
    /// <summary>
    /// 建立 BMI 計算的抽象工廠
    /// </summary>
    public interface IBMIFactory
    {
        BMIStrategy GetStrategy(Human human);
    }

    public class ManBMIFactory : IBMIFactory
    {

        public BMIStrategy GetStrategy(Human human)
        {
            return new ManBMIStrategy(human);
        }
    }

    public class WomanBMIFactory : IBMIFactory
    {

        public BMIStrategy GetStrategy(Human human)
        {
            return new WomanBMIStrategy(human);
        }
    }
}
