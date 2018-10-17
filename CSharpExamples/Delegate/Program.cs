using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        delegate void MyCallbackHandler(object callbackData);
        static void Main(string[] args)
        {
            MyCallbackHandler cb;

            cb = delegate (object callbackData)               
            {
                Console.WriteLine(callbackData);           
            };

            // 等同於
            //       cb = ( (callbackData) =>
            //       {
            //           Console.WriteLine(callbackData);
            //       });

            cb.Invoke("Hello , I use Delegate");
            //以上為匿名的委派




            // 委派的 Call Back
            Note note = new Note();
            note.WriteLine(
                (s) => { return s + " (is inside delegate) "; },
                 "Hello World"
                );




            Console.ReadLine();





            #region Func類別
            // 額外 : 委派 Func
            int resultFunc = getNumberOne();

            Func<int, bool> predicate1 = (a) =>
            {
                return true;
            };
            Func<int, int, bool> predicate2 = (source, index) =>
            {
                return true;
            };


            // Where 擴充 - 1 
            //public static IEnumerable<TSource> Where<TSource>
            //(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
            List<string> list = new List<string>() { "john", "kate", "john" };
            var result1 = list.Where((i) => i == "john");

            // Where 擴充 - 2 
            // public static IEnumerable<TSource> Where<TSource>
            //(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate);
            //篩選 list[2] 的 john
            var result2 = list.Where((i, index) => i == "john" && index == 2);


            List<int> numbers = new List<int> { 1, 2, 4, 8 };
            int tmp = numbers.Aggregate(
             func: (seed, item) => seed * item
            );
            Console.WriteLine("1*2*4*8 = " + tmp); // 結果: 1*2*4*8
            Console.ReadLine();

            // https://dotblogs.com.tw/jeffyang/2017/02/18/224346

            #endregion
        }



        static Func<int> getNumberOne = () =>
        {
            return 1;
        };
    }





    public delegate string Del(string message);

    public class Note
    {
        public Note()
        {

        }

        /// <summary>
        ///  委派的回呼方法 Call Back
        /// </summary>
        /// <param name="del"></param>
        /// <param name="message"></param>
        public void WriteLine(Del del,string message)
        {
            Console.WriteLine(del?.Invoke(message));
        }
    }
}
