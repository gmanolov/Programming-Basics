using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DrawFortEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int columns = 2 * n;
            int towers = n / 2;
            int betweenTowers = columns - 4 - 2 * towers;

            Console.WriteLine("/" + new string('^', towers) + "\\" + new string('_', betweenTowers) + "/" + new string('^', towers) + "\\");

            for (int row = 1; row <= n - 2; row++)
            {
                if (row == n - 2)
                {
                    Console.WriteLine("|" + new string(' ', towers + 1) + new string('_', betweenTowers) + new string(' ', towers + 1) + "|");
                }
                else
                {
                    Console.WriteLine("|" + new string(' ', columns - 2) + "|");
                }
            }

            Console.WriteLine("\\" + new string('_', towers) + "/" + new string(' ', betweenTowers) + "\\" + new string('_', towers) + "/");
        }
    }
}
