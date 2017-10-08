using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ToyShop
{
    class ToyShopMain
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double totalSum = puzzles * 2.6 + dolls * 3.0 + bears * 4.1 + minions * 8.2 + trucks * 2;
            int totalToys = puzzles + dolls + bears + minions + trucks;

            if (totalToys >= 50)
            {
                totalSum *= 0.75;
            }

            double profit = totalSum * 0.9;

            if (profit >= tripPrice)
            {
                Console.WriteLine("Yes! {0:f2} lv left.", profit - tripPrice);
            }
            else
            {
                Console.WriteLine("Not enough money! {0:f2} lv needed.", tripPrice - profit);
            }
        }
    }
}
