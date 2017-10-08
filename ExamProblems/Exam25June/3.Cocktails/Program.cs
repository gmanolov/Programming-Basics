using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Cocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int numberOfOrders = int.Parse(Console.ReadLine());

            double watermelonPriceSmall = 56.0 * 2;
            double watermelonPriceBig = 28.7 * 5;
            double mangoPriceSmall = 36.66 * 2;
            double mangoPriceBig = 19.6 * 5;
            double pineapplePriceSmall = 42.1 * 2;
            double pineapplePriceBig = 24.8 * 5;
            double raspberryPriceSmall = 20.0 * 2;
            double raspberryPriceBig = 15.2 * 5;
            double sum = 0.0;

            if (fruit == "Watermelon")
            {
                if (size == "small")
                {
                    sum = numberOfOrders * watermelonPriceSmall;
                }
                else if (size == "big")
                {
                    sum = numberOfOrders * watermelonPriceBig;
                }
            }
            else if (fruit == "Mango")
            {
                if (size == "small")
                {
                    sum = numberOfOrders * mangoPriceSmall;
                }
                else if (size == "big")
                {
                    sum = numberOfOrders * mangoPriceBig;
                }
            }
            else if (fruit == "Pineapple")
            {
                if (size == "small")
                {
                    sum = numberOfOrders * pineapplePriceSmall;
                }
                else if (size == "big")
                {
                    sum = numberOfOrders * pineapplePriceBig;
                }
            }
            else if (fruit == "Raspberry")
            {
                if (size == "small")
                {
                    sum = numberOfOrders * raspberryPriceSmall;
                }
                else if (size == "big")
                {
                    sum = numberOfOrders * raspberryPriceBig;
                }
            }

            if (sum > 1000)
            {
                sum = sum / 2.0;
            }
            else if (sum >= 400 && sum <= 1000)
            {
                sum = sum * 0.85;
            }

            Console.WriteLine("{0:f2} lv.", sum);

        }
    }
}
