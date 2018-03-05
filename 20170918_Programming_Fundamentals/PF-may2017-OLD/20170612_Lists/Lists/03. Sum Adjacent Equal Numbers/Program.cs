using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int j = 0; j < input.Count; j++)
            {

                for (int i = 0; i < input.Count - 1; i++)
                {
                    if (input[i] == input[i + 1])
                    {

                        decimal sumed = input[i] + input[i + 1];
                        input.RemoveAt(i);
                        input.RemoveAt(i);
                        input.Insert(i, sumed);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
