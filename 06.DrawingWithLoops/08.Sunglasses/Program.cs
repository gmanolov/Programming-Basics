using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*', n * 2) + new string(' ', n) + new string('*', n * 2));

            for (int row = 1; row <= n - 2; row++)
            {
                string spaces = new string(' ', n);
                string bridge = new string('|', n);

                if (row == (n - 1) / 2)
                {
                    spaces = bridge;
                }

                Console.WriteLine("*{0}*{1}*{0}*", new string('/', n * 2 - 2), spaces);
            }

            Console.WriteLine(new string('*', n * 2) + new string(' ', n) + new string('*', n * 2));
        }
    }
}
