using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var turns = int.Parse(Console.ReadLine());

            var result = 0.0;
            var nilToNine = 0.0;
            var tenToTwenty = 0.0;
            var twentyToThirty = 0.0;
            var thirtyToForty = 0.0;
            var fortyToFifty = 0.0;
            var invalid = 0.0;

            for (int i = 1; i <= turns; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number >= 0 && number < 10)
                {
                    result += number * 0.2;
                    nilToNine++;
                }
                else if (number >= 10 && number < 20)
                {
                    result += number * 0.3;
                    tenToTwenty++;
                }
                else if (number >= 20 && number < 30)
                {
                    result += number * 0.4;
                    twentyToThirty++;
                }
                else if (number >= 30 && number < 40)
                {
                    result += 50;
                    thirtyToForty++;
                }
                else if (number >= 40 && number <= 50)
                {
                    result += 100;
                    fortyToFifty++;
                }
                else if (number < 0 || number > 50)
                {
                    result /= 2;
                    invalid++;
                }
            }

            var pnilToNine = nilToNine / turns * 100;
            var ptenToTwenty = tenToTwenty / turns * 100;
            var ptwentyToThirty = twentyToThirty / turns * 100;
            var pthirtyToForty = thirtyToForty / turns * 100;
            var pFortyToFifty = fortyToFifty / turns * 100;
            var pInvalid = invalid / turns * 100;

            Console.WriteLine("{0:f2}", result);
            Console.WriteLine("From 0 to 9: {0:f2}%", pnilToNine);
            Console.WriteLine("From 10 to 19: {0:f2}%", ptenToTwenty);
            Console.WriteLine("From 20 to 29: {0:f2}%", ptwentyToThirty);
            Console.WriteLine("From 30 to 39: {0:f2}%", pthirtyToForty);
            Console.WriteLine("From 40 to 50: {0:f2}%", pFortyToFifty);
            Console.WriteLine("Invalid numbers: {0:f2}%", pInvalid);
        }
    }
}
