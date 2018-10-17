using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationDependencySample.Client
{
    // 這一群 classes 代表我們會寫在 Client 端的程式碼, 在每個不同的狀況下我們都可能用到 Class A
    public class ClientClass1
    {
        public void SomeMethodOfClass1()
        {
            Library.ATestClass a = new Library.ATestClass();
            a.Do();
        }
    }

    public class ClientClass2
    {
        public void SomeMethodOfClass2()
        {
            Library.ATestClass a = new Library.ATestClass();
            a.Do();
        }
    }

    public class ClientClass3
    {
        public void SomeMethodOfClass3()
        {
            Library.ATestClass a = new Library.ATestClass();
            a.Do();
        }
    }

    public class ClientClass4
    {
        public void SomeMethodOfClass4()
        {
            Library.ATestClass a = new Library.ATestClass();
            a.Do();
        }
    }

    public class ClientClass5
    {
        public void SomeMethodOfClass5()
        {
            Library.ATestClass a = new Library.ATestClass();
            a.Do();
        }
    }

    public class ClientClass6
    {
        public void SomeMethodOfClass6()
        {
            Library.ATestClass a = new Library.ATestClass();
            a.Do();
        }
    }

    public class ClientClass7
    {
        public void SomeMethodOfClass7()
        {
            Library.ATestClass a = new Library.ATestClass();
            a.Do();
        }
    }

    public class ClientClass8
    {
        public void SomeMethodOfClass8()
        {
            Library.ATestClass a = new Library.ATestClass();
            a.Do();
        }
    }

    public class ClientClass9
    {
        public void SomeMethodOfClass9()
        {
            Library.ATestClass a = new Library.ATestClass();
            a.Do();
        }
    }

    public class ClientClass10
    {
        public void SomeMethodOfClass10()
        {
            Library.ATestClass a = new Library.ATestClass();
            a.Do();
        }
    }

    // 當你把程式碼拉到這邊, 你會發現幾件事
    // (1) 你不斷在重複程式碼, 我指的是  Library.ATestClass a = new Library.ATestClass(); (想想, 這還是放在一個檔案上看得到, 實際情況應該散落各處)
    // (2) 如果客戶今天要求 ATestClass 要替換成另一種實作, 你該怎麼辦 ?
    // (3) 如果可能的話, 你把這些類別擴充成一百個, 然後在 Library 目錄下建立一個 BTestClass, 抽象語意和 ATestClass 相同(也就是只有 Do 方法) 但 Do 的內容實作不同, 然後把這邊的一百個 Client Class 的類別由 ATestClass 替換成 BTestClass. 這表示甚麼 ? 表示你必須動 100 份程式碼, 於是這 100份程式碼得全部重新測試. 
}
