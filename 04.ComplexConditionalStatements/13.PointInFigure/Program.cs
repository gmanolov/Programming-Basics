using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.PointInFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool insideDown = (x > 0 && x < 3 * h) && (y > 0 && y < h);
            bool insideUp = (x > h && x < 2 * h) && (y >= h && y < 4 * h);


            bool upCentre = y == 4 * h && x >= h && x <= 2 * h;
            bool upRight = x == 2 * h && y >= h && y <= 4 * h;
            bool upLeft = x == h && y >= h && y <= 4 * h;
            bool downCentre = x >= 0 & x <= 3 * h && y == 0;
            bool downLeft = x == 0 && y >= 0 && y <= h;
            bool downRight = x == 3 * h && y >= 0 && y <= h;
            bool downUpright = y == h && x >= 0 && x <= h;
            bool downUpleft = y == h && x >= 2 * h && x <= 3 * h;

            if (insideDown || insideUp)
            {
                Console.WriteLine("inside");
            }
            else if (upCentre || upRight || upLeft || downCentre || downLeft || downRight || downUpright || downUpleft)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
