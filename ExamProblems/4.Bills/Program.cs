using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            var months = int.Parse(Console.ReadLine());

            var waterPerMonth = 20;
            var internetPerMonth = 15;
            var sumElectricty = 0.0;
            var misc = 0.0;

            for (int i = 1; i <= months; i++)
            {
                var electricityPerMonth = double.Parse(Console.ReadLine());

                misc += (electricityPerMonth + waterPerMonth + internetPerMonth) * 1.2;
                sumElectricty += electricityPerMonth;
            }

            var average = (sumElectricty + (waterPerMonth * months) + (internetPerMonth * months) + misc) / months;

            Console.WriteLine("Electricity: {0:f2} lv", sumElectricty);
            Console.WriteLine("Water: {0:f2} lv", waterPerMonth * months);
            Console.WriteLine("Internet: {0:f2} lv", internetPerMonth * months);
            Console.WriteLine("Other: {0:f2} lv", misc);
            Console.WriteLine("Average: {0:f2} lv", average);
            
        }
    }
}
