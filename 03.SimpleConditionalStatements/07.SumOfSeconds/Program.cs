using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumOfSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstSec = double.Parse(Console.ReadLine());
            var secondSec = double.Parse(Console.ReadLine());
            var thirdSec = double.Parse(Console.ReadLine());

            var totalSec = firstSec + secondSec + thirdSec;
            var minutes = 0;

            if (totalSec >= 120)
            {
                minutes = 2;
                totalSec = totalSec - 120;
            }
            else if (totalSec >= 60)
            {
                minutes = 1;
                totalSec = totalSec - 60;
            }

            Console.WriteLine("{0}:{1:00}", minutes, totalSec);
        }
    }
}
