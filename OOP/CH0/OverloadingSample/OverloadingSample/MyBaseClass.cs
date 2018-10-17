using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingSample
{
    internal class MyBaseClass
    {
        public virtual int Add(int x, int y)
        {
            return x + y;
        }
    }

    internal class MyDerivedClass : MyBaseClass
    {
        public override int Add(int x, int y)
        {
            return x + y + 1;
        }

        public string Add(string x, string y)
        {
            return x + y;
        }

    }
}
