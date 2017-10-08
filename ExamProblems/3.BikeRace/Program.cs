using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            var juniors = int.Parse(Console.ReadLine());
            var seniors = int.Parse(Console.ReadLine());
            var trace = Console.ReadLine();
            var sum = 0.0;

            if (trace == "trail")
            {
                sum = juniors * 5.5 + seniors * 7;
            }
            else if (trace == "cross-country")
            {
                sum = juniors * 8 + seniors * 9.5;
                if (juniors + seniors >= 50)
                {
                    sum = sum * 0.75;
                }
            }
            else if (trace == "downhill")
            {
                sum = juniors * 12.25 + seniors * 13.75;
            }
            else if (trace == "road")
            {
                sum = juniors * 20 + seniors * 21.5;
            }

            var donated = sum * 0.95;
            Console.WriteLine("{0:f2}", donated);
        }
    }
}
