using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterSample06
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] str = new String[] { "x", "y", "z" };
            ArrayParams(1, str);
            //  ArrayParams (1,"x","y","z")  // 這是不允許的

            DynamicParams(2, str);
            DynamicParams(2, "x", "y", "z");
        }

        private static void ArrayParams(int x, String[] parameters)
        {

        }

        private static void DynamicParams(int x, params String[] parameters)
        {

        }
    }
}
