using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var unit = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();

            double midMeter = 0;
            double finalUnit = 0;

            if (from == "mm") midMeter = unit / 1000;
            else if (from == "cm") midMeter = unit / 100;
            else if (from == "mi") midMeter = unit / 0.000621371192;
            else if (from == "in") midMeter = unit / 39.3700787;
            else if (from == "km") midMeter = unit / 0.001;
            else if (from == "ft") midMeter = unit / 3.2808399;
            else if (from == "yd") midMeter = unit / 1.0936133;
            else if (from == "m") midMeter = unit;

            if (to == "mm") finalUnit = midMeter * 1000;
            else if (to == "cm") finalUnit = midMeter * 100;
            else if (to == "mi") finalUnit = midMeter * 0.000621371192;
            else if (to == "in") finalUnit = midMeter * 39.3700787;
            else if (to == "km") finalUnit = midMeter * 0.001;
            else if (to == "ft") finalUnit = midMeter * 3.2808399;
            else if (to == "yd") finalUnit = midMeter * 1.0936133;
            else if (to == "m") finalUnit = midMeter;

            Console.WriteLine($"{finalUnit} {to}");

        }
    }
}
