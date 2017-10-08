using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstDigit = n / 100;
            int secondDigit = (n / 10) % 10;
            int thirdDigit = n % 10;

            var rowsCount = firstDigit + secondDigit;
            var colsCount = firstDigit + thirdDigit;

            for (int rows = 1; rows <= rowsCount; rows++)
            {
                for (int cols = 1; cols <= colsCount; cols++)
                {
                    if (n % 5 == 0)
                    {
                        n = n - firstDigit;
                    }
                    else if (n % 3 == 0)
                    {
                        n = n - secondDigit;
                    }
                    else
                    {
                        n = n + thirdDigit;
                    }
                    Console.Write($"{n} ");
                }
                Console.WriteLine();
            } 
        }
    }
}
