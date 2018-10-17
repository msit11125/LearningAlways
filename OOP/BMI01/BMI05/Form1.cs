using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI05
{
    //以 Human 為主體,擴充方法的設計
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Human human = new Human() { Age = 19, Gender = GenderType.Man, Height = 1.72, Weight = 58 };
            ResultAdaper adapter = new ResultAdaper(18,22);
            Double bmi = human.GetBMI(); 
            MessageBox.Show(bmi.ToString () + ":" + adapter.GetResult(bmi));
            // 這有一個缺點, 如果要改變成女性, ResultAdaper 的建構式就要輸入參數
        }
    }
}
