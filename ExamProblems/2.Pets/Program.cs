using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var foodKg = int.Parse(Console.ReadLine());
            var dogFoodKg = double.Parse(Console.ReadLine());
            var catFoodKg = double.Parse(Console.ReadLine());
            var turtleFoodGrams = double.Parse(Console.ReadLine());

            var totalFoodNeeded =(days * dogFoodKg) + (days * catFoodKg) + turtleFoodGrams / 1000 * days;

            if (foodKg >= totalFoodNeeded)
            {
                var foodLeft = foodKg - totalFoodNeeded;
                Console.WriteLine("{0} kilos of food left.", Math.Floor(foodLeft));
            }
            else
            {
                var foodNeeded = totalFoodNeeded - foodKg;
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(foodNeeded));
            }
        }
    }
}
