using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Gender man = Gender.Man;
            Console.WriteLine(man.ToString());

            Gender woman = Gender.Woman;
            Console.WriteLine(woman.ToString());



            Console.ReadLine();
        }
    }


    public enum Gender
    { Man, Woman }

    public enum Days : byte
    { Sat = 1, Sun, Mon, Tue, Wed, Thu, Fri }

    public enum PowerStatus
    {
        On= 4,
        Off =8
    }
}
