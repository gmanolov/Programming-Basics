using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double comission = 0.0;

            if (town.ToLower() == "sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = 0.05;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = 0.08;
                }
                else if (sales > 10000)
                {
                    comission = 0.12;
                }
            }
            else if (town.ToLower() == "varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = 0.1;
                }
                else if (sales > 10000)
                {
                    comission = 0.13;
                }
            }
            else if (town.ToLower() == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = 0.12;
                }
                else if (sales > 10000)
                {
                    comission = 0.145;
                }
            }

            double result = sales * comission;

            if (comission == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{result:f2}");
            }
        }
    }
}
