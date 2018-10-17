using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate
{
    class Program
    {
        static void Main(string[] args)
        {

            // Aggregate 擴充 -1 聚合
            string sentence = "the quick brown fox jumps over the lazy dog";
            string[] words = sentence.Split(' ');
            string reversed = words.Aggregate((workingSentence, next) =>
                                                  next + " " + workingSentence);
            // 第1次   quick + " " + the
            // 第2次   brown + " " + quick the
            // 第3次   fox + " " + brown quick the







            // Aggregate 擴充方法 - 2 3
            // 我的存款額度
            double myBalance = 100.00;

            // 預計每次將要提款的額度
            int[] withDrawItems = { 20, 10, 40, 50, 10, 70, 30 };


            double balance =
                withDrawItems.Aggregate(myBalance,
                (orignBalance, nextWithDrawal) =>
                {
                    Console.WriteLine($"目前存款: {orignBalance} , 準備提領: {nextWithDrawal}");
                    Console.WriteLine("提款狀態:{0}\n",
                        nextWithDrawal <= orignBalance ? "OK" : "Failed");

                    // 若存款餘額不足不會扣除，否則扣除提款額度
                    return ( (nextWithDrawal <= orignBalance) ? (orignBalance - nextWithDrawal) : orignBalance ) ;
                }, 
                /*第三個參數 - 最後餘額*/
                (finalbalance)=> {
                    Console.WriteLine($"剩餘存款: {finalbalance}");
                    return finalbalance;
                });

            Console.ReadKey();
        }
    }






    /// <summary>
    /// 等同 Aggregate 擴充Linq
    /// </summary>
    public static class MyLinqExtension
    {
        public static TSource MyAggregate<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func)
        {
            var e = source.GetEnumerator();
            e.MoveNext();
            TSource result = e.Current; 
            while (e.MoveNext())
                result = func(result, e.Current);    // (workingSentence, next) => TSource   ※ TSource在此為string

            return result;
        }

        // 用途: 有初始值(Seed)的累加計算
        public static TAccumulate MyAggregate<TSource, TAccumulate>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
        {
            var result = seed;
            foreach (var item in source)
            {
                result = func(result, item);
            }

            return result;
        }


        public static TResult MyAggregate<TSource, TAccumulate, TResult>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
        {
            TAccumulate result = seed;
            foreach (TSource element in source)
                result = func(result, element);

            return resultSelector(result);
        }
    }
}
