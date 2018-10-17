using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI03
{
    class BMI
    {
        public  string GetBMIResult(Double weight, Double height, Boolean gender)
        {
            Double bmi = GetBMIValue(weight, height);
            if (bmi != -1)
            {
                if (gender == true)
                {
                    if (bmi > 25)
                    {
                        return "太胖";
                    }
                    else if (bmi < 20)
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
                    if (bmi > 22)
                    {
                        return "太胖";
                    }
                    else if (bmi < 18)
                    {
                        return "太瘦";
                    }
                    else
                    {
                        return "適中";
                    }
                }
            }
            else
            {
                return "體重或身高不得小於0";
            }

        }

        private Double GetBMIValue(Double weight, Double height)
        {
            if (weight > 0 && height > 0)
            { return weight / Math.Pow(height, 2); }
            else
            { return -1; }
        }
    }
}
