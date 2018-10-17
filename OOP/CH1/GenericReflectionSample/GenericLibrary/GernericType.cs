using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLibrary
{
    public class GernericType<T> where T : IComparable
    {


    }

    public class DualGenericType<T1, T2>
        where T1 : class
        where T2 : IComparable
    {
    }
}
