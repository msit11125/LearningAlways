using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrary02
{
    /// <summary>
    /// BMI Strategy 的抽象
    /// </summary>
    public abstract class BMIStrategy
    {
        //由屬性注入 Human
        public Human Human
        { get; set; }

        protected Double _max;
        protected Double _min;
        private Double _bmi = 0;
        public Double BMI
        {
            get
            {
                GetBMIValue();
                return _bmi;
            }
        }


        private string _result = string.Empty;
        public String Result
        {
            get
            {
                GetBMIValue();
                GetResult();
                return _result;
            }
        }


        private void GetBMIValue()
        {
            if (Human.Weight > 0 && Human.Height > 0)
            { _bmi = Human.Weight / Math.Pow(Human.Height, 2); }
            else
            { _bmi = -1; }
        }

        private void GetResult()
        {
            if (BMI != -1)
            {
                if (BMI > _max)
                {
                    _result = "太胖";
                }
                else if (BMI < _min)
                {
                    _result = "太瘦";
                }
                else
                {
                    _result = "適中";
                }
            }
            else
            {
                _result = "體重或身高不得小於0";
            }
        }

    }
    /// <summary>
    /// 男性 20~25
    /// </summary>
    /// <seealso cref="SimpleLibrary02.BMIStrategy" />
    internal class ManBMIStrategy : BMIStrategy
    {
        public ManBMIStrategy()
        {
            _max = 25;
            _min = 20;
        }
    }

    /// <summary>
    /// 女性 18~22
    /// </summary>
    /// <seealso cref="SimpleLibrary02.BMIStrategy" />
    internal class WomanBMIStrategy : BMIStrategy
    {
        public WomanBMIStrategy()
        {
            _max = 22;
            _min = 18;
        }
    }
    /// <summary>
    /// 隱藏資源的實作, 當 Strategy 擴充, 只要修改此處
    /// </summary>
    internal class StrategyResource
    {
        internal GenderType Gender
        { get; private set; }

        internal BMIStrategy Strategy
        { get; private set; }

        private StrategyResource(GenderType gender, BMIStrategy strategy)
        {
            Gender = gender;
            Strategy = strategy;
        }

        private static List<StrategyResource> _strategies;
        internal static List<StrategyResource> Strategies
        {
            get
            {
                if (_strategies == null)
                {
                    GetStrategies();
                }
                return _strategies;
            }
        }

        private static void GetStrategies()
        {
            _strategies = new List<StrategyResource>();
            _strategies.Add(new StrategyResource(GenderType.Man, new ManBMIStrategy()));
            _strategies.Add(new StrategyResource(GenderType.Woman, new WomanBMIStrategy()));
        }
    }

    /// <summary>
    /// 考慮到不斷擴充的作法
    /// </summary>
    public static class StrategyFactory
    {
        public static BMIStrategy GetStrategy(this Human human)
        {

            //以 性別為條件搜尋策略
            StrategyResource resource = StrategyResource.Strategies.FirstOrDefault((x) => x.Gender == human.Gender);
            if (resource != null)
            {
                resource.Strategy.Human = human;
                return resource.Strategy;
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}
