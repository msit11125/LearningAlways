using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI05
{
    // 分離 個人資料 和 BMI

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

    public static class BMI
    {
        /// <summary>
        /// 將 GetBMI 設計為擴充方法
        /// </summary>
        /// <param name="human"></param>
        /// <returns></returns>
        public static Double GetBMI(this Human human)
        {
            if (human.Weight > 0 && human.Height > 0)
            { return human.Weight / Math.Pow(human.Height, 2); }
            else
            { return ResultAdaper.WrongValue; }
        }
    }



    /// <summary>
    /// 直接定義轉換器, 將 double 轉換為 BMI 值
    /// </summary>
    public  class ResultAdaper
    {
        public static readonly Double WrongValue = -1;

        protected Double _max;
       
        protected Double _min;
       


        public  ResultAdaper()
        {
            _max = 25;
            _min = 20;
        }
        
        //依據輸入改變上下限
        public ResultAdaper (Double min,Double max)
        {
            _max = max;
            _min = min;
        }

        //運算邏輯相同, 差別只有 max 和 min 的定義
        public String GetResult(Double bmi)
        {
           
            if (bmi != WrongValue)
            {
                if (bmi > _max)
                {
                    return "太胖";
                }
                else if (bmi < _min)
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


}
