using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample03
{
    public class Class1
    {


        public event EventHandler<CustomEventArgs> XChanged;
        private void OnXChanged(int oldvalue, int newvalue)
        {
            if (XChanged != null)
            { XChanged(this, new CustomEventArgs() { OldValue = oldvalue, NewValue = newvalue }); }
        }

        private int _x;
        public int X
        {
            get { return _x; }
            set
            {
                if (_x != value)
                {
                    int old = _x;
                    _x = value;
                    OnXChanged(old, value);
                }
            }
        }
    }
}
