using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.OnTimeForExamEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            var examHour = int.Parse(Console.ReadLine());
            var examMinutes = int.Parse(Console.ReadLine());
            var arrivalHour = int.Parse(Console.ReadLine());
            var arrivalMinutes = int.Parse(Console.ReadLine());

            var examTime = examHour * 60 + examMinutes;
            var arrivalTime = arrivalHour * 60 + arrivalMinutes;
            var earlyDifference = examTime - arrivalTime;
            var lateDifference = arrivalTime - examTime;

            if (earlyDifference > 30 && earlyDifference < 60)
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0} minutes before the start", earlyDifference);
            }
            else if (earlyDifference >= 60)
            {
                var hhEarly = earlyDifference / 60;
                var mmEarly = earlyDifference % 60;
                Console.WriteLine("Early");
                Console.WriteLine("{0}:{1:00} hours before the start", hhEarly, mmEarly);
            }
            else if (examTime >= arrivalTime && earlyDifference <= 30)
            {
                if (examTime == arrivalTime)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("On time");
                    Console.WriteLine("{0} minutes before the start", earlyDifference);
                }
            }
            else
            {
                Console.WriteLine("Late");
                if (lateDifference >= 60)
                {
                    var hhLate = lateDifference / 60;
                    var mmLate = lateDifference % 60;
                    Console.WriteLine("{0}:{1:00} hours after the start", hhLate, mmLate);
                }
                else
                {
                    Console.WriteLine("{0} minutes after the start", lateDifference);
                }
            }
        }
    }
}
