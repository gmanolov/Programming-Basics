using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ButterflyEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = new string('*', n - 2);
            var middleLine = new string(' ', n - 1) + "@" + new string(' ', n - 1);

            for (int i = 1; i <= n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    stars = new string('-', n - 2);
                }

                Console.WriteLine("{0}\\ /{0}", stars);
                stars = new string('*', n - 2);
            }

            Console.WriteLine(middleLine);

            for (int i = 1; i <= n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    stars = new string('-', n - 2);
                }

                Console.WriteLine("{0}/ \\{0}", stars);
                stars = new string('*', n - 2);
            }
        }
    }
}
