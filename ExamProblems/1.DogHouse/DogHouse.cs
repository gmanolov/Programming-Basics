using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DogHouse
{
    class DogHouse
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());

            var sides = (length * (length / 2)) * 2;
            var backWall = (length / 2) * (length / 2) + (length / 2 * (width - length / 2)) / 2;
            var frontWall = backWall - (length / 5 * length / 5);
            var roof = 2 * (length * (length / 2));

            var greenPaint = (sides + backWall + frontWall) / 3;
            var redPaint = roof / 5;

            Console.WriteLine("{0:f2}", greenPaint);
            Console.WriteLine("{0:f2}", redPaint);
        }
    }
}
