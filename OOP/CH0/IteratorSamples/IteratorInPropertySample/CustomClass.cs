using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorInPropertySample
{
    class CustomClass
    {
        public IEnumerable<string> StringIterator
        {
            get
            {
                yield return "A";
                yield return "B";
                yield return "C";
                yield return "D";
                yield return "E";
            }
        }
    }
}
