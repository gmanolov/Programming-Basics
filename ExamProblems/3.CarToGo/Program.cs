using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 100)
            {
                if (season.ToLower() == "summer")
                {
                    Console.WriteLine("Economy class\nCabrio - {0:f2}", budget * 0.35);
                }
                else if (season.ToLower() == "winter")
                {
                    Console.WriteLine("Economy class\nJeep - {0:f2}", budget * 0.65);
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                if (season.ToLower() == "summer")
                {
                    Console.WriteLine("Compact class\nCabrio - {0:f2}", budget * 0.45);
                }
                else if (season.ToLower() == "winter")
                {
                    Console.WriteLine("Compact class\nJeep - {0:f2}", budget * 0.8);
                }
            }
            else
            {
                Console.WriteLine("Luxury class\nJeep - {0:f2}", budget * 0.9);
            }
        }
    }
}
