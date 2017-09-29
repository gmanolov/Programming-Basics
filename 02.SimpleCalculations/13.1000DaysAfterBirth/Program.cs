using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            string birthDate = Console.ReadLine();
            string format = "dd-MM-yyyy";

            DateTime afterDays = DateTime.ParseExact(birthDate, format, null);
            Console.WriteLine(afterDays.AddDays(999).ToString(format));
        }
    }
}
