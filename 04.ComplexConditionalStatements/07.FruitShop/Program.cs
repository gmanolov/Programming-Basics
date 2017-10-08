using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruitType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0.0;

            if (dayOfWeek.ToLower() == "monday" || dayOfWeek.ToLower() == "tuesday" || dayOfWeek.ToLower() == "wednesday" || dayOfWeek.ToLower() == "thursday" || dayOfWeek.ToLower() == "friday")
            {
                if (fruitType == "banana")
                {
                    price = 2.5;
                }
                else if (fruitType == "apple")
                {
                    price = 1.2;
                }
                else if (fruitType == "orange")
                {
                    price = 0.85;
                }
                else if (fruitType == "grapefruit")
                {
                    price = 1.45;
                }
                else if (fruitType == "kiwi")
                {
                    price = 2.7;
                }
                else if (fruitType == "pineapple")
                {
                    price = 5.5;
                }
                else if (fruitType == "grapes")
                {
                    price = 3.85;
                }
            }
            else if (dayOfWeek.ToLower() == "saturday" || dayOfWeek.ToLower() == "sunday")
            {
                if (fruitType == "banana")
                {
                    price = 2.7;
                }
                else if (fruitType == "apple")
                {
                    price = 1.25;
                }
                else if (fruitType == "orange")
                {
                    price = 0.9;
                }
                else if (fruitType == "grapefruit")
                {
                    price = 1.6;
                }
                else if (fruitType == "kiwi")
                {
                    price = 3.0;
                }
                else if (fruitType == "pineapple")
                {
                    price = 5.6;
                }
                else if (fruitType == "grapes")
                {
                    price = 4.2;
                }
            }

            if (price <= 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("{0:f2}", quantity * price);
            }
        }
    }
}
