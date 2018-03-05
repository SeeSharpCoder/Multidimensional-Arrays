using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] sumArr = new int[inputArr.Length / 2];

            for (int i = 0; i < inputArr.Length / 4; i++)
            {
                sumArr[i] = inputArr[inputArr.Length / 4 + i] + inputArr[inputArr.Length / 4 - i - 1];
                sumArr[sumArr.Length - 1 - i] = inputArr[inputArr.Length - inputArr.Length / 4 - 1 - i] + inputArr[inputArr.Length - inputArr.Length / 4 + i];
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
