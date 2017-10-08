using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallestRoom = double.Parse(Console.ReadLine());
            var kitchenArea = double.Parse(Console.ReadLine());
            var pricePerSquareM = double.Parse(Console.ReadLine());

            var bathroom = smallestRoom * 0.5;
            var secondRoom = smallestRoom * 1.1;
            var thirdRoom = secondRoom * 1.1;

            var totalArea = (smallestRoom + secondRoom + thirdRoom + bathroom + kitchenArea) * 1.05;
            var price = pricePerSquareM * totalArea;

            Console.WriteLine("{0:f2}", price);
        }
    }
}
