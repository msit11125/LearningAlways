using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionSample02
{
    class Program
    {
        static void Main(string[] args)
        {
            InstanceClass obj = new InstanceClass();
            obj.ShowText();

            // 簽章一模一樣時 只能用最原始的寫法
            // ExtensionClass.ShowText(obj); 
            Console.ReadLine();
        }
    }
}
