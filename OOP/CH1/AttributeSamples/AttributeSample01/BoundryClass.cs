using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributeSample01
{
    [BoundaryAttribute(0, 100)]
    public class BoundryClass
    {

    }


    internal class ClassBoundryHelper
    {
        internal Double Max
        { get; private set; }

        internal Double Min
        { get; private set; }

        public void GetBoundry(Type type)
        {
            // 確認型別帶有 BoundaryAttribute
            if (type.IsDefined(typeof(BoundaryAttribute))) 
            {
                //反射取得Attribute
                Attribute attribute = type.GetCustomAttribute(typeof(BoundaryAttribute), true);

                BoundaryAttribute boundaryattribute = (BoundaryAttribute)attribute;
                Min = boundaryattribute.Min;
                Max = boundaryattribute.Max;
            }
        }
    }
}
