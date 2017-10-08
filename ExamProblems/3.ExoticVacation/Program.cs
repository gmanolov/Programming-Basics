using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ExoticVacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 1000)
            {
                if (season.ToLower() == "summer")
                {
                    Console.WriteLine("Alaska - Camp - {0:f2}", budget * 0.65);
                }
                else if (season.ToLower() == "winter")
                {
                    Console.WriteLine("Morocco - Camp - {0:f2}", budget * 0.45);
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                if (season.ToLower() == "summer")
                {
                    Console.WriteLine("Alaska - Hut - {0:f2}", budget * 0.8);
                }
                else if (season.ToLower() == "winter")
                {
                    Console.WriteLine("Morocco - Hut - {0:f2}", budget * 0.6);
                }
            }
            else
            {
                if (season.ToLower() == "summer")
                {
                    Console.WriteLine("Alaska - Hotel - {0:f2}", budget * 0.9);
                }
                else if (season.ToLower() == "winter")
                {
                    Console.WriteLine("Morocco - Hotel - {0:f2}", budget * 0.9);

                }
            }
        }
    }
}
