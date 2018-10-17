using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrary
{
    public abstract class Human
    {

        public Double Weight
        { get; set; }

        public Double Height
        { get; set; }

        private Boolean _calculated = false;
        private Double _bmi = 0;
        public Double BMI
        {
            get
            {
                if (!_calculated)
                {
                    GetBMIValue();
                }
                return _bmi;
            }
        }

        public String Result
        { get { return GetResult(); } }

        private void GetBMIValue()
        {
            _calculated = true;
            if (Weight > 0 && Height > 0)
            { _bmi = Weight / Math.Pow(Height, 2); }
            else
            { _bmi = -1; }
        }

        protected abstract String GetResult();
    }


}
