using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionSample02
{
    public class InstanceClass
    {
        public void ShowText()
        {
            Console.WriteLine("Form instance method");
        }
    }

    public static class ExtensionClass
    {
        public static void ShowText(this InstanceClass value)
        {
            Console.WriteLine("Form extension method");
        }
    }
}
