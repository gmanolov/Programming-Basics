using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal USD = decimal.Parse(Console.ReadLine());

            decimal toBGN = USD * 1.79549M;
            Console.WriteLine("{0:f2} BGN", toBGN);
        }
    }
}
