using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var score = double.Parse(Console.ReadLine());
            var bonusPoints = 0.0;
            var totalScore = 0.0;

            if (score <= 100)
            {
                bonusPoints = 5;
            }
            else if (score > 1000)
            {
                bonusPoints = 0.1 * score;
            }
            else if (score > 100)
            {
                bonusPoints = 0.2 * score;
            }

            if (score % 2 == 0)
            {
                bonusPoints += 1;
            }
            else if (score % 10 == 5)
            {
                bonusPoints += 2;
            }

            totalScore = score + bonusPoints;

            Console.WriteLine(bonusPoints);
            Console.WriteLine(totalScore);
        }
    }
}
