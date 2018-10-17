using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //偽 OOP
        private void button1_Click(object sender, EventArgs e)
        {
            BMI bmi = new BMI();
            MessageBox.Show(bmi.GetBMIResult(58, 1.72,false));
        }
    }
}
