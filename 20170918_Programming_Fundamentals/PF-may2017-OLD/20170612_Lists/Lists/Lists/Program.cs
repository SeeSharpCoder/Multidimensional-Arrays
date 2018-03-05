using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            input.Reverse();
            var result = new List<int>();
            bool noElements = true;

            for (int i = 0; i < input.Count; i++)
            {
                if(input[i] > 0)
                {
                   result.Add(input[i]);
                    noElements = false;
                }                
            }
            if (noElements)
            {
                Console.WriteLine("empty");
                return;
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
