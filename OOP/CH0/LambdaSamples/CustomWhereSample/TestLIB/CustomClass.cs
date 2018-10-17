using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomWhereSample.TestLIB
{
    public static class CustomClass
    {
        public static IEnumerable<T> DoWhere<T>
            (this IEnumerable<T> source, Func<T, Boolean> predicate)  
        {
            foreach (T item in source)
            {
                if (predicate.Invoke(item))
                {
                    yield return item;
                }
            }
        }
    }
}
