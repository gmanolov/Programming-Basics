using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.TrainingLabEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            var height = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());

            var deskHeight = 120;
            var deskWidth = 70;
            var corridor = 100;

            var rows = (height * 100) / deskHeight;
            var desksInRow = ((width * 100) - corridor) / deskWidth;

            var desks = Math.Floor(rows) * Math.Floor(desksInRow) - 3;
            Console.WriteLine(desks);
        }
    }
}
