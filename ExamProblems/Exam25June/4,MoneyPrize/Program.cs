using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_MoneyPrize
{
    class Program
    {
        static void Main(string[] args)
        {
            int projectParts = int.Parse(Console.ReadLine());
            double moneyPerPoint = double.Parse(Console.ReadLine());

            int sumOfPoints = 0;

            for (int i = 1; i <= projectParts; i++)
            {
                int pointsReceived = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumOfPoints = sumOfPoints + (pointsReceived * 2);
                }
                else
                {
                    sumOfPoints += pointsReceived;
                }                             
            }

            double projectPrize = sumOfPoints * moneyPerPoint;
            Console.WriteLine("The project prize was {0:f2} lv.", projectPrize);
        }
    }
}
