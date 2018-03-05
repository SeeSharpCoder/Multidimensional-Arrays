using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            var stadionCapacity = int.Parse(Console.ReadLine());
            var totalFans = int.Parse(Console.ReadLine());

            double sectorAFans = 0.0;
            double sectorBFans = 0.0;
            double sectorVFans = 0.0;
            double sectorGFans = 0.0;

            for (int i = 0; i < totalFans; i++)
            {
                var fan = Console.ReadLine();
                switch (fan)
                {
                    case "A": sectorAFans++; break;
                    case "B": sectorBFans++; break;
                    case "V": sectorVFans++; break;
                    case "G": sectorGFans++; break;
                }
            }
            var aPercent = sectorAFans / totalFans * 100.0;
            var bPercent = sectorBFans / totalFans * 100.0;
            var vPercent = sectorVFans / totalFans * 100.0;
            var gPercent = sectorGFans / totalFans * 100.0;
            double filledCapacity = (double)totalFans / stadionCapacity * 100;

            Console.WriteLine($"{aPercent:f2}%");
            Console.WriteLine($"{bPercent:f2}%");
            Console.WriteLine($"{vPercent:f2}%");
            Console.WriteLine($"{gPercent:f2}%");
            Console.WriteLine($"{filledCapacity:f2}%");
        }
    }
}
