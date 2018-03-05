using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Matrix_of_Palindromes_Moe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[,] matrix = new int[size[0], size[1]];

            char[] abc = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0}{1}{0} ", new string (abc[rows],1), new string (abc[rows + col],1));
                }
                Console.WriteLine();
            }
        }
    }
}
