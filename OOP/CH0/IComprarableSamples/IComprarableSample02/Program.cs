using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComprarableSample02
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 x = 1;
            Int32 y = 2;
            Console.WriteLine(Compare(x, y));
            Double m = 3.2;
            Double n = 1.79;
            Console.WriteLine(Compare(m, n));

            Rect r1 = new Rect() { Width = 4, Height = 8 };
            Rect r2 = new Rect { Width = 6, Height = 5 };
            Console.WriteLine(Compare(r1, r2));
            r1.Height = 5;
            Console.WriteLine(Compare(r1, r2));

            Console.ReadLine();
        }

        private static Boolean Compare<T>(T x, T y)
          where T : IComparable<T>
        {
            if (x.CompareTo(y) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Rect : IComparable<Rect>
    {
        public int Width
        { get; set; }

        public int Height
        { get; set; }

        public int Area
        {
            get { return Width * Height; }
        }

        /// <summary>
        /// 將目前的執行個體與另一個具有相同型別的物件相比較。 (以面積為比較標準)
        /// </summary>
        /// <param name="other">要與這個物件相互比較的物件。</param>
        /// <returns>
        /// 值，表示所比較之物件的相對順序。傳回值的意義如下：值意義小於零這個物件小於 <paramref name="other" /> 參數。Zero這個物件等於 <paramref name="other" />。大於零這個物件大於 <paramref name="other" />。
        /// </returns>
        public int CompareTo(Rect other)
        {
            //if (this.Area > other.Area)
            //{
            //    return 1;
            //}
            //else if (this.Area == other.Area)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return -1;
            //}

            return (this.Area - other.Area);
        }
    }
}
