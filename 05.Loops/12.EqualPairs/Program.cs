using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            int sum = numOne + numTwo;
            int maxDiff = 0;

            for (int i = 1; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                var tempSum = num1 + num2;

                if (!(tempSum == sum))
                {
                    var diff = Math.Abs(sum - tempSum);
                    if (diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }
                sum = tempSum;
            }

            if (maxDiff == 0)
            {
                Console.WriteLine("Yes, value={0}", sum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
        }
    }
}
