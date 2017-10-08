using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.StopSignEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('.', n + 1) + new string('_', 2 * n + 1) + new string('.', n + 1));

            var countUnder = n * 2 - 1;

            for (int row = 0; row < n; row++)
            {
                var dots = new string('.', n - row);
                var underscore = new string('_', countUnder);
                Console.WriteLine("{0}//{1}\\\\{0}", dots, underscore);
                countUnder += 2;
            }

            Console.WriteLine("//" + new string('_', (4 * n - 6) / 2) + "STOP!" + new string('_', (4 * n - 6) / 2) + "\\\\");

            var decreaseUnder = 4 * n - 1;

            for (int row = 0; row < n; row++)
            {
                var dots = new string('.', row);
                var underscore = new string('_', decreaseUnder);
                Console.WriteLine("{0}\\\\{1}//{0}", dots, underscore);
                decreaseUnder -= 2;
            }
        }
    }
}
