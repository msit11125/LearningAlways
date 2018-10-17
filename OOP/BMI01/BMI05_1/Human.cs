using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI05_1
{
    internal class GenderBoundaryAttribute : Attribute
    {
        internal Double Max
        { get; set; }

        internal Double Min
        { get; set; }

        // 建構函式, 以便在套用 attribute 時初始化 Min, Max
        public GenderBoundaryAttribute(int min, int max)
        {
            Max = max;
            Min = min;
        }
    }




public enum GenderType
{
    [GenderBoundary(20, 25)]
    Man = 1,
    [GenderBoundary(18, 22)]
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

    public class BMIAdapter
    {
        internal static readonly Double WrongValue = -1;

        private Human _human;

        public Double BMI
        { get; private set; }

        public String Result
        { get; private set; }

        public BMIAdapter(Human human)
        {
            _human = human;
            GetBMI();
        }

        private void GetBMI()
        {
            if (_human.Weight > 0 && _human.Height > 0)
            {
                BMI = _human.Weight / Math.Pow(_human.Height, 2);
            }
            else
            {
                BMI = WrongValue;
            }
          //  var genderboundry = _human.Gender.GetType().GetCustomAttributes(typeof(GenderBoundaryAttribute), true);
            BoundryHelper helper = new BoundryHelper(_human.Gender);
            ResultAdaper adapter = new ResultAdaper(helper.Min, helper.Max, BMI);
            Result = adapter.Result;
        }
    }

    internal class BoundryHelper
    {
        internal Double Max
        { get; private set; }

        internal Double Min
        { get; private set; }

        public BoundryHelper(GenderType gender)
        {
            var data = typeof(GenderType).GetField(gender.ToString());
            var attribute = Attribute.GetCustomAttribute(data, typeof(GenderBoundaryAttribute));
            Min = ((GenderBoundaryAttribute)attribute).Min;
            Max = ((GenderBoundaryAttribute)attribute).Max;
        }
    }

    internal class ResultAdaper
    {
        public String Result
        { get; private set; }

        private Double _max;
        private Double _min;
        private Double _bmi;

        internal ResultAdaper(Double min, Double max, Double bmi)
        {
            _max = max;
            _min = min;
            _bmi = bmi;
            GetResult();
        }

        private void GetResult()
        {
            if (_bmi != BMIAdapter.WrongValue)
            {
                if (_bmi > _max)
                {
                    Result = "太胖";
                }
                else if (_bmi < _min)
                {
                    Result = "太瘦";
                }
                else
                {
                    Result = "適中";
                }
            }
            else
            {
                Result = "體重或身高不得小於0";
            }
        }
    }
}
