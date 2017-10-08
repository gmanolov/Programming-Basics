using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var finalNumber = int.Parse(Console.ReadLine());
            var number = 1;

            for (int row = 1; row <= finalNumber; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(number + " ");
                    number++;

                    if (number > finalNumber)
                    {
                        break;
                    }
                }

                Console.WriteLine();

                if (number > finalNumber)
                {
                    break;
                }
            }
        }
    }
}
