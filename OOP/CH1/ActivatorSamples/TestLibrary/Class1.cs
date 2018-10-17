using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class Class1
    {
        public String Text
        { get; set; }
        public Class1()
        {
            Text = "無參數建構式";
        }

        public Class1(String text)
        {
            Text = text;
        }

    }

    public class Class2
    {
        public String Text
        { get; set; }
        private Class2()
        {
            Text = "從私有建構式";
        }
    }
}
