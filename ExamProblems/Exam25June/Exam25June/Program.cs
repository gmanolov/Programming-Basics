using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam25June
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int gofrettes = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakePrice = 45.0;
            double gofrettePrice = 5.8;
            double pancakePrice = 3.2;

            double sumOfCakes = (cakes * cakePrice) + (gofrettes * gofrettePrice) + (pancakes * pancakePrice);
            double sumPerDay = sumOfCakes * bakers;
            double totalSum = sumPerDay * days;
            double afterTax = totalSum - (totalSum/8.0);
            Console.WriteLine("{0:f2}", afterTax);

        }
    }
}
