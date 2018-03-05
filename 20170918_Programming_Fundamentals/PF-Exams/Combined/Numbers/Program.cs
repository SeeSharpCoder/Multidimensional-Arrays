using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            foreach (var element in array)
            {
                sum += element;
            }

            double average = sum / array.Length;

            var outPutList = new List<int>();

            foreach (var element in array)
            {
                if (element > average)
                {
                    outPutList.Add(element);
                }
            }

            var orderdOutPut = outPutList.OrderByDescending(x => x).Take(5).ToList();

            if (orderdOutPut.Count > 0)
            {
                Console.WriteLine(string.Join(" ", orderdOutPut));
            }

            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
