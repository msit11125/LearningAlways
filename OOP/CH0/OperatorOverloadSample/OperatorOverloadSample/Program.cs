using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadSample
{
    class Program
    {

        static void Main(string[] args)
        {
            Custom<int> c001 = 1;
            Console.WriteLine(c001.GetValue().ToString());
            int x = (int)c001;
            Console.WriteLine(x.ToString());

            //Test 
            a<int> a = 1;

            Console.ReadLine();
        }

        public struct a<T> where T: struct
        {
            private T _value;

            public a(T value)
            {
                _value = value;
            }

            public static implicit operator a<T>(T value)
            {
                return new a<T>(value);
            }
        }
    }
}
