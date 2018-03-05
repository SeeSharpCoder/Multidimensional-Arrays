using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            long days = long.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            long averageLaps = long.Parse(Console.ReadLine());
            long lengthOfTrack = long.Parse(Console.ReadLine());
            long capacityOfTrack = long.Parse(Console.ReadLine());
            decimal moneyDonatedPerKm = decimal.Parse(Console.ReadLine());

            if (capacityOfTrack * days < runners)
            { runners = capacityOfTrack * days; }

            double totalKM = (runners * averageLaps * lengthOfTrack) / 1000;

            decimal dectotalKM = Convert.ToDecimal(totalKM);

            decimal moneyRaised = dectotalKM * moneyDonatedPerKm;

            Console.WriteLine("Money raised: {0:f2}", moneyRaised);
        }
    }
}
