using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeSample01
{
    // 建立自訂 Attribute 類別
    internal class BoundaryAttribute : Attribute
    {
        internal Double Max
        { get; set; }

        internal Double Min
        { get; set; }

        // 建構函式, 以便在套用 attribute 時初始化 Min, Max
        public BoundaryAttribute(int min, int max)
        {
            Max = max;
            Min = min;
        }
    }
}
