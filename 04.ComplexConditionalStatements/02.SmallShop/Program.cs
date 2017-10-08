using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var city = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());

            var cost = 0.0;

            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    cost = quantity * 0.5;
                }
                else if (product == "water")
                {
                    cost = quantity * 0.8;
                }
                else if (product == "beer")
                {
                    cost = quantity * 1.2;
                }
                else if (product == "sweets")
                {
                    cost = quantity * 1.45;
                }
                else if (product == "peanuts")
                {
                    cost = quantity * 1.6;
                }
                Console.WriteLine(cost);
            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    cost = quantity * 0.4;
                }
                else if (product == "water")
                {
                    cost = quantity * 0.7;
                }
                else if (product == "beer")
                {
                    cost = quantity * 1.15;
                }
                else if (product == "sweets")
                {
                    cost = quantity * 1.3;
                }
                else if (product == "peanuts")
                {
                    cost = quantity * 1.5;
                }
                Console.WriteLine(cost);
            }
            else if (city == "Varna")
            {
                if (product == "coffee")
                {
                    cost = quantity * 0.45;
                }
                else if (product == "water")
                {
                    cost = quantity * 0.7;
                }
                else if (product == "beer")
                {
                    cost = quantity * 1.1;
                }
                else if (product == "sweets")
                {
                    cost = quantity * 1.35;
                }
                else if (product == "peanuts")
                {
                    cost = quantity * 1.55;
                }
                Console.WriteLine(cost);
            }
        }
    }
}
