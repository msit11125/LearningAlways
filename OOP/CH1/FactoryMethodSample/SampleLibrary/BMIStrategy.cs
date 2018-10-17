using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLibrary
{
    /// <summary>
    /// 計算 BMI 的抽象類別
    /// </summary>
    public abstract class BMIStrategy
    {
        // 由建構子注入 Human
        protected Human _human;
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

            if (_human.Weight > 0 && _human.Height > 0)
            { _bmi = _human.Weight / Math.Pow(_human.Height, 2); }
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
    /// 男性 BMI 的計算邏輯
    /// </summary>
    /// <seealso cref="SampleLibrary.BMIStrategy" />
    internal sealed class ManBMIStrategy : BMIStrategy
    {
        public ManBMIStrategy(Human human)
        {
            _human = human;
            _max = 25;
            _min = 20;
        }
    }

    /// <summary>
    /// 女性 BMI 的計算邏輯
    /// </summary>
    /// <seealso cref="SampleLibrary.BMIStrategy" />
    internal sealed class WomanBMIStrategy : BMIStrategy
    {
        public WomanBMIStrategy(Human human)
        {
            _human = human;
            _max = 22;
            _min = 18;
        }
    }
}
