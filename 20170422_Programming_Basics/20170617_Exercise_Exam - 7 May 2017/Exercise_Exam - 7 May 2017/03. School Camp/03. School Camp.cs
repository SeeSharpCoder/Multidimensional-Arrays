using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var groupType = Console.ReadLine();
            var studentsCount = double.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());

            var nightPrice = 0.0;
            string sport = String.Empty;

            switch (season)
            {
                case "Winter":
                    {
                        switch (groupType)
                        {
                            case "boys":    nightPrice = 9.6;   sport = "Judo"; break;
                            case "girls":    nightPrice = 9.6; sport = "Gymnastics"; break;
                            case "mixed":    nightPrice = 10.0; sport = "Ski"; break;
                        }
                        break;
                    }
                case "Spring":
                    {
                        switch (groupType)
                        {
                            case "boys": nightPrice = 7.2; sport = "Tennis"; break;
                            case "girls": nightPrice = 7.2; sport = "Athletics"; break;
                            case "mixed": nightPrice = 9.5; sport = "Cycling"; break;
                        }
                        break;
                    }
                case "Summer":
                    {
                        switch (groupType)
                        {
                            case "boys": nightPrice = 15.0; sport = "Football"; break;
                            case "girls": nightPrice = 15.0; sport = "Volleyball"; break;
                            case "mixed": nightPrice = 20.0; sport = "Swimming"; break;
                        }
                        break;
                    }

            }

            var total = nightPrice * studentsCount * nights;

            if (studentsCount >= 50) total /= 2;
            else if (studentsCount >= 20) total -= total * 0.15;
            else if (studentsCount >= 10) total -= total * 0.05;

            Console.WriteLine($"{sport} {total:f2} lv.");


        }
    }
}
