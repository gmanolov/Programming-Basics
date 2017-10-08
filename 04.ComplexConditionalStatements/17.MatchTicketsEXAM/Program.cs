using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.MatchTicketsEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            var people = int.Parse(Console.ReadLine());

            var vip = 499.99;
            var normal = 249.99;
            var transportCost = 0.0;
            var ticketsSum = 0.0;
            var budgetLeft = 0.0;

            if (people >= 50)
            {
                transportCost = budget * 0.25;
                budgetLeft = budget - transportCost;
                if (category.ToLower() == "vip")
                {
                    ticketsSum = people * vip;
                }
                else
                {
                    ticketsSum = people * normal;
                }
            }
            else if (people > 24 && people < 50)
            {
                transportCost = budget * 0.4;
                budgetLeft = budget - transportCost;
                if (category.ToLower() == "vip")
                {
                    ticketsSum = people * vip;
                }
                else
                {
                    ticketsSum = people * normal;
                }
            }
            else if (people > 9 && people < 25)
            {
                transportCost = budget * 0.5;
                budgetLeft = budget - transportCost;
                if (category.ToLower() == "vip")
                {
                    ticketsSum = people * vip;
                }
                else
                {
                    ticketsSum = people * normal;
                }
            }
            else if (people > 4 && people < 10)
            {
                transportCost = budget * 0.6;
                budgetLeft = budget - transportCost;
                if (category.ToLower() == "vip")
                {
                    ticketsSum = people * vip;
                }
                else
                {
                    ticketsSum = people * normal;
                }
            }
            else
            {
                transportCost = budget * 0.75;
                budgetLeft = budget - transportCost;
                if (category.ToLower() == "vip")
                {
                    ticketsSum = people * vip;
                }
                else
                {
                    ticketsSum = people * normal;
                }
            }
            if (budgetLeft >= ticketsSum)
            {
                var moneyLeft = budgetLeft - ticketsSum;
                Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft);
            }
            else
            {
                var moneyReq = ticketsSum - budgetLeft;
                Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyReq);
            }
        }
    }
}
