using InterfaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationLibrary
{
    internal class Man : Human
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


    internal class Woman : Human
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
