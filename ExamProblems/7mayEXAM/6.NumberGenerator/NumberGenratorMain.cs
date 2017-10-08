using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.NumberGenerator
{
    class NumberGenratorMain
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int specialNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());

            for (int i = m; i >= 1; i--)
            {
                for (int k = n; k >= 1; k--)
                {
                    for (int p = l; p >= 1; p--)
                    {
                        int startNumber = i * 100 + k * 10 + p;

                        if (startNumber % 3 == 0)
                        {
                            specialNumber += 5;
                        }
                        else if (startNumber % 10 == 5)
                        {
                            specialNumber -= 2;
                        }
                        else if (startNumber % 2 == 0)
                        {
                            specialNumber *= 2;
                        }

                        if (specialNumber >= controlNumber)
                        {
                            Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", specialNumber);
                            return;
                        }
                    }
                }
            }

            Console.WriteLine("No! {0} is the last reached special number.", specialNumber);
        }
    }
}
