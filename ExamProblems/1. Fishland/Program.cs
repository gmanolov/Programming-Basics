using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            var skumriaPrice = double.Parse(Console.ReadLine());
            var cacaPrice = double.Parse(Console.ReadLine());
            var palamudKg = double.Parse(Console.ReadLine());
            var safridKg = double.Parse(Console.ReadLine());
            var midiKg = double.Parse(Console.ReadLine());

            var palamudPrice = (skumriaPrice * 1.6) * palamudKg;
            var safridPrice = (cacaPrice * 1.8) * safridKg;
            var midiPrice = midiKg * 7.5;
            var sum = palamudPrice + safridPrice + midiPrice;
            Console.WriteLine("{0:f2}", sum);
        }
    }
}
