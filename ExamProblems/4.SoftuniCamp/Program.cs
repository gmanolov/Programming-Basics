using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SoftuniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            var groups = int.Parse(Console.ReadLine());
            var sumOfPeople = 0.0;
            var car = 0;
            var van = 0;
            var smallBus = 0;
            var bigBus = 0;
            var train = 0;

            for (int i = 1; i <= groups; i++)
            {
                var people = int.Parse(Console.ReadLine());
                if (people < 6)
                {
                    car += people;
                }
                else if (people > 5 && people < 13)
                {
                    van += people;
                }
                else if (people > 12 && people < 26)
                {
                    smallBus += people;
                }
                else if (people > 25 && people < 41)
                {
                    bigBus += people;
                }
                else
                {
                    train += people;
                }
                sumOfPeople += people;
            }

            var carPercent = car * 100 / sumOfPeople;
            var vanPercent = van * 100 / sumOfPeople;
            var smallBusPercent = smallBus * 100 / sumOfPeople;
            var bigBusPercent = bigBus * 100 / sumOfPeople;
            var trainPercent = train * 100 / sumOfPeople;

            Console.WriteLine("{0:f2}%", carPercent);
            Console.WriteLine("{0:f2}%", vanPercent);
            Console.WriteLine("{0:f2}%", smallBusPercent);
            Console.WriteLine("{0:f2}%", bigBusPercent);
            Console.WriteLine("{0:f2}%", trainPercent);

        }
    }
}
