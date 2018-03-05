using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            input.Sort();
            var count = new int[input.Max() +1];
            foreach (var num in input)
            {
                count[num]++;
            }
            for (int i = 0; i < count.Length; i++)
            {
                if(count[i] > 0)
                Console.WriteLine($"{i} -> {count[i]}");
            }
        }
    }
}
