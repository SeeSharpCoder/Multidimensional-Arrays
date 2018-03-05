using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();

            if (figure == "square")
            {
                var side1 = double.Parse(Console.ReadLine());
                Console.WriteLine(side1 * side1);
            }

            else if (figure == "rectangle")
            {
                var side1 = double.Parse(Console.ReadLine());
                var side2 = double.Parse(Console.ReadLine());
                Console.WriteLine(side1 * side2);
            }

            else if (figure == "circle")
            {
                var side1 = double.Parse(Console.ReadLine());

                Console.WriteLine(side1 * side1 * 3.14159);
            }

            else if (figure == "triangle")
            {
                var side1 = double.Parse(Console.ReadLine());
                var side2 = double.Parse(Console.ReadLine());
                Console.WriteLine(side1 * side2 / 2);
            }

        }
    }
}
