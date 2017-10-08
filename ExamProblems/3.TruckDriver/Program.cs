using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            var kilometersMonth = double.Parse(Console.ReadLine());

            if (kilometersMonth <= 5000)
            {
                if (season.ToLower() == "spring" || season.ToLower() == "autumn")
                {
                    Console.WriteLine("{0:f2}", kilometersMonth * 0.75 * 4 * 0.9);
                }
                else if (season.ToLower() == "summer")
                {
                    Console.WriteLine("{0:f2}", kilometersMonth * 0.9 * 4 * 0.9);

                }
                else if (season.ToLower() == "winter")
                {
                    Console.WriteLine("{0:f2}", kilometersMonth * 1.05 * 4 * 0.9);
                }
            }
            else if (kilometersMonth > 5000 && kilometersMonth <= 10000)
            {
                if (season.ToLower() == "spring" || season.ToLower() == "autumn")
                {
                    Console.WriteLine("{0:f2}", kilometersMonth * 0.95 * 4 * 0.9);
                }
                else if (season.ToLower() == "summer")
                {
                    Console.WriteLine("{0:f2}", kilometersMonth * 1.1 * 4 * 0.9);
                }
                else if (season.ToLower() == "winter")
                {
                    Console.WriteLine("{0:f2}", kilometersMonth * 1.25 * 4 * 0.9);
                }
            }
            else if (kilometersMonth > 10000 && kilometersMonth <= 20000)
            {
                Console.WriteLine("{0:f2}", kilometersMonth * 1.45 * 4 * 0.9);
            }
        }
    }
}
