using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticContructorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Class1._y);
            }
            catch
            {
                // 故意不理他
            }
            //必死無疑
            Class1.GetW(new Class1());
            Console.ReadLine();
        }
    }
}
