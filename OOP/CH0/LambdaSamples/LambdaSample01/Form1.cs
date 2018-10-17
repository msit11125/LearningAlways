using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LambdaSample01
{
    public partial class Form1 : Form
    {

        private List<string> data;
        public Form1()
        {
            InitializeComponent();
            data = new List<string>() { "bill", "david", "john" };
        }

        private void ShowResult(string source, IEnumerable<string> result)
        {
            textBox1.Clear();
            AppendLine(source);
            foreach (var item in result)
            {
                AppendLine(item);
            }
        }

        private void AppendLine(string value)
        {
            textBox1.AppendText(string.Format("{0}{1}", value, Environment.NewLine));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lambda 的寫法
            var result = data.Where((x) => { return x == "david"; });
            // 或
            //  var result = data.Where((x) => x=="david");            
            ShowResult(System.Reflection.MethodBase.GetCurrentMethod().Name, result);
        }

        private bool TestMethod(string value)
        {
            // 給 button2 ,button3m ,buton4 使用的方法
            return (value == "john");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 最傳統的寫法 Boolen Func<T,Boolean>(T value)
            Func<string, bool> TestDelegate;
            TestDelegate = TestMethod;
            var result = data.Where(TestDelegate);
            ShowResult(System.Reflection.MethodBase.GetCurrentMethod().Name, result);
        }



        private void button3_Click(object sender, EventArgs e)
        {
            // button 2 寫法亦可偷懶成這樣
            var result = data.Where(TestMethod);
            ShowResult(System.Reflection.MethodBase.GetCurrentMethod().Name, result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // button 2 寫法的另一種變形 (也是匿名委派)
            var result = data.Where(new Func<string, bool>(TestMethod));
            ShowResult(System.Reflection.MethodBase.GetCurrentMethod().Name, result);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //採用匿名委派
            var result = data.Where(delegate (string value) { return (value == "bill"); });
            ShowResult(System.Reflection.MethodBase.GetCurrentMethod().Name, result);
        }


    }
}
