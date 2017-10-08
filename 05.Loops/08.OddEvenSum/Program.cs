using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sumOdd = 0;
            var sumEven = 0;

            for (int i = 1; i <= n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += number;
                }
                else
                {
                    sumOdd += number;
                }
            }

            if (sumOdd == sumEven)
            {
                Console.WriteLine("Yes \n Sum = {0}", sumOdd);
            }
            else
            {
                Console.WriteLine("No \n Diff = {0}", Math.Abs(sumOdd - sumEven));
            }
        }
    }
}
