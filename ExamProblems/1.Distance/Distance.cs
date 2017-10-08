using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Distance
{
    class Distance
    {
        static void Main(string[] args)
        {
            var initialSpeed = int.Parse(Console.ReadLine());
            var firstTime = int.Parse(Console.ReadLine());
            var secondTime = int.Parse(Console.ReadLine());
            var thirdTime = int.Parse(Console.ReadLine());

            var distanceInitial = initialSpeed * (firstTime / 60.0);
            var speedIncreased = initialSpeed * 1.1;
            var secondDistance = speedIncreased * (secondTime / 60.0);
            var speedDecreased = speedIncreased * 0.95;
            var thirdDistance = speedDecreased * (thirdTime / 60.0);
            var fullDistance = distanceInitial + secondDistance + thirdDistance;

            Console.WriteLine("{0:f2}", fullDistance);
        }
    }
}
