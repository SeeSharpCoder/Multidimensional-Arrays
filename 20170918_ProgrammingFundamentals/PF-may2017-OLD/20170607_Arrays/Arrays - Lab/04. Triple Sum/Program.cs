using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool notSumable = true;

            for (int a = 0; a < arr.Length; a++)
            {
                for (int b = a + 1; b < arr.Length; b++)
                {
                    int sum = arr[a] + arr[b];

                    if (arr.Contains(sum))
                    {
                        Console.WriteLine("{0} + {1} == {2}", arr[a], arr[b], sum);
                        notSumable = false;
                    }
                }
            }
            if (notSumable)
            { Console.WriteLine("No"); }


        }
    }
}
