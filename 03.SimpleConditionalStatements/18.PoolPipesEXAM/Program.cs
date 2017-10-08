using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.PoolPipesEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            var volume = int.Parse(Console.ReadLine());
            var firstPipe = int.Parse(Console.ReadLine());
            var secondPipe = int.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());

            var firstPipeWater = firstPipe * hours;
            var secondPipeWater = secondPipe * hours;
            var water = (firstPipe * hours) + (secondPipe * hours);

            if (water <= volume)
            {
                var percentFull = (int)(water / volume * 100);
                var percentFirstPipe = (int)(firstPipeWater / water * 100);
                var percentSecondPipe = (int)(secondPipeWater / water * 100);

                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", percentFull, percentFirstPipe, percentSecondPipe);
            }
            else
            {
                var overflow = water - volume;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, overflow);
            }
        }
    }
}
