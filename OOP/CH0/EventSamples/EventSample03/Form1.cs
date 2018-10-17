using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventSample03
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

        private void obj_XChanged(object sender, CustomEventArgs e)
        {
            MessageBox.Show("由" + e.OldValue.ToString() + "變成" + e.NewValue.ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            obj.X = (int)numericUpDown1.Value;
        }
    }
}
