using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 0;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    number = row + col;

                    if (number > n)
                    {
                        number = 2 * n - number;
                    }

                    Console.Write("{0} ", number);
                }

                Console.WriteLine();
            }
        }
    }
}
