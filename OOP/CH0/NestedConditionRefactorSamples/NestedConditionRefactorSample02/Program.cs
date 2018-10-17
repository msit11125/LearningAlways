using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedConditionRefactorSample02
{
    class Program
    {
        static List<string> strlist;
        static List<int> intlist;
        static void Main(string[] args)
        {
            strlist = new List<string>() { "Dog", "Cat", "Apple", "House", "Car", "Taxi" };
            intlist = new List<int> { 1, 4, 8, 90, 77 };
            var data = CreateTestingData();
            var result = RunCheck(data);
            Console.WriteLine(string.Format("結果是 : {0}", result));
            Console.ReadLine();
        }

        
       public static bool  RunCheck(List<ICheckData> collection)
        {
            bool result = true;           
            foreach (var item in collection)
            {
                if (!item.GetResult())
                {
                    result = false;
                    break;
                }              
            }
            return result;
        }

        /// <summary>
        /// 建立測試用資料 (Why ICheckData ?)
        /// </summary>
        /// <returns></returns>
        private static List<ICheckData> CreateTestingData()
        {
            List<ICheckData> result = new List<ICheckData>();
            result.Add(new CheckData<string>("Dog", strlist[0]));
            result.Add(new CheckData<string>("Cat", strlist[1]));
            result.Add(new CheckData<string>("Apple", strlist[2]));
            result.Add(new CheckData<string>("House", strlist[3]));
            result.Add(new CheckData<string>("Car", strlist[4]));
            result.Add(new CheckData<string>("Taxi", strlist[5]));
            result.Add(new CheckData<int>(1, intlist[0]));
            result.Add(new CheckData<int>(4, intlist[1]));
            result.Add(new CheckData<int>(8, intlist[2]));
            result.Add(new CheckData<int>(90, intlist[3]));
            result.Add(new CheckData<int>(77, intlist[4]));
            return result;
        }
    }
}
