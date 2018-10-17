using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeSample01
{
    class Program
    {
        static void Main(string[] args)
        {
            EnumValueBoundryHelper enumhelper = new EnumValueBoundryHelper(GenderType.Man);
            Console.WriteLine("MIN :" + enumhelper.Min + " AND MAX :" + enumhelper.Max);

            ClassBoundryHelper classhelper = new ClassBoundryHelper();
            classhelper.GetBoundry(typeof(BoundryClass));
            Console.WriteLine("MIN :" + classhelper.Min + " AND MAX :" + classhelper.Max);


            Console.ReadLine();
        }
    }
}
