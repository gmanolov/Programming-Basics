using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.TilesChange
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var widthFloor = double.Parse(Console.ReadLine());
            var lengthFloor = double.Parse(Console.ReadLine());
            var sideTriangle = double.Parse(Console.ReadLine());
            var heightTriangle  = double.Parse(Console.ReadLine());
            var priceTile = double.Parse(Console.ReadLine());
            var workMoney = double.Parse(Console.ReadLine());

            var floorArea = widthFloor * lengthFloor;
            var tileArea = sideTriangle * heightTriangle / 2;
            var neededTiles = Math.Ceiling(floorArea / tileArea) + 5;
            var requiredSum = neededTiles * priceTile + workMoney;

            if (money >= requiredSum)
            {
                Console.WriteLine("{0:f2} lv left.", money - requiredSum);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.", requiredSum - money);
            }
        }
    }
}
