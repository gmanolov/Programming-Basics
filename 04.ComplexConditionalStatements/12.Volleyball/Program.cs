using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var yearType = Console.ReadLine();
            var holidays = int.Parse(Console.ReadLine());
            var weekendsHome = int.Parse(Console.ReadLine());

            var weekends = 48.0;

            var gamesSofia = (weekends - weekendsHome) * 3.0 / 4;
            var gamesHoliday = holidays * 2.0 / 3;
            var totalGames = gamesSofia + gamesHoliday + weekendsHome;

            if (yearType.ToLower() == "leap")
            {
                totalGames *= 1.15;
                Console.WriteLine(Math.Truncate(totalGames));
            }
            else
            {
                Console.WriteLine(Math.Truncate(totalGames));
            }
        }
    }
}
