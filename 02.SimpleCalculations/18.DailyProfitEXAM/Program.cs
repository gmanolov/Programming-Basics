using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.DailyProfitEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            var workDays = int.Parse(Console.ReadLine());
            var moneyPerDay = double.Parse(Console.ReadLine());
            var dollarRate = double.Parse(Console.ReadLine());

            var annualSalary = workDays * moneyPerDay * 14.5;
            var afterTax = annualSalary * 0.75;
            var dailyProfit = (afterTax * dollarRate) / 365;
            Console.WriteLine("{0:F2}", dailyProfit);
        }
    }
}
