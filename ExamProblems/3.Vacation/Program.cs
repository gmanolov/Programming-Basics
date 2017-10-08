using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var elders = int.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();

            var sum = 0.0;

            if (transport == "train")
            {
                sum = 2 * (elders * 24.99 + students * 14.99);
                if (elders + students >= 50)
                {
                    sum = sum * 0.5;
                }
                
            }
            else if (transport == "bus")
            {
                sum = 2 * (elders * 32.5 + students * 28.5);
            }
            else if (transport == "boat")
            {
                sum = 2 * (elders * 42.99 + students * 39.99);
            }
            else if (transport == "airplane")
            {
                sum = 2 * (elders * 70.0 + students * 50);
            }

            var totalSum = (sum + nights * 82.99) * 1.1;
            Console.WriteLine("{0:f2}", totalSum);
        
        }
    }
}
