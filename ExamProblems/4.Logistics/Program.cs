using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var loads = int.Parse(Console.ReadLine());

            var sumOfLoads = 0.0;
            var bus = 0;
            var truck = 0;
            var train = 0;
            var averagePrice = 0.0;

            for (int i = 1; i <= loads; i++)
            {
                var tons = int.Parse(Console.ReadLine());

                if (tons < 4)
                {
                    bus += tons;
                }
                else if (tons > 3 && tons < 12)
                {
                    truck += tons;
                }
                else
                {
                    train += tons;
                }
            }

            sumOfLoads = bus + truck + train;
            averagePrice = (bus * 200 + truck * 175 + train * 120) / sumOfLoads;
            var busPercent = bus / sumOfLoads * 100;
            var truckPercent = truck / sumOfLoads * 100;
            var trainPercent = train / sumOfLoads * 100;

            Console.WriteLine("{0:f2}", averagePrice);
            Console.WriteLine("{0:f2}%", busPercent);
            Console.WriteLine("{0:f2}%", truckPercent);
            Console.WriteLine("{0:f2}%", trainPercent);
        }
    }
}
