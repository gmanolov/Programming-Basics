using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.AdditionOrMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlNumber = int.Parse(Console.ReadLine());

            bool isFound = false;


            for (int firstNumber = 1; firstNumber <= 30; firstNumber++)
            {
                for (int secondNumber = 1; secondNumber <= 30; secondNumber++)
                {
                    for (int thirdNumber = 1; thirdNumber <= 30; thirdNumber++)
                    {
                        bool addition = (firstNumber + secondNumber + thirdNumber == controlNumber) && (firstNumber < secondNumber && secondNumber < thirdNumber);
                        bool multiplication = (firstNumber * secondNumber * thirdNumber == controlNumber) && (firstNumber > secondNumber && secondNumber > thirdNumber);

                        if (addition)
                        {
                            Console.WriteLine("{0} + {1} + {2} = {3}", firstNumber, secondNumber, thirdNumber, controlNumber);
                            isFound = true;
                        }

                        if (multiplication)
                        {
                            Console.WriteLine("{0} * {1} * {2} = {3}", firstNumber, secondNumber, thirdNumber, controlNumber);
                            isFound = true;
                        }
                        
                    }
                }
            }

            if (!isFound)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
