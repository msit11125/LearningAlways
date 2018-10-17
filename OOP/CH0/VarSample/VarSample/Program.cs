using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            var newwords = words.Select((w) =>
                   new { Upper = w.ToUpper(), Lower = w.ToLower() });
            foreach (var x in newwords)
            { Console.WriteLine(x.Upper + " : " + x.Lower); }           

            Console.ReadLine();
        }
    }
}
