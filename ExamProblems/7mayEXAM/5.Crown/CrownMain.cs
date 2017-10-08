using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Crown
{
    class CrownMain
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n - 1;
            int height = n / 2 + 4;

            Console.WriteLine("@" + new string(' ', n - 2) + "@" + new string(' ', n - 2) + "@");
            Console.WriteLine("**" + new string(' ', n - 3) + "*" + new string(' ', n - 3) + "**");

            int middleDots = 1;
            for (int row = 1; row <= n / 2; row++)
            {          
                if (row == n / 2 - 1)
                {
                    Console.WriteLine("*" + new string('.', row) + "*" + new string('.', middleDots) + "*" + new string('.', row) + "*");
                }
                else if (row == n / 2)
                {
                    Console.WriteLine("*" + new string('.', row) + new string('*', n / 2 - 2) + "." + new string('*', n / 2 - 2) + new string('.', row) + "*");
                }
                else
                {
                    Console.WriteLine("*" + new string('.', row) + "*" + new string(' ', (width - 6 - middleDots - 2 * row) / 2) + "*" + new string('.', middleDots) + "*" +
                    new string(' ', (width - 6 - middleDots - 2 * row) / 2) + "*" + new string('.', row) + "*");
                }

                middleDots += 2;
            }

            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine(new string('*', width));
            }
        }
    }
}
