using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellingSample02
{
    public class Celling
    {
        public static double GetResult(double value, double baseValue)
        {
            return Math.Ceiling(value / baseValue) * baseValue;
        }


        public static double GetResult_Round(double value, double baseValue)
        {
            return Math.Round(value / baseValue) * baseValue;

        }
    }
}
