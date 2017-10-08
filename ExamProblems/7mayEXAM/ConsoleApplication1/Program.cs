using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NumberGenerator
{
    class NumberGenerator
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine()); // прочитаме числото M
            int n = int.Parse(Console.ReadLine()); // прочитаме числото N
            int l = int.Parse(Console.ReadLine()); // прочитаме числото L
            int specialNumber = int.Parse(Console.ReadLine()); // прочитаме специалното число
            int controlNumber = int.Parse(Console.ReadLine()); // прочитаме контролното число

            for (int i = m; i >= 1; i--)
            {
                for (int j = n; j >= 1; j--)
                {
                    for (int k = l; k >= 1; k--) // чрез тези 3 цикъла намираме всички комбинации от MNL до 111
                    {                            // започваме с проверките по условие
                        if ((i + j + k) % 3 == 0) // ако числото се дели на 3 без остатък,добави 5 към specialNumber
                        {
                            specialNumber += 5;
                        }               // ако горната проверка върне false,
                        else if (k == 5) // провери числото дали завършва на 5 и ако да - извади 2 от specialNumber
                        {
                            specialNumber -= 2;
                        }                   // ако горната проверка върне false,
                        else if (k % 2 == 0) // провери дали числото е четно,сиреч дали се дели на 2 без остатък
                        {                    // и ако да - умножи specialNumber по 2
                            specialNumber *= 2;
                        }

                        if (specialNumber >= controlNumber) // ако specialNumber е по-голямо или равно на controlNumber
                        {                                   // изпълни този код Console.WriteLine.....
                            Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNumber}.");
                            return; // и спри програмата
                        }
                    }
                }
            }
            Console.WriteLine($"No! {specialNumber} is the last reached special number.");
        }   // този код ще се изпълни, само когато тази проверка if (specialNumber >= controlNumber) върне false
    }
}