using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|').Select(x => x.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(y => y).ToArray()).ToArray();

            for (int i = input.Length - 1; i >= 0; i--)

            {
                Console.Write(string.Join(" ", input[i]) + " ");
            }

            Console.WriteLine();
        }
    }
}
