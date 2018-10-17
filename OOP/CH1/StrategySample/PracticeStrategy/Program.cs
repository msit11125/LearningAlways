using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = Context.GetResult("*", 9, 8);
            Console.WriteLine(i);
            Console.ReadKey();
        }

        public class Context
        {
            public static int GetResult(string operater, int x, int y)
            {
                return new CaculateStrategy().GetResult(operater, x, y);
            }
        }

        public class CaculateStrategy
        {
            private Dictionary<string, Func<int, int, int>> caculater = new Dictionary<string, Func<int, int, int>>();

            public CaculateStrategy()
            {
                caculater.Add("+", (x, y) => x + y);
                caculater.Add("-", (x, y) => x - y);
                caculater.Add("*", (x, y) => x * y);
                caculater.Add("/", (x, y) => x / y);

            }

            public int GetResult(string operater, int x, int y)
            {
                return caculater.Where(d => d.Key == operater).FirstOrDefault().Value.Invoke(x, y);
            }
        }
    }
}
