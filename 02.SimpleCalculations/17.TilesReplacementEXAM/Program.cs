using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.TilesReplacementEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            var squareSide = double.Parse(Console.ReadLine());
            var tileWidth = double.Parse(Console.ReadLine());
            var tileHeight = double.Parse(Console.ReadLine());
            var benchWidth = double.Parse(Console.ReadLine());
            var benchLength = double.Parse(Console.ReadLine());

            var squareArea = squareSide * squareSide;
            var benchArea = benchWidth * benchLength;
            var tileArea = tileWidth * tileHeight;

            var tilesRequired = (squareArea - benchArea) / tileArea;
            var time = tilesRequired * 0.2;
            Console.WriteLine(tilesRequired);
            Console.WriteLine(time);
        }
    }
}
