using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 5 * n;

            for (int row = 0; row < n; row++)
            {
                var start = new string('-', n * 3);
                var middle = new string('-', row);
                var end = new string('-', n * 2 - row - 2);

                Console.WriteLine("{0}*{1}*{2}", start, middle, end);
            }

            var leadingStars = new string('*', n * 3);

            for (int row = 0; row < n / 2; row++)
            {
                Console.WriteLine(leadingStars + "*" + new string('-', n - 1) + "*" + new string('-', n - 1));
            }

            var filling = n - 1;
            
            for (int row = 1; row <= n / 2; row++)
            {
                var start = new string('-', n * 3 - row + 1);
                var middle = new string('-', filling);
                var end = new string('-', n - row);
                var replace = new string('*', filling);

                if (row == n / 2)
                {
                    middle = replace;
                }
                Console.WriteLine("{0}*{1}*{2}", start, middle, end);
                filling += 2;
            }
        }
    }
}
