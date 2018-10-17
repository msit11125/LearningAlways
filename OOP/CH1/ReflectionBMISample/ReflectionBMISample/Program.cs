using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionBMISample
{
    class Program
    {
        static void Main(string[] args)
        {
            Object man = Activator.CreateInstance("BMILibrary", "BMILibrary.Man").Unwrap();

            Type mantype = man.GetType();
            mantype.GetProperty("Weight").SetValue(man, 68);
            mantype.GetProperty("Height").SetValue(man, 1.75);
            Console.WriteLine("BMI :" + mantype.GetProperty("BMI").GetValue(man).ToString());
            Console.WriteLine("結果 :" + mantype.GetProperty("Result").GetValue(man).ToString());

            OldMethod();

            Console.ReadLine();
        }

        [Obsolete("不要用了")]  // CLR 就可以顯示綠色底線
        static void OldMethod()
        {
            //過時的邏輯
        }
    }
}
