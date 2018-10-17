using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseBuilder
{
    //  Builder Coding Exercise

    //  You are asked to implement the Builder design pattern for rendering simple chunks of code.

    //  Sample use of the builder you are asked to create:

    //       var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
    //           Console.WriteLine(cb);
    //       The expected output of the above code is:

    //       public class Person
    //       {
    //           public string Name;
    //           public int Age;
    //       }
    //  Please observe the same placement of curly braces and use two-space indentation

    class Program
    {
        static void Main(string[] args)
        {
            Code cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
            Console.WriteLine(cb);
            Console.Read();
        }
    }



    public class Code
    {
        public Code()
        {
            PropertyNameAndType = new List<Tuple<string, string>>();
        }
        public string ClassName { get; set; }
        public List<Tuple<string,string>> PropertyNameAndType { get; set; }


        public override string ToString()
        {
            string code = $"public class {ClassName}\n{{\n";
            foreach (var item in PropertyNameAndType)
            {
                code += $"    public {item.Item2} {item.Item1};\n";
            }
            code += "}";
            return code; 
        }
    }

    public class CodeBuilder
    {
        protected Code code = new Code() ;
        public CodeBuilder(string build)
        {
            code.ClassName = build;
        }

        public CodeBuilder AddField(string propertyName, string propertyType)
        {
            code.PropertyNameAndType.Add(Tuple.Create(propertyName, propertyType));
            return this;
        }

        public static implicit operator Code(CodeBuilder cb)
        {
            return cb.code;
        }
    }
}
