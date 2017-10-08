using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.WorkHours
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoursRequired = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var workDays = int.Parse(Console.ReadLine());

            var hoursWork = workers * workDays * 8;

            if (hoursRequired < hoursWork)
            {
                Console.WriteLine("{0} hours left", hoursWork - hoursRequired);
            }
            else
            {
                Console.WriteLine("{0} overtime\nPenalties: {1}", hoursRequired - hoursWork, workDays * (hoursRequired - hoursWork));
            }
        }
    }
}
