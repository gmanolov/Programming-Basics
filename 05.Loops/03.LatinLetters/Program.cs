﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 'a'; i <= 'z'; i++)
            {
                Console.WriteLine(Convert.ToChar(i));
            }
        }
    }
}
