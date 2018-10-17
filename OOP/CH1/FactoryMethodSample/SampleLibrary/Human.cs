using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLibrary
{
    public enum GenderType
    {
        Man = 1,
        Woman = 2
    }
    /// <summary>
    /// 基本資料類別
    /// </summary>
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
