using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.NoRemainderDivisionEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = int.Parse(Console.ReadLine());
            var divBy2 = 0.0;
            var divBy3 = 0.0;
            var divBy4 = 0.0;

            for (int i = 0; i < elements; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    divBy2++;
                }
                if (number % 3 == 0)
                {
                    divBy3++;
                }
                if (number % 4 == 0)
                {
                    divBy4++;
                }
            }

            var p1 = divBy2 / elements * 100;
            var p2 = divBy3 / elements * 100;
            var p3 = divBy4 / elements * 100;

            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
        }
    }
}
