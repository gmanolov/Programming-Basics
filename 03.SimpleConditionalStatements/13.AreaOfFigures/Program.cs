using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();

            if (figure == "square")
            {
                var side = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(side * side, 3));
            }
            else if (figure == "rectangle")
            {
                var length = double.Parse(Console.ReadLine());
                var width = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(length * width, 3));
            }
            else if (figure == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(Math.PI * radius * radius, 3));
            }
            else if (figure == "triangle")
            {
                var length = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((length * height) / 2, 3));
            }
        }
    }
}
