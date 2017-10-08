using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.AlcoholMarket
{
    class AlcoholMarketMain
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerLitres = double.Parse(Console.ReadLine());
            double wineLitres = double.Parse(Console.ReadLine());
            double rakiaLitres = double.Parse(Console.ReadLine());
            double whiskeyLitres = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskeyPrice * 0.5;
            double winePrice = rakiaPrice - (0.4 * rakiaPrice);
            double beerPrice = rakiaPrice - (0.8 * rakiaPrice);

            double totalSum = whiskeyLitres * whiskeyPrice + rakiaLitres * rakiaPrice + wineLitres * winePrice + beerLitres * beerPrice;
            Console.WriteLine("{0:f2}", totalSum);
        }
    }
}
