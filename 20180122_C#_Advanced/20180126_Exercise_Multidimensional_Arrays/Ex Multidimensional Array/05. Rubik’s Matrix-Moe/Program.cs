using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rubik_s_Matrix_Moe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowAndCol = Console.ReadLine()
                          .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(int.Parse)
                          .ToArray();
            int[,] matrix = new int[rowAndCol[0], rowAndCol[1]];
            int commands = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int row = 0; row < rowAndCol[0]; row++)
            {
                for (int col = 0; col < rowAndCol[1]; col++)
                {
                    counter++;
                    matrix[row, col] = counter;
                }
            }
            for (int i = 0; i < commands; i++)
            {
                string[] input = Console.ReadLine()
                                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();
                int rowCol = int.Parse(input[0]);
                int moves = int.Parse(input[2]);


                if ((input[1] == "up" || input[1] == "down") && moves % rowAndCol[0] != 0)
                {
                    int[] tempArray1 = new int[rowAndCol[0]];
                    int[] tempArray2 = new int[rowAndCol[0]];

                    for (int col = rowCol; col <= rowCol; col++)
                    {
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            tempArray1[row] = matrix[row, col];
                        }
                    }

                    if (input[1] == "up")
                    {  
                        Array.Copy(tempArray1, moves % rowAndCol[0], tempArray2, 0, (rowAndCol[0] - moves % rowAndCol[0]));
                        Array.Copy(tempArray1, 0 , tempArray2, (rowAndCol[0] - moves % rowAndCol[0]), moves % rowAndCol[0]);        
                    }
                    else if (input[1] == "down")
                    {
                         Array.Copy(tempArray1,(rowAndCol[0] - moves % rowAndCol[0]), tempArray2, 0, moves % rowAndCol[0]);
                         Array.Copy(tempArray1, 0, tempArray2, moves % rowAndCol[0], (rowAndCol[0] - moves % rowAndCol[0]));
                    }
                    for (int col = rowCol; col <= rowCol; col++)
                    {
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            matrix[row, col] = tempArray2[row];
                        }
                    }

                }
                else if ((input[1] == "right" || input[1] == "left") && moves % rowAndCol[1] != 0)
                {
                    if (input[1] == "right")
                    {
                        int[] tempArray = new int[rowAndCol[1]];
                        int mIndex1 = (rowAndCol[1] - (moves % rowAndCol[1])) * 4 + rowCol * rowAndCol[1] * 4;
                        int tempArrayBitsLenght1 = (moves % rowAndCol[1]) * 4;
                        int mIndex2 = rowCol * rowAndCol[1] * 4;
                        int tempArrayIndexLenght2 = (rowAndCol[1] - (moves % rowAndCol[1])) * 4;

                        //With next BlockCopy strings, we copy a shifted cells in row from matrix to tempArray in bits!!!
                        //BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count);
                        System.Buffer.BlockCopy(matrix, mIndex1, tempArray, 0, tempArrayBitsLenght1);
                        System.Buffer.BlockCopy(matrix, mIndex2, tempArray, tempArrayBitsLenght1, tempArrayIndexLenght2);

                        //With next BlockCopy strings we copy from tempArray to matrix in the needed row in bits!!!
                        System.Buffer.BlockCopy(tempArray, 0, matrix, mIndex2, rowAndCol[1] * 4);
                    }
                    else if (input[1] == "left")
                    {
                        int[] tempArray = new int[rowAndCol[1]];
                        int mIndex1 = ((moves % rowAndCol[1]) * 4) + rowCol * rowAndCol[1] * 4;
                        int tempArrayBitsLenght1 = (rowAndCol[1] - (moves % rowAndCol[1])) * 4;
                        int mIndex2 = rowCol * rowAndCol[1] * 4;
                        int tempArrayIndexLenght2 = (moves % rowAndCol[1]) * 4;

                        System.Buffer.BlockCopy(matrix, mIndex1, tempArray, 0, tempArrayBitsLenght1);
                        System.Buffer.BlockCopy(matrix, mIndex2, tempArray, tempArrayBitsLenght1, tempArrayIndexLenght2);
                        System.Buffer.BlockCopy(tempArray, 0, matrix, mIndex2, rowAndCol[1] * 4);
                    }
                }
            }
            counter = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
               
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    counter++;                    
                    if (matrix[row, col] == counter )
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                if (matrix[i, j] == counter)
                                {
                                    Console.WriteLine($"Swap ({row}, {col}) with ({i}, {j})");
                                    break;
                                }
                            }
                        }
                    }                    
                }
               
            }
        }
    }
}
