using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChangeToDelegateSample
{
    public partial class Form1 : Form
    {
        private Class1 obj;
        public Form1()
        {
            InitializeComponent();
            obj = new Class1();
            obj.XChanged += obj_XChanged;
        }

        private void obj_XChanged(object sender, EventArgs e)
        {
            Class1 obj = (Class1)sender;
            MessageBox.Show("obj 的值被改變 " + obj.X);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.X += 1;
        }
    }
}
