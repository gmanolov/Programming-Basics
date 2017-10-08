using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.TransportPriceEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            var km = int.Parse(Console.ReadLine());
            var daytime = Console.ReadLine();

            var price = 0.0;

            if (km > 99)
            {
                price = km * 0.06;
            }
            else if (km > 19)
            {
                price = km * 0.09;
            }
            else if (km < 20)
            {
                if (daytime == "day")
                {
                    price = 0.7 + km * 0.79;
                }
                if (daytime == "night")
                {
                    price = 0.7 + km * 0.9;
                }
            }

            Console.WriteLine(price);
        }
    }
}
