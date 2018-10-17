using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarianceSample01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 共變
            //Gen1 obj = OutMethod();
            Gen0 obj = OutMethod();

            //逆變
            //InMethod(new Gen0());
            InMethod(new Gen1());
        }

        private static Gen1 OutMethod()
        { return new Gen1(); }

        private static void InMethod(Gen0 obj)
        { }

    }



    public class Gen0
    {
        public int X
        { get; set; }
    }
    public class Gen1 : Gen0
    {

    }
}
