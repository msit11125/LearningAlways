using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI04
{
    /// <summary>
    /// 封裝計算公式, 以 BMI 為主角, Template Pattern
    /// </summary>
    public abstract class Human
    {

        public Double Weight
        { get; set; }

        public Double Height
        { get; set; }

        private Boolean _calculated = false;
        private Double _bmi = 0;
        public Double BMI
        {
            get
            {
                if (!_calculated)
                {
                     GetBMIValue();
                }
                return _bmi;
            }
        }

        public  String Result
        { get { return GetResult(); } }

        private void GetBMIValue()
        {
            //Debug.WriteLine("C");
            _calculated = true;
            if (Weight > 0 && Height > 0)
            { _bmi = Weight / Math.Pow(Height, 2); }
            else
            { _bmi = -1; }
        }

        protected abstract String GetResult();
    }

    public class Man : Human
    {     

        protected override string GetResult()
        {
            if (BMI != -1)
            {
                if (BMI > 25)
                {
                    return "太胖";
                }
                else if (BMI < 20)
                {
                    return "太瘦";
                }
                else
                {
                    return "適中";
                }
            }
            else
            {
                return "體重或身高不得小於0";
            }
        }
    }


    public class Woman : Human
    {

        protected override string GetResult()
        {
            if (BMI > 22)
            {
                return "太胖";
            }
            else if (BMI < 18)
            {
                return "太瘦";
            }
            else
            {
                return "適中";
            }
        }
    }
}
