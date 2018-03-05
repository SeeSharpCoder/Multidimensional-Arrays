using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers_01
{
    class Program
    {
        static void Main(string[] args)
        {
             var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var dict = new SortedDictionary<double, int>();

            foreach (var n in nums)
            {
                if (dict.ContainsKey(n))
                {
                    dict[n]++;
                }
                else
                {
                    dict[n] = 1;
                }
            }
            foreach (var item in dict.Keys)
            {
                Console.WriteLine($"{item} -> {dict[item]}");
            }
        }
    }
}
