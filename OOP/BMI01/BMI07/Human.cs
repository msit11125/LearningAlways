using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BMI07
{
    public enum GenderType
    {
        Man = 1,
        Woman = 2
    }

    public class Human
    {
        public Double Weight
        { get; set; }

        public Double Height
        { get; set; }

        public GenderType Gender
        { get; set; }

        public int Age
        { get; set; }
    }

    public abstract class BMIStrategy
    {

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
    /// 隱藏實做, 直接在建構子建立條件
    /// </summary>
    internal class ManBMIStrategy : BMIStrategy
    {
        public ManBMIStrategy()
        {
            _max = 25;
            _min = 20;
        }
    }

    internal class WomanBMIStrategy : BMIStrategy
    {
        public WomanBMIStrategy()
        {
            _max = 22;
            _min = 18;
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
            StrategyResource resource = StrategyResource.Strategies.Where((x) => x.Gender == human.Gender).FirstOrDefault();
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

    //隱藏資源的實作, 當 Strategy 擴充, 只要修改此處
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

        //策略集合, 單例
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
}
