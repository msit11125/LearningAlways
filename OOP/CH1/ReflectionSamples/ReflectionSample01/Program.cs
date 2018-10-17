using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionSample01
{
    class Program
    {
        static void Main(string[] args)
        {

            Object obj = AppDomain.CurrentDomain.CreateInstanceAndUnwrap("TestLibrary", "TestLibrary.Class1");
            MemberInfo[] members;

            Console.WriteLine("==GetMembers()==");
            members = obj.GetType().GetMembers();
            ShowResult(members);


            Console.WriteLine("==GetMembers() BindingFlag==");
            members = obj.GetType().GetMembers(BindingFlags.Instance | BindingFlags.NonPublic);
            ShowResult(members);

            Console.WriteLine("==GetMember(PublicShow)==");
            members = obj.GetType().GetMember("PublicShow");
            ShowResult(members);


            Console.ReadLine();
        }


        static void ShowResult(MemberInfo[] members)
        {
            foreach (var m in members)
            {
                Console.WriteLine(m.MemberType.ToString() + ":" + m.Name);
            }
            Console.WriteLine("=======================");
            Console.WriteLine();
        }
    }


}
