using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.StopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int nStart = int.Parse(Console.ReadLine());
            int mEnd = int.Parse(Console.ReadLine());
            int stopNumber = int.Parse(Console.ReadLine());
            
            for (int num = mEnd; num >= nStart; num--)
            {
                bool noRemainder = num % 2 == 0 && num % 3 == 0;

                if (noRemainder)
                {
                    if (num == stopNumber && noRemainder)
                    {
                        break;
                    }

                    Console.Write("{0} ", num);
                }
            }
        }
    }
}
