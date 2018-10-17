using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join
{
    class Program
    {
        static void Main(string[] args)
        {
            // INNER JOIN 用 IEnumerable<T>.Join實作
            // CROSS JOIN 用 IEnumerable<T>.SelectMany()實作
            // LEFT JOIN 用 IEnumerable<T>.GroupJoin()實作

            var table1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            var table2 = new List<int>() { 2, 4, 6, 8};

            // 1. INNER JOIN
            // LINQ 陳述式
            var query = from item1 in table1
                        join item2 in table2 on item1 equals item2
                        select item2;
            // LINQ 函式
            var query2 = table1.Join(
                table2,
                item1 => item1,
                item2 => item2,
                (item1, item2) => new { item1, item2 }
                );


            // 2. LEFT JOIN
            // LINQ 陳述式
            var query3 = from item1 in table1
                        join item2 in table2 on item1 equals item2 into g
                        from groupItem in g.DefaultIfEmpty()
                        select new { v = item1 , c = groupItem /*所屬Group*/};
            // LINQ 函式
            var query4 = table1.GroupJoin(
                table2,
                item1 => item1,
                item2 => item2,
                (item1, item2) => new { v = item1, c = item2.Count() }
                );
        }
    }
}
