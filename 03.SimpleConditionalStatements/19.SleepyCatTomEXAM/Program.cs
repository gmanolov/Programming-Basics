using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.SleepyCatTomEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            var restDays = int.Parse(Console.ReadLine());

            var gameLimit = 30000;
            var workdaysPlay = (365 - restDays) * 63;
            var restPlay = restDays * 127;

            var gameTime = workdaysPlay + restPlay;

            if (gameLimit < gameTime)
            {
                var moreTime = gameTime - gameLimit;
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", moreTime / 60, moreTime % 60);
            }
            else
            {
                var lessTime = gameLimit - gameTime;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", lessTime / 60, lessTime % 60);
            }
        }
    }
}
