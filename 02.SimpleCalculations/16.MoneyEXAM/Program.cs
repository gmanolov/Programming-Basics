using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.MoneyEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoin = int.Parse(Console.ReadLine());
            var yuan = double.Parse(Console.ReadLine());
            var commission = double.Parse(Console.ReadLine());

            var bitcoinRate = 1168;
            var dollarRate = 1.76;
            var euroRate = 1.95;

            var euro = ((bitcoin * bitcoinRate) + (yuan * 0.15 * dollarRate)) / euroRate;
            var tax = (commission / 100) * (euro);
            var money = euro - tax;
            Console.WriteLine(money);
        }
    }
}
