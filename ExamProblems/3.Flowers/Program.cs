using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var hrizantemi = int.Parse(Console.ReadLine());
            var roses = int.Parse(Console.ReadLine());
            var tulips = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            char holiday = char.Parse(Console.ReadLine());

            var price = 0.0;

            if (season.ToLower() == "spring" || season.ToLower() == "summer")
            {
                price = hrizantemi * 2 + roses * 4.1 + tulips * 2.5;

                if (holiday == 'Y')
                {
                    price *= 1.15;
                }
                if (tulips > 7)
                {
                    price *= 0.95;
                }
                if (hrizantemi + roses + tulips > 20)
                {
                    price *= 0.80;
                }
            }
            else
            {
                price = hrizantemi * 3.75 + roses * 4.5 + tulips * 4.15;
                if (holiday == 'Y')
                {
                    price *= 1.15;
                }
                if (roses >= 10 && season.ToLower() == "winter")
                {
                    price *= 0.9;
                }
                if (hrizantemi + roses + tulips > 20)
                {
                    price *= 0.80;
                }
            }
            Console.WriteLine("{0:f2}", price + 2);
        }
    }
}
