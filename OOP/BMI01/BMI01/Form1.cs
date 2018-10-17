using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double value = GetBMIValue(58, 1.72);
            if (value > -1)
            {
                MessageBox.Show(GetWomanResult(value));
            }
            else
            {
                MessageBox.Show("體重或身高不得小於0"); 
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="weight"> KG</param>
        /// <param name="height"> M</param>      
        private Double GetBMIValue(Double weight, Double height)
        {
            if (weight > 0 && height > 0)
            { return weight / Math.Pow(height, 2); }
            else
            { return -1; }
        }
       
        private String GetManResult(Double bmi)
        {
            if (bmi > 25)
            {
                return "太胖";
            }
            else if (bmi < 20)
            {
                return "太瘦";
            }
            else
            {
                return "適中";
            }

        }

        private String GetWomanResult(Double bmi)
        {
            if (bmi > 22)
            {
                return "太胖";
            }
            else if (bmi < 18)
            {
                return "太瘦";
            }
            else
            {
                return "適中";
            }
        }
    }
}
