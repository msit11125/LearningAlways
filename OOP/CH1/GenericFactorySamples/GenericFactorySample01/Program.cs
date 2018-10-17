using FactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFactorySample01
{
    class Program
    {
        static void Main(string[] args)
        {
            var db01 = GenericFactory.CreateInastance<MyClassLibrary.IDbProcess>("MyClassLibrary", "MyClassLibrary.SqlDbProcess");
            Console.WriteLine(db01.GetName());

            var db02 = GenericFactory.CreateInastance<MyClassLibrary.IDbProcess>(typeof(MyClassLibrary.OleDbProcess));
            Console.WriteLine(db02.GetName());

            Console.ReadLine();
        }
    }
}
