using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());

            var moneySpent = 0.0;
            var age = 18;

            for (int i = 1800; i <= year; i++, age++)
            {
                if (i % 2 == 0)
                {
                    moneySpent += 12000;
                }
                else
                {
                    moneySpent += 12000 + 50 * age;
                }
            }

            if (moneySpent > money)
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(money - moneySpent));
            }
            else
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", Math.Abs(moneySpent - money));
            }
        }
    }
}
