using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тръби_в_басейн
{
    class Program
    {
        static void Main(string[] args)
        {
            var volume = int.Parse(Console.ReadLine());
            var pipe1 = int.Parse(Console.ReadLine());
            var pipe2 = int.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());

            var totalWater = pipe1 * hours + pipe2 * hours;

            if (totalWater <= volume)
            {
                var percentageFilled = Math.Truncate(totalWater / volume * 100);
                var percentagePipe1 = Math.Truncate(pipe1 * hours / totalWater * 100);
                var percentagePipe2 = Math.Truncate(pipe2 * hours / totalWater * 100);
                Console.WriteLine($"The pool is {percentageFilled}% full. Pipe 1: {percentagePipe1}%. Pipe 2: {percentagePipe2}%.");
            }

            else
            {
                Console.WriteLine($"For {hours} hours the pool overflows with {totalWater - volume} liters.");
            }
        }
    }
}
