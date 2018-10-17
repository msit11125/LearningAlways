using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDependencySample.Client
{
    // 這一群 classes 代表我們會寫在 Client 端的程式碼, 在每個不同的狀況下我們都可能用到 ITest 介面的任何一種實作
    public class ClientClass1
    {
        public void SomeMethodOfClass1()
        {
            Library.ITest a = Library.TestFactory.GetTestInstance();
            a.Do();
        }
    }

    public class ClientClass2
    {
        public void SomeMethodOfClass2()
        {
            Library.ITest a = Library.TestFactory.GetTestInstance();
            a.Do();
        }
    }

    public class ClientClass3
    {
        public void SomeMethodOfClass3()
        {
            Library.ITest a = Library.TestFactory.GetTestInstance();
            a.Do();
        }
    }

    public class ClientClass4
    {
        public void SomeMethodOfClass4()
        {
            Library.ITest a = Library.TestFactory.GetTestInstance();
            a.Do();
        }
    }

    public class ClientClass5
    {
        public void SomeMethodOfClass5()
        {
            Library.ITest a = Library.TestFactory.GetTestInstance();
            a.Do();
        }
    }

    public class ClientClass6
    {
        public void SomeMethodOfClass6()
        {
            Library.ITest a = Library.TestFactory.GetTestInstance();
            a.Do();
        }
    }

    public class ClientClass7
    {
        public void SomeMethodOfClass7()
        {
            Library.ITest a = Library.TestFactory.GetTestInstance();
            a.Do();
        }
    }

    public class ClientClass8
    {
        public void SomeMethodOfClass8()
        {
            Library.ITest a = Library.TestFactory.GetTestInstance();
            a.Do();
        }
    }

    public class ClientClass9
    {
        public void SomeMethodOfClass9()
        {
            Library.ITest a = Library.TestFactory.GetTestInstance();
            a.Do();
        }
    }

    public class ClientClass10
    {
        public void SomeMethodOfClass10()
        {
            Library.ITest a = Library.TestFactory.GetTestInstance();
            a.Do();
        }
    }

    // 有沒有發現這個例子和之前有甚麼不一樣 ? 如果今天我要改變  ITest 的實作型別, 我只要去改
    // Library.TestFactory.GetTestInstance() 方法的內容, 所以你只改了一行
    // 而 Client 端的程式碼完全沒有變動.
}
