using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var width = 5 * n;
            var height = 3 * n + 2;
            var dotsUpper = 3 * n;

            Console.WriteLine(new string ('.', n) + new string ('*', 3 * n) + new string ('.', n));

            for (int row = 1; row < n; row++)
            {
                Console.Write(new string ('.', n - row));
                Console.Write("*");
                Console.Write(new string ('.', dotsUpper));
                Console.Write("*");
                Console.WriteLine(new string('.', n - row));
                dotsUpper += 2;
            }

            Console.WriteLine(new string ('*', width));

            for (int row = 1; row <= n * 2; row++)
            {
                Console.Write(new string('.', row));
                Console.Write("*");
                Console.Write(new string('.', width - 2 * row - 2));
                Console.Write("*");
                Console.WriteLine(new string('.', row));
            }

            Console.WriteLine(new string ('.', 2 * n + 1) + new string ('*', n - 2) + new string('.', 2 * n + 1));
        }
    }
}
