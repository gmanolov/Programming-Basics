using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.FootballLeague
{
    class FootballLeagueMain
    {
        static void Main(string[] args)
        {
            double stadiumCapacity = double.Parse(Console.ReadLine());
            double allFans = double.Parse(Console.ReadLine());

            int fansA = 0;
            int fansB = 0;
            int fansV = 0;
            int fansG = 0;

            for (int i = 1; i <= allFans; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    fansA++;
                }
                else if (sector == "B")
                {
                    fansB++;
                }
                else if (sector == "V")
                {
                    fansV++;
                }
                else if (sector == "G")
                {
                    fansG++;
                }
            }

            double percentFansA = fansA * 100 / allFans;
            double percentFansB = fansB * 100 / allFans;
            double percentFansV = fansV * 100 / allFans;
            double percentFansG = fansG * 100 / allFans;
            double fansCapacityRate = allFans * 100 / stadiumCapacity;

            Console.WriteLine("{0:f2}%", percentFansA);
            Console.WriteLine("{0:f2}%", percentFansB);
            Console.WriteLine("{0:f2}%", percentFansV);
            Console.WriteLine("{0:f2}%", percentFansG);
            Console.WriteLine("{0:f2}%", fansCapacityRate);
        }
    }
}
