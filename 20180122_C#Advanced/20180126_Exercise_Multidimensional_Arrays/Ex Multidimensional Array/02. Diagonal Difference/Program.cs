using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            var matrix = new int[size][];

            for (int i = 0; i < size; i++)
            {
                matrix[i] = Console.ReadLine()?.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int columns = 0; columns < matrix[rows].Length; columns++)
                {
                    Console.Write($"{matrix[rows][columns]} ");
                }
                Console.WriteLine();
            }
            //printirane na matrica

            //var sum1 = 0;
            //var sum2 = 0;

            //for (int i = 0; i < size; i++)
            //{
            //    sum1 += matrix[i][i];
            //    sum2 += matrix[i][size - 1 - i];
            //}

            //var resut = Math.Abs(sum1 - sum2);
            //Console.WriteLine(resut);
        }
    }
}
