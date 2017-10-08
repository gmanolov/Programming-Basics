using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var area = double.Parse(Console.ReadLine());
            var windows = int.Parse(Console.ReadLine());
            var styrofoam = double.Parse(Console.ReadLine());
            var priceStyrofoam = double.Parse(Console.ReadLine());

            var styroArea = (area - windows * 2.4) * 1.1;
            var styroNeeded = Math.Ceiling(styroArea / styrofoam);
            var sum = styroNeeded * priceStyrofoam;

            if (budget >= sum)
            {
                Console.WriteLine("Spent: {0:f2}\nLeft: {1:f2}", sum, budget - sum);
            }
            else
            {
                Console.WriteLine("Need more: {0:f2}", sum - budget);
            }
        }
    }
}
