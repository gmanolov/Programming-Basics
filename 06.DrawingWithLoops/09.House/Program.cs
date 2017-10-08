using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                for (int row = 1; row <= (n + 1) / 2; row++)
                {
                    Console.Write(new string('-', n / 2 - row));
                    Console.Write(new string('*', 2 * row));
                    Console.Write(new string('-', n / 2 - row));
                    Console.WriteLine();
                }
            }
            else
            {
                for (int row = 1; row <= (n + 1) / 2; row++)
                {
                    Console.Write(new string('-', n / 2 - row + 1));
                    Console.Write(new string('*', 2 * row - 1));
                    Console.Write(new string('-', n / 2 - row + 1));
                    Console.WriteLine();
                }
            }

            for (int row = 1; row <= n / 2; row++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.WriteLine("|");
            }
        }
    }
}
