using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int zeroFib = 1;
            int firstFib = 1;
            int nextFib = 1;

            for (int i = 1; i < n; i++)
            {
                nextFib = zeroFib + firstFib;
                zeroFib = firstFib;
                firstFib = nextFib;
            }

            Console.WriteLine(nextFib);
        }
    }
}
