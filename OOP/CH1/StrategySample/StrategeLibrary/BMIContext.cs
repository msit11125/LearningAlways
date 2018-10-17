using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategeLibrary
{
    /// <summary>
    /// 利用策略上下文封裝工廠
    /// </summary>
    public class BMIContext
    {
        BMIStrategy _strategy;

        public BMIContext(Human human)
        {
            //封裝 Factory 建立實體的過程
            _strategy = StrategyFactory.GetStrategy(human);
        }

        public Double BMI
        {
            get { return _strategy.BMI; }
        }

        public String Result
        {
            get { return _strategy.Result; }
        }
    }
}
