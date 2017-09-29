using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());

            double toFahrenheit = celsius * 1.8 + 32;
            Console.WriteLine(Math.Round(toFahrenheit, 2));
        }
    }
}
