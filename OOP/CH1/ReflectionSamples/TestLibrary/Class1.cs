using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public interface IText
    {
        void ShowText();
    }

    public class Class1 : IText
    {
        public int X
        { get; set; }

        protected string Str
        { get; set; }

        public Class1()
        {
            X = 10;
            Str = "無參數建構";
        }

        public Class1(int x, string str)
        {
            X = x;
            Str = str;
        }

        public void PublicShow()
        {
            Console.WriteLine("這是一個公開方法");
        }

        public void PublicShow(string value, int i)
        {
            Console.WriteLine("這是一個多載的公開方法, 傳入了:" + value + i.ToString());
        }

        protected void ProtectedShow()
        {
            Console.WriteLine("這是一個受保護方法");
        }

        private void PrivateShow()
        {
            Console.WriteLine("這是一個私有方法");
        }

        public void ShowText()
        {
            Console.WriteLine("這是一個實做介面的公開方法");
        }






        //ReflectionSample02 才加入參考練習回傳參數
        public int GetValue(int value)
        {
            return value;
        }
    }
}
