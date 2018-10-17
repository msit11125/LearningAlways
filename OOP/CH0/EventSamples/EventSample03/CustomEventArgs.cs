using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample03
{
    public class CustomEventArgs : EventArgs
    {
        public int OldValue
        { get; set; }
        public int NewValue
        { get; set; }
    }
}
