using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var plusMinutes = minutes + 15;

            if (plusMinutes > 59)
            {
                hour = (hour + 1) % 24;
                plusMinutes = plusMinutes - 60;
            }

            Console.WriteLine("{0}:{1:00}", hour, plusMinutes);
        }
    }
}
