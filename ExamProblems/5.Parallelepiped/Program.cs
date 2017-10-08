using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Parallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var heightRows = 4 * n + 4;
            var widthCols = 3 * n + 1;
            var waves = new string('~', n - 2);
            var staticDots = new string('.', widthCols - n);

            Console.WriteLine("+" + waves + "+" + staticDots);

            for (int row = 0; row <= n * 2; row++)
            {
                var startDots = new string('.', row);
                var endDots = new string('.', widthCols - row - n - 1);
                Console.WriteLine("|{0}\\{1}\\{2}", startDots, waves, endDots);
            }

            for (int row = 0; row <= n * 2; row++)
            {
                var startDots = new string('.', row);
                var middleDots = new string('.', widthCols - row - n - 1);
                Console.WriteLine("{0}\\{1}|{2}|", startDots, middleDots, waves);
            }

            Console.WriteLine(staticDots + "+" + waves + "+");
        }
    }
}
