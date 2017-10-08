using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var width = 2 * n + 3;

            for (int row = 1; row <= n; row++)
            {
                var leadingStars = new string('*', row);
                var middleDashes = new string('-', width - row * 2 - 2);
                Console.WriteLine("{0}\\{1}/{0}", leadingStars, middleDashes);
            }

            for (int row = 1; row <= n/3; row++)
            {
                var startFinalStars = new string('*', n/2 + row - 1);
                var middleStars = new string('*', n - row * 2 + 2);
                Console.WriteLine("|{0}\\{1}/{0}|", startFinalStars, middleStars);
            }

            for (int row = 1; row <= n; row++)
            {
                var startFinalDashes = new string('-', row);
                var middleStars = new string('*', width - row * 2 - 2);
                Console.WriteLine("{0}\\{1}/{0}", startFinalDashes, middleStars);
            }
        }
    }
}
