using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.VegetablesMarketEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegetablesPriceKg = double.Parse(Console.ReadLine());
            var fruitPriceKg = double.Parse(Console.ReadLine());
            var kgVegetables = int.Parse(Console.ReadLine());
            var kgFruit = int.Parse(Console.ReadLine());

            var incomeVegetables = vegetablesPriceKg * kgVegetables;
            var incomeFruit = fruitPriceKg * kgFruit;

            var eur = 1.94;
            var sumEUR = (incomeVegetables + incomeFruit) / eur;
            Console.WriteLine(sumEUR);
        }
    }
}
