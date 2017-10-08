using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = int.Parse(Console.ReadLine());

            var oddSum = 0.0;
            var evenSum = 0.0;
            var minOdd = double.MaxValue;
            var maxOdd = double.MinValue;
            var minEven = double.MaxValue;
            var maxEven = double.MinValue;

            for (int i = 1; i <= elements; i++)
            {
                var number = double.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    oddSum += number;
                    if (number < minOdd)
                    {
                        minOdd = number;
                    }
                    if (number > maxOdd)
                    {
                        maxOdd = number;
                    }
                }
                else
                {
                    evenSum += number;
                    if (number < minEven)
                    {
                        minEven = number;
                    }
                    if (number > maxEven)
                    {
                        maxEven = number;
                    }
                }
            }

            Console.WriteLine("OddSum={0},", oddSum);

            if (minOdd == double.MaxValue)
            {
                Console.WriteLine("OddMin=No");
            }
            else
            {
                Console.WriteLine("OddMin={0}", minOdd);
            }

            if (maxOdd == double.MinValue)
            {
                Console.WriteLine("OddMax=No");
            }
            else
            {
                Console.WriteLine("OddMax={0}", maxOdd);
            }

            Console.WriteLine("EvenSum={0},", evenSum);

            if (minEven == double.MaxValue)
            {
                Console.WriteLine("EvenMin=No");
            }
            else
            {
                Console.WriteLine("EvenMin={0}", minEven);
            }

            if (maxEven == double.MinValue)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMax={0}", maxEven);
            }
        }
    }
}
