using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            decimal guests = decimal.Parse(Console.ReadLine());
            decimal bananasPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPriceKilo = decimal.Parse(Console.ReadLine());

            decimal sets = Math.Ceiling(guests / 6);
            decimal price = sets * (2 * bananasPrice) + sets * (4 * eggsPrice) + sets * (0.2M * berriesPriceKilo);
            if (cash >= price)
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", price);
            else
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", (price - cash));
        }
    }
}
