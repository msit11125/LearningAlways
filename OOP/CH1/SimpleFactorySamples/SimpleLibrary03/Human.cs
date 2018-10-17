using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrary03
{
    internal class GenderStrategyAttribute : Attribute
    {
        internal Type StrategyType
        { get; private set; }

        public GenderStrategyAttribute(Type strategyType)
        {
            StrategyType = strategyType;
        }
    }

    /// <summary>
    /// 在列舉值中套用 attribute, 將 Strategy 藏在 Attribute 中
    /// </summary>
    public enum GenderType
    {
        [GenderStrategyAttribute(typeof(ManBMIStrategy))]
        Man = 1,
        [GenderStrategyAttribute(typeof(WomanBMIStrategy))]
        Woman = 2
    }

    // 取得列舉值的 attribute
    internal class StrategyHelper
    {
        public static Type GetStrategyType(GenderType gender)
        {
            FieldInfo data = typeof(GenderType).GetField(gender.ToString());
            Attribute attribute = Attribute.GetCustomAttribute(data, typeof(GenderStrategyAttribute));
            GenderStrategyAttribute valueattribute = (GenderStrategyAttribute)attribute;
            return valueattribute.StrategyType;
        }
    }

    public class Human
    {
        public Double Weight
        { get; set; }

        public Double Height
        { get; set; }

        public GenderType Gender
        { get; set; }

        public int Age
        { get; set; }
    }
}
