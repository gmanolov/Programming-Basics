using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.JourneyEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            var moneySpent = 0.0;

            if (budget > 1000)
            {
                moneySpent = 0.9 * budget;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", moneySpent);
            }
            else if (budget <= 100)
            {
                if (season == "summer")
                {
                    moneySpent = 0.3 * budget;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:f2}", moneySpent);
                }
                else
                {
                    moneySpent = 0.7 * budget;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:f2}", moneySpent);
                }
            }
            else
            {
                if (season == "summer")
                {
                    moneySpent = 0.4 * budget;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:f2}", moneySpent);
                }
                else
                {
                    moneySpent = 0.8 * budget;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:f2}", moneySpent);
                }
            }
        }
    }
}
