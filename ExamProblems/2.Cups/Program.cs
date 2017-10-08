using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            var cupsRequired = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var workDays = int.Parse(Console.ReadLine());

            var cups = (workers * workDays * 8) / 5;

            if (cupsRequired > cups)
            {
                Console.WriteLine("Losses: {0:f2}", (cupsRequired - cups) * 4.2);
            }
            else
            {
                Console.WriteLine("{0:f2} extra money", (cups - cupsRequired) * 4.2);
            }
        }
    }
}
