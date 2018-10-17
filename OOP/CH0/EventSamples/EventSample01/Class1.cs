using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample01
{
    public class Class1
    {
        public event EventHandler XChanged;
        private void OnXChanged()
        {
            if (XChanged != null)
            { XChanged(this, new EventArgs()); }
            //{ XChanged.Invoke (this, new EventArgs()); }            
        }

        private int _x;
        public int X
        {
            get { return _x; }
            set
            {
                if (_x != value)
                {
                    _x = value;
                    OnXChanged();
                    // C#6.0 後可以用 null conditon 
                    //XChanged?.Invoke(this, new EventArgs());
                }
            }
        }
    }
}
