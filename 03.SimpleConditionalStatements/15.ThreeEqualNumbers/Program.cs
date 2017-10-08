using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ThreeEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = double.Parse(Console.ReadLine());
            var secondNum = double.Parse(Console.ReadLine());
            var thirdNum = double.Parse(Console.ReadLine());

            if (firstNum == secondNum && secondNum == thirdNum && thirdNum == firstNum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
