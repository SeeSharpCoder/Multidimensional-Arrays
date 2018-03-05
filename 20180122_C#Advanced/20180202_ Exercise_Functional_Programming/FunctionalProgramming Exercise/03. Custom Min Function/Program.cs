using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
               .Split(new char[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(double.Parse)
               .ToArray();

            Func<double[], double> minFunc = GetMin;

            var minNumber = minFunc(numbers);

            Console.WriteLine(minNumber);
        }

        private static double GetMin(double[] numbers)
        {
            var min = double.MaxValue;

            foreach (var num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
            }

            return min;
        }
    }
}
