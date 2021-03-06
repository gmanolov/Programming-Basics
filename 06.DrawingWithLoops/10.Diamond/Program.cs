﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int middleDashes = 0;

            if (n == 1)
            {
                Console.WriteLine("*");
                return;
            }

            if (n % 2 == 1)
            {
                Console.WriteLine(new string('-', n / 2) + "*" + new string('-', n / 2));
                middleDashes++;
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('-', n / 2 - 1 - i));
                Console.Write("*");
                Console.Write(new string('-', 2 * i + middleDashes));
                Console.Write("*");
                Console.WriteLine(new string('-', n / 2 - 1 - i));
            }

            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.Write(new string('-', i + 1));
                Console.Write("*");
                Console.Write(new string('-', n - 4 - 2 * i));
                Console.Write("*");
                Console.WriteLine(new string('-', i + 1));
            }

            if (n % 2 == 1)
            {
                Console.WriteLine(new string('-', n / 2) + "*" + new string('-', n / 2));
            }
        }
    }
}
