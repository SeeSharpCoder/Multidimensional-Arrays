using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Diagonal_Difference_Moe
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            var matrix = new int[size, size];
            var primary = 0;
            var secundary = 0;

            for (int rows = 0; rows < size; rows++)
            {
                int[] rowValues = Console.ReadLine()
                                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[rows, col] = rowValues[col];
                }
            }

            for (int i = 0; i < size; i++)
            {
                primary += matrix[i, i];
                secundary += matrix[i, size - 1 - i];
            }

            Console.WriteLine(Math.Abs(primary - secundary));
        }
    }
}
