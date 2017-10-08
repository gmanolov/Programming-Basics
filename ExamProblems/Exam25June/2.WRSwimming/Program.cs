using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.WRSwimming
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double metres = double.Parse(Console.ReadLine());
            double secsPerMetre = double.Parse(Console.ReadLine());


            double initialTime = metres * secsPerMetre;
            double delay = Math.Floor(metres / 15.0) * 12.5;
            double finalTime = initialTime + delay;


            if (finalTime >= worldRecord)
            {
                Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", finalTime - worldRecord);
            }
            else
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds.", finalTime);
            }
            
        }
    }
}
