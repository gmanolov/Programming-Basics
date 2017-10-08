using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var magnolii = int.Parse(Console.ReadLine());
            var zumbuli = int.Parse(Console.ReadLine());
            var roses = int.Parse(Console.ReadLine());
            var cactuses = int.Parse(Console.ReadLine());
            var giftPrice = double.Parse(Console.ReadLine());

            var magnoliaPrice = 3.25;
            var zumbuliPrice = 4.0;
            var rosesPrice = 3.5;
            var cactusesPrice = 8.0;

            var sum = (magnolii * magnoliaPrice + zumbuli * zumbuliPrice + roses * rosesPrice +
                cactuses * cactusesPrice) * 0.95;

            if (sum >= giftPrice)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(sum - giftPrice));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(giftPrice - sum));
            }
        }
    }
}
