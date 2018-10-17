using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChangeToDelegateSample
{
    public class Class1
    {
        //寫法一  Delegate
        //public EventHandler XChanged
        //{
        //    get; set;
        //}

        //寫法二 Event  
        public event EventHandler XChanged;

        //兩個寫法都相同


        private void OnXChanged()
        {
            if (XChanged != null)
            { XChanged.Invoke(this, new EventArgs()); }
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
                    // 等同 = >  XChanged?.Invoke(this, new EventArgs());
                }
            }
        }
    }
}
