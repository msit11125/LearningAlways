using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample02
{
    public delegate void SomeAction(string message);
    public class Class1
    {
        public void DoAction(SomeAction action, string message)
        {
            action.Invoke(message);
        }
    }
}
