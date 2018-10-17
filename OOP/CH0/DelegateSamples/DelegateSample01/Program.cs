using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample01
{
 public delegate void SomeAction(string message);
 class Program
 {
     static void Main(string[] args)
     {
         SomeAction action = ShowMessage; // 加入第一個方法
         // SomeAction action2 = new SomeAction(ShowMessage); // 同上寫法

         action += ShowText; // 加入第二個方法

         action.Invoke("Test"); 

         Console.ReadLine();
     }

     public static void ShowMessage(string message)
     {
         Console.WriteLine("ShowMessage :" + message);
     }

     public static void ShowText(string text)
     {
         Console.WriteLine("ShowText :" + text);
     }
 }
}
