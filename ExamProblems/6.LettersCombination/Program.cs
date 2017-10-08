using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.LettersCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            var startLetter = char.Parse(Console.ReadLine());
            var endLetter = char.Parse(Console.ReadLine());
            var skipLetter = char.Parse(Console.ReadLine());
            var combosCount = 0;
           
            for (char i = startLetter; i <= endLetter; i++)
            {
                for (char j = startLetter; j <= endLetter; j++)
                {
                    for (char k = startLetter; k <= endLetter; k++)
                    {
                        bool skipping = i == skipLetter || j == skipLetter || k == skipLetter;

                        if (skipping)
                        {
                            continue;
                        }

                        Console.Write("{0}{1}{2} ", i, j, k);
                        combosCount++;
                    }
                }
            }
            Console.Write(combosCount);
        }
    }
}
