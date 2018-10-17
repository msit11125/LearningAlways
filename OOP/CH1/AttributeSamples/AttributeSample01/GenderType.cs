using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributeSample01
{
    /// <summary>
    /// 在列舉值中套用 attribute
    /// </summary>
    public enum GenderType
    {
        [Boundary(20, 25)]
        Man = 1,
        [Boundary(18, 22)]
        Woman = 2
    }

    /// <summary>
    /// 取得列舉值的 attribute
    /// </summary>
    internal class EnumValueBoundryHelper
    {
        internal Double Max
        { get; private set; }

        internal Double Min
        { get; private set; }

        public EnumValueBoundryHelper(GenderType gender)
        {
            FieldInfo data = typeof(GenderType).GetField(gender.ToString());
            Attribute attribute = Attribute.GetCustomAttribute(data, typeof(BoundaryAttribute));
            BoundaryAttribute boundaryattribute = (BoundaryAttribute)attribute;
            Min = boundaryattribute.Min;
            Max = boundaryattribute.Max;
        }
    }
}
