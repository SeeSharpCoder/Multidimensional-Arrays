using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            nums.Sort();
            nums.Reverse();

            var squareNums = new List<int>();

            foreach (var num in nums)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    squareNums.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ", squareNums));
        }
    }
}
