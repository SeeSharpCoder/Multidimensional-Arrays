using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.School_Camp_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var groupType = Console.ReadLine();
            var groupSize = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());

                                         //[0]Winter         [1]Spring       [2]Summer
            var sports = new string[,] {{ "Gymnastics",     "Athletics",    "Volleyball"}, // [0]girls
                                        { "Judo",           "Tennis",       "Football"  }, // [1]boys
                                        { "Ski",            "Cycling",      "Swimming"  }};// [2]mixed

            var prices = new double[,] {{ 9.60,  7.20,  15 }, // [0]girls
                                        { 9.60,  7.20,  15 }, // [1]boys
                                        { 10.0,  9.50,  20 }};// [2]mixed

            var row = 0;
            if (groupType == "boys") row = 1;
            else if (groupType == "mixed") row = 2;

            var column = 0;
            if (season == "Spring") column = 1;
            else if (season == "Summer") column = 2;

            double discount = 1;
            if (groupSize >= 50) discount = 0.5;
            else if (groupSize >= 20) discount = 0.85;
            else if (groupSize >= 10) discount = 0.95;

            var totalPrice = groupSize * prices[row, column] * nights * discount;

            Console.WriteLine("{0} {1:f2} lv.", sports[row, column], totalPrice);
        }
    }
}
