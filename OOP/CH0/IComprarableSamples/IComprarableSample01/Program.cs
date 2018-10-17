using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComprarableSample01
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private Boolean Compare(Int32 x, Int32 y)
        {
            if (x >= y)
            { return true; }
            else
            { return false; }

            // 其實可以簡化成 return (x >= y); 但這樣看起來沒這麼有趣
        }

        private Boolean Compare(Byte x, Byte y)
        {
            if (x >= y)
            { return true; }
            else
            { return false; }
        }

        private Boolean Compare(Double x, Double y)
        {
            if (x >= y)
            { return true; }
            else
            { return false; }
        }
    }
}
