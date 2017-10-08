using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.NumberOperationsEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOne = double.Parse(Console.ReadLine());
            var numTwo = double.Parse(Console.ReadLine());
            var mathOperator = char.Parse(Console.ReadLine());

            var result = 0.0;

            if (mathOperator == '+')
            {
                result = numOne + numTwo;
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", numOne, mathOperator, numTwo, result);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", numOne, mathOperator, numTwo, result);
                }
            }
            else if (mathOperator == '-')
            {
                result = numOne - numTwo;
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", numOne, mathOperator, numTwo, result);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", numOne, mathOperator, numTwo, result);
                }
            }
            else if (mathOperator == '*')
            {
                result = numOne * numTwo;
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", numOne, mathOperator, numTwo, result);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", numOne, mathOperator, numTwo, result);
                }
            }
            else if (mathOperator == '/')
            {
                if (numTwo == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", numOne);
                }
                else
                {
                    result = numOne / numTwo;
                    Console.WriteLine("{0} / {1} = {2:f2}", numOne, numTwo, result);
                }
            }
            else
            {
                if (numTwo == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", numOne);
                }
                else
                {
                    result = numOne % numTwo;
                    Console.WriteLine("{0} % {1} = {2}", numOne, numTwo, result);
                }
            }
        }
    }
}
