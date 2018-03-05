using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var ekskurzia = double.Parse(Console.ReadLine());
            var puzzle = int.Parse(Console.ReadLine());
            var doll = int.Parse(Console.ReadLine());
            var bear = int.Parse(Console.ReadLine());
            var minion = int.Parse(Console.ReadLine());
            var truck = int.Parse(Console.ReadLine());

            var numToys = puzzle + doll + bear + minion + truck;
            var sumToys = (puzzle * 2.60) + (doll * 3) + (bear * 4.1) + (minion * 8.2) + (truck * 2);

            double endPrice = 0;

            if (numToys >= 50)
            {
                var discount = sumToys * 0.25;
                endPrice = sumToys - discount;
            }

            else
            {
                endPrice = sumToys;
            }

            var rent = endPrice * 0.1;
            var earnings = endPrice - rent;


            if (earnings >= ekskurzia)
            {
                var left = earnings - ekskurzia;
                Console.WriteLine("Yes! {0:F2} lv left.", left);
            }

            else if (earnings < ekskurzia)
            {
                var needed = ekskurzia - earnings;
                Console.WriteLine("Not enough money! {0:F2} lv needed.", needed);
            }
        }
    }
}
