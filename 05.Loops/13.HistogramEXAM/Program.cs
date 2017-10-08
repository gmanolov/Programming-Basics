using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.HistogramEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = int.Parse(Console.ReadLine());
            var lessThan200 = 0.0;
            var lessThan400 = 0.0;
            var lessThan600 = 0.0;
            var lessThan800 = 0.0;
            var moreThan800 = 0.0;

            for (int i = 0; i < elements; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    lessThan200++;
                }
                else if (number > 199 && number < 400)
                {
                    lessThan400++;
                }
                else if (number > 399 && number < 600)
                {
                    lessThan600++;
                }
                else if (number > 599 && number < 800)
                {
                    lessThan800++;
                }
                else
                {
                    moreThan800++;
                }
            }

            var p1 = lessThan200 / elements * 100;
            var p2 = lessThan400 / elements * 100;
            var p3 = lessThan600 / elements * 100;
            var p4 = lessThan800 / elements * 100;
            var p5 = moreThan800 / elements * 100;

            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
            Console.WriteLine("{0:f2}%", p4);
            Console.WriteLine("{0:f2}%", p5);
        }
    }
}
