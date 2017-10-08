using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = int.Parse(Console.ReadLine());
            var sum = 0;
            var max = int.MinValue;

            for (int i = 0; i < elements; i++)
            {
                var number = int.Parse(Console.ReadLine());
                sum = sum + number;
                if (number > max)
                {
                    max = number;
                }
            }
            if (sum / 2.0 == max)
            {
                Console.WriteLine("Yes \nSum = {0}", max);
            }
            else
            {
                var difference = Math.Abs(max - (sum - max));
                Console.WriteLine("No \nDiff = {0}", difference);
            }
        }
    }
}
