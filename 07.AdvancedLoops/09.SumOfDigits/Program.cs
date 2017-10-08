using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            while (number > 0)
            {
                sum = sum + (number % 10);
                number = number / 10;
            }

            Console.WriteLine(sum);
        }
    }
}
