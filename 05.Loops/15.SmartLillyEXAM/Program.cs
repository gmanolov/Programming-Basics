using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.SmartLillyEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var laundryPrice = double.Parse(Console.ReadLine());
            var singleToyPrice = int.Parse(Console.ReadLine());

            var toys = 0.0;
            var birthdayMoney = 0.0;
            var moneyTaken = age / 2;
            var birthdayMoneySum = 0.0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    toys++;
                }
                else
                {
                    birthdayMoney += 10;
                    birthdayMoneySum = birthdayMoneySum + birthdayMoney;
                }
            }

            var toysMoney = toys * singleToyPrice;
            var moneyAvailable = birthdayMoneySum + toysMoney - moneyTaken;

            if (moneyAvailable >= laundryPrice)
            {
                Console.WriteLine("Yes! {0:f2}", moneyAvailable - laundryPrice);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", laundryPrice - moneyAvailable);
            }
        }
    }
}
