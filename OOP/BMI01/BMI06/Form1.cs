using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Human human = new Human() { Age = 19, Gender = GenderType.Woman, Height = 1.72, Weight = 58 };
            BMIStrategy result = human.GetStrategy();
            MessageBox.Show(result.BMI.ToString("0.000") + ":" + result.Result);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
