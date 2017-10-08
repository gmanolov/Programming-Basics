using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.HotelRoomEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            var studioMayOct = 50.0;
            var apartMayOct = 65.0;
            var studioJunSept = 75.2;
            var apartJunSept = 68.7;
            var studioJulAug = 76.0;
            var apartJulAug = 77.0;
            var priceStudio = 0.0;
            var priceApart = 0.0;

            if (month.ToLower() == "may" || month.ToLower() == "october")
            {
                if (nights > 14)
                {
                    priceStudio = nights * studioMayOct * 0.7;
                    priceApart = nights * apartMayOct * 0.9;
                }
                else if (nights > 7)
                {
                    priceStudio = nights * studioMayOct * 0.95;
                    priceApart = nights * apartMayOct;
                }
                else
                {
                    priceStudio = nights * studioMayOct;
                    priceApart = nights * apartMayOct;
                }
            }
            else if (month.ToLower() == "june" || month.ToLower() == "september")
            {
                if (nights > 14)
                {
                    priceStudio = nights * studioJunSept * 0.8;
                    priceApart = nights * apartJunSept * 0.9;
                }
                else
                {
                    priceStudio = nights * studioJunSept;
                    priceApart = nights * apartJunSept;
                }
            }
            else
            {
                if (nights > 14)
                {
                    priceStudio = nights * studioJulAug;
                    priceApart = nights * apartJulAug * 0.9;
                }
                else
                {
                    priceStudio = nights * studioJulAug;
                    priceApart = nights * apartJulAug;
                }
            }
            Console.WriteLine("Apartment: {0:f2} lv.", priceApart);
            Console.WriteLine("Studio: {0:f2} lv.", priceStudio);
        }
    }
}
