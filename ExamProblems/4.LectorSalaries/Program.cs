using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.LectorSalaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var lectures = int.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());

            var jelev = 0;
            var royal = 0;
            var roli = 0;
            var trofon = 0;
            var sino = 0;
            var other = 0;
            var perLecture = budget / lectures;

            for (int i = 1; i <= lectures; i++)
            {
                var nameLector = Console.ReadLine();

                if (nameLector == "Jelev")
                {
                    jelev++;
                }
                else if (nameLector == "RoYaL")
                {
                    royal++;
                }
                else if (nameLector == "Roli")
                {
                    roli++;
                }
                else if (nameLector == "Trofon")
                {
                    trofon++;
                }
                else if (nameLector == "Sino")
                {
                    sino++;
                }
                else
                {
                    other++;
                }
            }

            Console.WriteLine("Jelev salary: {0:f2} lv", jelev * perLecture);
            Console.WriteLine("RoYaL salary: {0:f2} lv", royal * perLecture);
            Console.WriteLine("Roli salary: {0:f2} lv", roli * perLecture);
            Console.WriteLine("Trofon salary: {0:f2} lv", trofon * perLecture);
            Console.WriteLine("Sino salary: {0:f2} lv", sino * perLecture);
            Console.WriteLine("Others salary: {0:f2} lv", other * perLecture);
        }
    }
}
