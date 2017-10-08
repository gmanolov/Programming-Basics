using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var widthHeight = 2 * n + 1;

            Console.WriteLine(new string('*', widthHeight));
           
            for (int row = 1; row < n; row++)
            {
                var spaces = new string(' ', widthHeight - 2 * row - 2);
                var replaceSpaces = new string('@', widthHeight - 2 * row - 2);

                if (row > 1)
                {
                    spaces = replaceSpaces;
                }

                Console.WriteLine(new string ('.', row) + "*" + spaces + "*" + new string('.', row));
            }

            Console.WriteLine(new string('.', n) + "*" + new string('.', n));

            for (int row = 1; row <= n - 1; row++)
            {
                var emptySpaces = new string(' ', row - 1);
                var filling = new string('@', row - 1);

                if (row == n - 1)
                {
                    emptySpaces = filling;
                }
                Console.WriteLine(new string('.', n - row) + "*" + emptySpaces + "@" + emptySpaces + "*" + new string('.', n - row));
            }

            Console.WriteLine(new string('*', widthHeight));
        }
    }
}
