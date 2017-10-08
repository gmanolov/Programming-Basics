using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = double.Parse(Console.ReadLine());

            var topStudents = 0;
            var fourFive = 0;
            var threeFour = 0;
            var failed = 0;
            var sum = 0.0;

            for (int i = 1; i <= students; i++)
            {
                var grade = double.Parse(Console.ReadLine());

                if (grade >= 5)
                {
                    topStudents++;
                }
                else if (grade < 5 && grade >= 4)
                {
                    fourFive++;
                }
                else if (grade < 4 && grade >= 3)
                {
                    threeFour++;
                }
                else
                {
                    failed++;
                }

                sum += grade;
            }

            var averageGrade = sum / students;
            var pTop = topStudents / students * 100;
            var pFourFive = fourFive / students * 100;
            var pThreeFour = threeFour / students * 100;
            var pFailed = failed / students * 100;

            Console.WriteLine("Top students: {0:f2}%", pTop);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", pFourFive);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", pThreeFour);
            Console.WriteLine("Fail: {0:f2}%", pFailed);
            Console.WriteLine("Average: {0:f2}", averageGrade);
        }
    }
}
