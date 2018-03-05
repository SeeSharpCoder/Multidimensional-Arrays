using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_February_2017_Part_I
{
    class Program
    {
        static void Main(string[] args)
        {
            long wingFlaps = long.Parse(Console.ReadLine());
            double move = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double print = wingFlaps / 1000 * move;

            long x = wingFlaps / 100 + wingFlaps / endurance * 5;

            Console.WriteLine("{0:f2} m.", print);
            Console.WriteLine("{0} s.", x);
        }
    }
}
