using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionSample03
{
    /// <summary>
    /// 取得屬性, 並取得或修改其值
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Object obj = AppDomain.CurrentDomain.CreateInstanceAndUnwrap("TestLibrary", "TestLibrary.Class1");
            PropertyInfo[] propertites;

            Console.WriteLine("==GetProperties()==");
            propertites = obj.GetType().GetProperties();
            ShowResult(propertites);


            Console.WriteLine("==GetProperties() BindingFlag==");
            propertites = obj.GetType().GetProperties(BindingFlags.Instance | BindingFlags.NonPublic);
            ShowResult(propertites);

            PropertyInfo property = obj.GetType().GetProperty("Str", BindingFlags.Instance | BindingFlags.NonPublic);
            Console.WriteLine("屬性原來的值 :" + property.GetValue(obj).ToString());
            property.SetValue(obj, "用反射更改了");
            Console.WriteLine("屬性更改後的值 :" + property.GetValue(obj).ToString());
            Console.ReadLine();

        }

        static void ShowResult(PropertyInfo[] propertites)
        {
            foreach (var p in propertites)
            {
                Console.WriteLine(p.Name + ":" + p.ReflectedType.ToString());
            }
            Console.WriteLine("=======================");
            Console.WriteLine();
        }
    }
}
