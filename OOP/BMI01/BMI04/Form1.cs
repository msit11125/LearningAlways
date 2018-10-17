using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI04
{
    // 倚賴實作
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Human man = new Woman ();
            man.Height = 1.72;
            man.Weight = 58;
            MessageBox.Show(man.Result);

        }
    }
}
