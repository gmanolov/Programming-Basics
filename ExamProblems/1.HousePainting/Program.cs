using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            var xHeight = double.Parse(Console.ReadLine());
            var yLength = double.Parse(Console.ReadLine());
            var hRoofHeight = double.Parse(Console.ReadLine());

            var frontBackWalls = (xHeight * xHeight) * 2 - (1.2 * 2);
            var sideWalls = (xHeight * yLength) * 2 - (2 * 1.5 * 1.5);
            var roof = (xHeight * yLength) * 2 + (xHeight * hRoofHeight / 2) * 2;
            var greenPaint = (frontBackWalls + sideWalls) / 3.4;
            var redPaint = roof / 4.3;
            Console.WriteLine("{0:f2}\n{1:f2}", greenPaint, redPaint); 
        }
    }
}
