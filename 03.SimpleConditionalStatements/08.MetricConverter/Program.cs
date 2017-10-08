using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = double.Parse(Console.ReadLine());
            var fromMetric = Console.ReadLine();
            var toMetric = Console.ReadLine();
            var result = 0.0;

            if (fromMetric == "km")
            {
                if (toMetric == "m")
                {
                    result = size * 1000;
                }
                else if (toMetric == "cm")
                {
                    result = size * 100000;
                }
                else if (toMetric == "mm")
                {
                    result = size * 1000000;
                }
                else if (toMetric == "mi")
                {
                    result = size / 0.001 * 0.000621371192;
                }
                else if (toMetric == "in")
                {
                    result = size / 0.001 * 39.3700787;
                }
                else if (toMetric == "km")
                {
                    result = size;
                }
                else if (toMetric == "ft")
                {
                    result = size / 0.001 * 3.2808399;
                }
                else if (toMetric == "yd")
                {
                    result = size / 0.001 * 1.0936133;
                }
            }
            if (fromMetric == "cm")
            {
                if (toMetric == "m")
                {
                    result = size / 100;
                }
                else if (toMetric == "cm")
                {
                    result = size;
                }
                else if (toMetric == "mm")
                {
                    result = size * 10;
                }
                else if (toMetric == "mi")
                {
                    result = size / 100 * 0.000621371192;
                }
                else if (toMetric == "in")
                {
                    result = size / 100 * 39.3700787;
                }
                else if (toMetric == "km")
                {
                    result = size / 100 * 0.001;
                }
                else if (toMetric == "ft")
                {
                    result = size / 100 * 3.2808399;
                }
                else if (toMetric == "yd")
                {
                    result = size / 100 * 1.0936133;
                }
            }
            if (fromMetric == "m")
            {
                if (toMetric == "m")
                {
                    result = size;
                }
                else if (toMetric == "cm")
                {
                    result = size * 100;
                }
                else if (toMetric == "mm")
                {
                    result = size * 1000;
                }
                else if (toMetric == "mi")
                {
                    result = size * 0.000621371192;
                }
                else if (toMetric == "in")
                {
                    result = size * 39.3700787;
                }
                else if (toMetric == "km")
                {
                    result = size * 0.001;
                }
                else if (toMetric == "ft")
                {
                    result = size * 3.2808399;
                }
                else if (toMetric == "yd")
                {
                    result = size * 1.0936133;
                }
            }
            if (fromMetric == "mm")
            {
                if (toMetric == "m")
                {
                    result = size / 1000;
                }
                else if (toMetric == "cm")
                {
                    result = size / 10;
                }
                else if (toMetric == "mm")
                {
                    result = size;
                }
                else if (toMetric == "mi")
                {
                    result = size / 1000 * 0.000621371192;
                }
                else if (toMetric == "in")
                {
                    result = size / 1000 * 39.3700787;
                }
                else if (toMetric == "km")
                {
                    result = size / 1000 * 0.001;
                }
                else if (toMetric == "ft")
                {
                    result = size / 1000 * 3.2808399;
                }
                else if (toMetric == "yd")
                {
                    result = size / 1000 * 1.0936133;
                }
            }
            if (fromMetric == "ft")
            {
                if (toMetric == "m")
                {
                    result = size / 3.2808399;
                }
                else if (toMetric == "cm")
                {
                    result = size / 3.2808399 * 100;
                }
                else if (toMetric == "mm")
                {
                    result = size / 3.2808399 * 1000;
                }
                else if (toMetric == "mi")
                {
                    result = size / 3.2808399 * 0.000621371192;
                }
                else if (toMetric == "in")
                {
                    result = size / 3.2808399 * 39.3700787;
                }
                else if (toMetric == "km")
                {
                    result = size / 3.2808399 * 0.001;
                }
                else if (toMetric == "ft")
                {
                    result = size;
                }
                else if (toMetric == "yd")
                {
                    result = size / 3.2808399 * 1.0936133;
                }
            }
            if (fromMetric == "in")
            {
                if (toMetric == "m")
                {
                    result = size / 39.3700787;
                }
                else if (toMetric == "cm")
                {
                    result = size / 39.3700787 * 100;
                }
                else if (toMetric == "mm")
                {
                    result = size / 39.3700787 * 1000;
                }
                else if (toMetric == "mi")
                {
                    result = size / 39.3700787 * 0.000621371192;
                }
                else if (toMetric == "in")
                {
                    result = size;
                }
                else if (toMetric == "km")
                {
                    result = size / 39.3700787 * 0.001;
                }
                else if (toMetric == "ft")
                {
                    result = size / 39.3700787 * 3.2808399;
                }
                else if (toMetric == "yd")
                {
                    result = size / 39.3700787 * 1.0936133;
                }
            }
            if (fromMetric == "mi")
            {
                if (toMetric == "m")
                {
                    result = size / 0.000621371192;
                }
                else if (toMetric == "cm")
                {
                    result = size / 0.000621371192 * 100;
                }
                else if (toMetric == "mm")
                {
                    result = size / 0.000621371192 * 1000;
                }
                else if (toMetric == "mi")
                {
                    result = size;
                }
                else if (toMetric == "in")
                {
                    result = size / 0.000621371192 * 39.3700787;
                }
                else if (toMetric == "km")
                {
                    result = size / 0.000621371192 * 0.001;
                }
                else if (toMetric == "ft")
                {
                    result = size / 0.000621371192 * 3.2808399;
                }
                else if (toMetric == "yd")
                {
                    result = size / 0.000621371192 * 1.0936133;
                }
            }
            if (fromMetric == "yd")
            {
                if (toMetric == "m")
                {
                    result = size / 1.0936133;
                }
                else if (toMetric == "cm")
                {
                    result = size / 1.0936133 * 100;
                }
                else if (toMetric == "mm")
                {
                    result = size / 1.0936133 * 1000;
                }
                else if (toMetric == "mi")
                {
                    result = size / 1.0936133 * 0.000621371192;
                }
                else if (toMetric == "in")
                {
                    result = size / 1.0936133 * 39.3700787;
                }
                else if (toMetric == "km")
                {
                    result = size / 1.0936133 * 0.001;
                }
                else if (toMetric == "ft")
                {
                    result = size / 1.0936133 * 3.2808399;
                }
                else if (toMetric == "yd")
                {
                    result = size;
                }
            }

            Console.WriteLine(result + " " + toMetric);
        }
    }
}
