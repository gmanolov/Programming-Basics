using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var doctors = 7;
            var treateadPatients = 0;
            var untreatedPatients = 0;

            for (int i = 1; i <= days; i++)
            {
                var patients = int.Parse(Console.ReadLine());

                if (i % 3 == 0 && untreatedPatients > treateadPatients)
                {
                    doctors++;
                }

                if (patients <= doctors)
                {
                    treateadPatients += patients;  
                }
                else
                {
                    treateadPatients += doctors;
                    untreatedPatients += (patients - doctors);
                }
            }
            Console.WriteLine("Treated patients: {0}.", treateadPatients);
            Console.WriteLine("Untreated patients: {0}.", untreatedPatients);
        }
    }
}
