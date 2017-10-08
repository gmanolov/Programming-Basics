using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double price = 0.0;

            if (projectionType.ToLower() == "premiere")
            {
                price = 12.0;
            }
            else if (projectionType.ToLower() == "normal")
            {
                price = 7.5;
            }
            else if (projectionType.ToLower() == "discount")
            {
                price = 5.0;
            }

            double finalPrice = rows * columns * price;

            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
