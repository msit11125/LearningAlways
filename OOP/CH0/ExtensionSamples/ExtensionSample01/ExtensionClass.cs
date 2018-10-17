using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionSample01
{
    public static class ExtensionClass
    {
        public static string[] Splitline(this string str)
        {
            return str.Split(new string[] { Environment.NewLine },
                StringSplitOptions.None);
        }
    }
}
