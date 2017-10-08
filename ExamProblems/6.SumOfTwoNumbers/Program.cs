using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startOfInterval = int.Parse(Console.ReadLine());
            int endOfInterval = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = startOfInterval; i <= endOfInterval; i++)
            {
                for (int j = startOfInterval; j <= endOfInterval; j++)
                {
                    count++;
                    bool magic = i + j == magicNumber;

                    if (magic)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {magicNumber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
        }
    }
}
