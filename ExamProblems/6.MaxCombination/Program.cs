using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MaxCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var maxCombinations = int.Parse(Console.ReadLine());
            var combinations = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    if (combinations == maxCombinations)
                    {
                        break;
                    }
                    Console.Write("<{0}-{1}>", i, j);
                    combinations++;
                }
            }
        }
    }
}
