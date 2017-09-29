using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());

            double toDegrees = 180 / Math.PI * radians;
            Console.WriteLine(Math.Round(toDegrees));
        }
    }
}
