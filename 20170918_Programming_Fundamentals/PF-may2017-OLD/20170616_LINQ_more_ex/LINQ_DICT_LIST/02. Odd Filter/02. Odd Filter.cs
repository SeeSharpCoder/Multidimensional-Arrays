using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = list.Count -1 ; i >= 0; i--)
            {
                if (list[i] % 2 == 1)
                { list.Remove(list[i]);}
            }

            var average = list.Average();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > average) list[i]++;
                else if (list[i] <= average) list[i]--;
            }
            
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
