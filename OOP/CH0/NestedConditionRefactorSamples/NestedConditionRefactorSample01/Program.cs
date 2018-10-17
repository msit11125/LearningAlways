using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedConditionRefactorSample01
{
    class Program
    {
        // 這兩個是來源
        private static List<string> strlist;
        private static List<int> intlist;
        static void Main(string[] args)
        {
            strlist = new List<string>() { "Dog", "Cat", "Apple", "House", "Car", "Taxi" };
            intlist = new List<int> { 1, 4, 8, 90, 77 };
            var result = RunCheck();
            Console.WriteLine(string.Format("結果是 : {0}", result));
            Console.ReadLine();
        }

        public static bool RunCheck()
        {
            bool result = false;
            if (strlist[0] == "Dog")
            {
                if (strlist[1] == "Cat")
                {
                    if (strlist[2] == "Apple")
                    {
                        if (strlist[3] == "House")
                        {
                            if (strlist[4] == "Car")
                            {
                                if (strlist[5] == "Taxi")
                                {
                                    if (intlist[0] == 1)
                                    {
                                        if (intlist[1] == 4)
                                        {
                                            if (intlist[2] == 8)
                                            {
                                                if (intlist[3] == 90)
                                                {
                                                    if (intlist[4] == 77)
                                                    {
                                                        result = true;
                                                    }
                                                    else
                                                    {
                                                        result = false;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
