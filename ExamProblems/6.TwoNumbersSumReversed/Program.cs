using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.TwoNumbersSumReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            int startInterval = int.Parse(Console.ReadLine());
            int endInterval = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = startInterval; i >= endInterval; i--)
            {
                for (int k = startInterval; k >= endInterval; k--)
                {
                    count++;
                    bool magic = i + k == magicNumber;

                    if (magic)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {k} = {magicNumber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
        }
    }
}
