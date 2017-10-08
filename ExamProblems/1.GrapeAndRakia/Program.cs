using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.GrapeAndRakia
{
    class Program
    {
        static void Main(string[] args)
        {
            var vineArea = double.Parse(Console.ReadLine());
            var kgGrapePerM = double.Parse(Console.ReadLine());
            var waste = double.Parse(Console.ReadLine());

            var totalGrape = vineArea * kgGrapePerM - waste;
            var rakiaIncome = totalGrape * 0.45 / 7.5 * 9.8;
            var grapeIncome = totalGrape * 0.55 * 1.5;
            Console.WriteLine("{0:f2}\n{1:f2}", rakiaIncome, grapeIncome);
        }
    }
}
