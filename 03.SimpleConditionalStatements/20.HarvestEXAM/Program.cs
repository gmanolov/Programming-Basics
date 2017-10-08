using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.HarvestEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            var vineyard = int.Parse(Console.ReadLine());
            var grapes = double.Parse(Console.ReadLine());
            var wineRequired = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var totalWine = 0.4 * vineyard * grapes / 2.5;

            if (totalWine < wineRequired)
            {
                var insufficientWine = wineRequired - totalWine;
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(insufficientWine));
            }
            else
            {
                var wineRemaining = totalWine - wineRequired;
                var perPerson = wineRemaining / workers;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(totalWine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wineRemaining), Math.Ceiling(perPerson));
            }
        }
    }
}
