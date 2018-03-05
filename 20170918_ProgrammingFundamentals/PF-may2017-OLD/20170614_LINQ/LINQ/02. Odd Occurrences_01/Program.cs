using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split(' ').ToArray();

            var dict = new Dictionary<string, int>();

            foreach (var w in words)
            {
                if (dict.ContainsKey(w))
                {
                    dict[w]++;
                }
                else
                {
                    dict[w] = 1;
                }
            }
            bool pass = true;
            foreach (var item in dict)
            {
                if (item.Value % 2 == 1)
                {
                    if (!pass) Console.Write(", ");
                    Console.Write(item.Key);
                    pass = false;
                }
                
            }
            Console.WriteLine();
        }
    }
}
