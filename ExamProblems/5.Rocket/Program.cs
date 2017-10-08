using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int width = n * 3;
            var spaces = 0;
            
            for (int row = 1; row <= n; row++)
            {
                var dots = (width - spaces - 2) / 2;
                var writeDots = new string ('.', dots);
                var hollow = new string(' ', spaces);
                Console.WriteLine("{0}/{1}\\{0}", writeDots, hollow);
                spaces += 2;
            }

            Console.WriteLine(new string('.', n/2) + new string('*', width - n) + new string('.', n/2));

            for (int row = 1; row <= n * 2; row++)
            {
                Console.WriteLine(new string('.', n/2) + "|" + new string('\\', width - n - 2) + "|" + new string('.', n / 2));
            }

            var lowerDots = n / 2;
            for (int row = 1; row <= n / 2; row++)
            {
                var stars = width - lowerDots * 2 - 2;
                Console.WriteLine(new string('.', lowerDots) + "/" + new string('*', stars) + "\\" + new string('.', lowerDots));
                lowerDots -= 1;
            }
        }
    }
}
