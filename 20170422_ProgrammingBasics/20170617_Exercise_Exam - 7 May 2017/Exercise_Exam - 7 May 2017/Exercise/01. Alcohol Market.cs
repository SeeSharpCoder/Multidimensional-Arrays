using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var whiskeyPrice = double.Parse(Console.ReadLine());

            var beer = double.Parse(Console.ReadLine());
            var wine = double.Parse(Console.ReadLine());
            var rakia = double.Parse(Console.ReadLine());
            var whiskey = double.Parse(Console.ReadLine());

            var rakiaPrice = whiskeyPrice * 0.5;
            var beerPrice = rakiaPrice - (0.8 * rakiaPrice);
            var winePrice = rakiaPrice - (0.4 * rakiaPrice);

            var totalPrice = (whiskeyPrice * whiskey) + (rakiaPrice * rakia) + (beerPrice * beer) + (winePrice * wine);

            Console.WriteLine("{0:0.00}", totalPrice);
        }
    }
}
