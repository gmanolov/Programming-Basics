using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int width = 4 * number + 1;
            int height = 2 * number + 1;

            Console.WriteLine(new string('#', width));

            int blankSpaces = 1;
            int hashtags = number * 2 - 1;

            for (int row = 1; row <= number; row++)
            {
                if (row == number / 2 + 1)
                {
                    Console.WriteLine("{0}{1}{2}(@){2}{1}{0}", new string('.', row), new string('#', hashtags), new string(' ', number / 2 - 1));
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', row), new string('#', hashtags), new string(' ', blankSpaces));
                }            
                
                blankSpaces += 2;
                hashtags -= 2;
            }

            int middleHash = number * 2 - 1;
            for (int row = 1; row <= number; row++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', number + row), new string('#', middleHash));
                middleHash -= 2;
            }
        }
    }
}
