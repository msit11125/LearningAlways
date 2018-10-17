using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionEx
{
    class Program
    {
        static void Main(string[] args)
        {
            tree<property> tree = new tree<property>();
            string re = tree.GetMapPropertyName(x => x.MyProperty1);

            Console.WriteLine("Property Name: " + re);
            Console.ReadKey();
        }


    }

    class tree<T>
    {
        public string GetMapPropertyName(Expression<Func<T, object>> MapDataColumn)
        {

            Expression expression = MapDataColumn.Body;
            if(expression.NodeType == ExpressionType.MemberAccess) // string
            {
                return (expression as MemberExpression).Member.Name;
            }
            else if(expression.NodeType == ExpressionType.Convert) // int ....
            {
                return (expression as UnaryExpression).Operand.ToString();
            }
            else if(expression.NodeType == ExpressionType.Constant)
            {
                
            }

            return "";
        }
    }

    class property
    {
        public int MyProperty1 { get; set; }
        public string MyProperty2 { get; set; }
    }
    
}
