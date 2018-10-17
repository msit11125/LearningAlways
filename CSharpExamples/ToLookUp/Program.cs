using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToLookUp
{
    class Program
    {

        static void Main(string[] args)
        {
            var nameValuesGroup = new[]
            {
                new { name="Allen",value=65,group="A" },
                new { name="Abbey",value=120,group="A" },
                new { name="Slong",value=330,group="B" },
                new { name="George",value=213,group="C" },
                new { name="Meller",value=329,group="C" },
                new { name="Mary",value=192,group="B" },
                new { name="Sue",value=200,group="C" }

            };
            // Count, Any, All    => All: 所有條件判斷，回傳true,false
            bool nameLenMoreThanTwo = nameValuesGroup.All(n => n.name.Length >= 2);
            
            
            // ToDictionary 擴充 - 1  
            //                        Key:name Value:物件
            var keyValue1 = nameValuesGroup.ToDictionary(c => c.name);
            // ToDictionary 擴充 - 2
            //                        Key:name Value:value
            var keyValue2 = nameValuesGroup.ToDictionary(c => c.name,c=>c.value);



            // ToLookUp 擴充   
            // 兩者相同用途的差異 => ToLookUp: eager ,  GroupBy: lazy延遲載入

            var lookupValues = nameValuesGroup.GroupBy(c => c.group);

            lookupValues.ForEach(group =>
            {
                Console.WriteLine($"=== Group : {group.Key} ===");
                group.ForEach(item =>
                {
                    Console.WriteLine($"name: { item.name } , value: {item.value} , group: {item.group}");
                });
            });



            Console.ReadLine();


        }
       

    }

    public static class IEnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> values, Action<T> action)
        {
            foreach (var value in values)
            {
                action(value);
            }
        }
    }
}
