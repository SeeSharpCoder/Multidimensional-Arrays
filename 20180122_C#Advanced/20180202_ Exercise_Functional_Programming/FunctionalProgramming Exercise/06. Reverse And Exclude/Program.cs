using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var divisor = int.Parse(Console.ReadLine());
            Func<int, bool> filter = n => n % divisor != 0;

            var remainingNumbers = numbers.Reverse().Where(filter);

            Console.WriteLine(string.Join(" ", remainingNumbers));
        }
    }
}
