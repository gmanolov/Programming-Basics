using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string currentCurrency = Console.ReadLine();
            string wantedCurrency = Console.ReadLine();

            if (currentCurrency == "USD")
            {
                money = money * 1.79549;
            }
            else if (currentCurrency == "EUR")
            {
                money = money * 1.95583;
            }
            else if (currentCurrency == "GBP")
            {
                money = money * 2.53405;
            }

            if (wantedCurrency == "USD")
            {
                money = money / 1.79549;

            }
            else if (wantedCurrency == "EUR")
            {
                money = money / 1.95583;

            }
            else if (wantedCurrency == "GBP")
            {
                money = money / 2.53405;
            }
            Console.WriteLine("{0:f2} {1}", money, wantedCurrency);
        }
    }
}
