using System;

namespace StaticField
{
    class Program
    {
        private int x; // 執行個體欄位
        private static int y; // 型別靜態欄位

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        void Set()
        {

            x = 1;

            // 兩個相同
            y = 1;
            Program.y = 1;
        }
    }
}
