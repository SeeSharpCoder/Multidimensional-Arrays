using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Squares_in_Matrix_Мое
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowAndCol = Console.ReadLine()
                            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            string[,] matrix = new string[rowAndCol[0], rowAndCol[1]];

            int count = 0;

            for (int row = 0; row < rowAndCol[0]; row++)
            {
                var values = Console.ReadLine()
                            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();
                for (int col = 0; col < values.Length; col++)
                {
                    matrix[row, col] = values[col];
                }

            }

            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
               
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    if (matrix[row, col] == matrix[row, col+1] && matrix[row, col+1]== matrix[row+1, col] &&  matrix[row+1, col]== matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }

            }

            Console.WriteLine(count);
        }
    }
}
