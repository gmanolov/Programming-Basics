using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPokemon = int.Parse(Console.ReadLine());
            var secondPokemon = int.Parse(Console.ReadLine());
            var maxBattles = int.Parse(Console.ReadLine());
            var battles = 0;

            for (int i = 1; i <= firstPokemon; i++)
            {
                for (int j = 1; j <= secondPokemon; j++)
                {
                    if (maxBattles == battles)
                    {
                        break;
                    }
                    Console.Write("({0} <-> {1}) ", i, j);
                    battles++;
                }
            }
        }
    }
}
