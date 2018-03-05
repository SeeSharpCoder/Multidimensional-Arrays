using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var food = Console.ReadLine();
            if (food == "banana" || food == "kiwi" || food == "apple" || food == "cherry" || food == "lemon" || food == "grapes") Console.WriteLine("fruit");

            else if (food == "tomato" || food == "cucumber" || food == "pepper" || food == "carrot") Console.WriteLine("vegetable");
            else
            { Console.WriteLine("unknown"); }

        }
    }
}
