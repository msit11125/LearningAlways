using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSample02
{
    class Program
    {
        static void Main(string[] args)
        {
            // 呼叫端無法直接建立執行個體
            // SingletonClass obj = new SingletonClass();

            //透過靜態屬性存取
            SingletonClass.SingletonObject.Show();
            SingletonClass.SingletonObject.Show();
            SingletonClass.SingletonObject.Show();
            SingletonClass.SingletonObject.Show();

            Console.ReadLine();
        }
    }
}
