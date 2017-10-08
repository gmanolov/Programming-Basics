using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.CompanyEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoursRequired = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var employeesOvertime = int.Parse(Console.ReadLine());

            var training = 0.1 * days;
            var regularWork = (days - training) * 8;
            var overtime = employeesOvertime * 2 * days;
            var workingHours = regularWork + overtime;

            if (hoursRequired > workingHours)
            {
                var moreTime = hoursRequired - workingHours;
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Ceiling(moreTime));
            }
            else
            {
                var hoursLeft = workingHours - hoursRequired;
                Console.WriteLine("Yes!{0} hours left.", Math.Floor(hoursLeft));
            }
        }
    }
}
