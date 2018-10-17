using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingSample
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int i = 10;
            object o = i;  // Boxing -> Heap中產生一個10
            i.GetType();  // Boxing
            i.CompareTo(11);  // 不會Boxing 
            ((IComparable)i).CompareTo(12);  // 轉介面 12 會Boxing
            ((IComparable<int>)i).CompareTo(13); // 不會Boxing 等同 i.CompareTo(13)
                
            ArrayList list = new ArrayList(); // -> ArrayList盡量不要使用了，元素型別是Object
            list.Add(i); // Boxing -> 浪費效能
        }
    }
}
