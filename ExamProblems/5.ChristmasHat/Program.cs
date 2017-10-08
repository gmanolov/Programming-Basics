using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ChristmasHat
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 4 * n + 1;
            var height = 2 * n + 5;

            Console.WriteLine(new string('.', 2 * n - 1) + "/|\\" + new string('.', 2 * n - 1));
            Console.WriteLine(new string('.', 2 * n - 1) + "\\|/" + new string('.', 2 * n - 1));

            var under = 0;
            for (int row = 1; row <= n * 2; row++)
            {
                var dots = new string('.', n * 2 - row);
                var underscore = new string('-', under);
                Console.WriteLine("{0}*{1}*{1}*{0}", dots, underscore);
                under++;
            }

            for (int row = 1; row <= 1; row++)
            {
                Console.WriteLine(new string('*', width));
                for (int col = 0; col < width / 2; col++)
                {
                    Console.Write("*.");
                }
                Console.WriteLine("*");
                Console.WriteLine(new string('*', width));
            }
        }
    }
}
