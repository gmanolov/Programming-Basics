using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SchoolCamp
{
    class SchoolCampMain
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int numberOfStudents = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            string sport = "";
            double hotelSum = 1;

            if (season.ToLower() == "winter")
            {
                if (groupType == "girls")
                {
                    sport = "Gymnastics";
                    hotelSum = numberOfStudents * nights * 9.6;

                }
                else if (groupType == "boys")
                {
                    sport = "Judo";
                    hotelSum = numberOfStudents * nights * 9.6;
                }
                else if (groupType == "mixed")
                {
                    sport = "Ski";
                    hotelSum = numberOfStudents * nights * 10.0;
                }
            }
            else if (season.ToLower() == "spring")
            {
                if (groupType == "girls")
                {
                    sport = "Athletics";
                    hotelSum = numberOfStudents * nights * 7.2;
                }
                else if (groupType == "boys")
                {
                    sport = "Tennis";
                    hotelSum = numberOfStudents * nights * 7.2;
                }
                else if (groupType == "mixed")
                {
                    sport = "Cycling";
                    hotelSum = numberOfStudents * nights * 9.5;
                }
            }
            else if (season.ToLower() == "summer")
            {
                if (groupType == "girls")
                {
                    sport = "Volleyball";
                    hotelSum = numberOfStudents * nights * 15.0;
                }
                else if (groupType == "boys")
                {
                    sport = "Football";
                    hotelSum = numberOfStudents * nights * 15.0;
                }
                else if (groupType == "mixed")
                {
                    sport = "Swimming";
                    hotelSum = numberOfStudents * nights * 20.0;
                }               
            }

            if (numberOfStudents >= 50)
            {
                hotelSum *= 0.5;
            }
            else if (numberOfStudents >= 20 && numberOfStudents < 50)
            {
                hotelSum *= 0.85;
            }
            else if (numberOfStudents >= 10 && numberOfStudents < 20)
            {
                hotelSum *= 0.95;
            }

            Console.WriteLine("{0} {1:f2} lv.", sport, hotelSum);
        }
    }
}
