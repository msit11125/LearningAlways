using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellingSample01
{
    public class Celling
    {
        public static double GetResult(double value, double baseValue)
        {
         
            int quotient = (int)(value / baseValue);
            double remainder = value - baseValue * quotient;
            if (remainder > 0)
            {
                return baseValue * (quotient + 1);
            }
           else
            {
                return value;
            }

        }
    }
}
