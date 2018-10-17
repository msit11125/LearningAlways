using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticContructorSample
{
    public class Class1
    {

        private static Int32 _x;
        public static String _y;
        static Class1()
        {
            _x = 1;
            _y = "ABC"; 
            throw new NullReferenceException();
        }

        public int _w;

        public static int GetW(Class1 obj)
        {
            return obj._w;
        }
    }
}
