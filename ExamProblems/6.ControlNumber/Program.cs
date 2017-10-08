using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.ControlNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int toEnd = int.Parse(Console.ReadLine());
            int toStart = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
            int combinations = 0;
            int sum = 0;

            for (int i = 1; i <= toEnd; i++)
            {
                for (int k = toStart; k >= 1; k--)
                {
                    combinations++;
                    sum = sum + (i * 2 + k * 3);

                    if (sum >= controlNumber)
                    {
                        Console.WriteLine($"{combinations} moves\nScore: {sum} >= {controlNumber}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combinations} moves");
        }
    }
}
