using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Airline
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfFly = int.Parse(Console.ReadLine());

            decimal overAllPrqofit = 0;
            decimal avergeProfit = 0;

            for (int i = 0; i < numberOfFly; i++)
            {
                int adultPas = int.Parse(Console.ReadLine());
                decimal adultTicketPrice = decimal.Parse(Console.ReadLine());
                int youngPas = int.Parse(Console.ReadLine());
                decimal youngTicketPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPricePerHour = decimal.Parse(Console.ReadLine());
                double fuelLess = double.Parse(Console.ReadLine());
                double duration = double.Parse(Console.ReadLine());

                decimal myIncome = ((adultPas * adultTicketPrice) + (youngPas * youngTicketPrice));
                decimal expenses = (fuelPricePerHour * (decimal)(fuelLess * duration));
                decimal profit = (decimal)(myIncome - expenses);
                overAllPrqofit += profit;
                avergeProfit = overAllPrqofit / numberOfFly;
                if (myIncome >= expenses)
                {
                    Console.WriteLine("You are ahead with {0:f3}$.", profit);
                }
                else
                {
                    Console.WriteLine("We've got to sell more tickets! We've lost {0:f3}$.", profit);
                }
            }
            Console.WriteLine("Overall profit -> {0:f3}$.", overAllPrqofit);
            Console.WriteLine("Average profit -> {0:f3}$.", avergeProfit);
        }
    }
}
