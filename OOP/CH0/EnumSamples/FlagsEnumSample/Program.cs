using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagsEnumSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Authority autority = Authority.Read | Authority.Write; // 疊加狀態
            Console.WriteLine(autority.ToString());
            Console.WriteLine(Convert.ToInt32(autority));

            if ((autority & Authority.Read) == Authority.Read) //確認有某個狀態
            {
                Console.WriteLine("有讀取權限");
            }
            else
            {
                Console.WriteLine("無讀取權限");
            }

            Console.ReadLine();
        }
    }

    [Flags]
    public enum Authority
    {
        Read = 1,
        Write = 2,
        Create = 4,
        Delete = 8
    }

}
