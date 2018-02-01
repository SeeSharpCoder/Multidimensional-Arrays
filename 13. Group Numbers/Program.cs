using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Group_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //var input = Console.ReadLine()
            //    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();

            //var reminder0 = input.Where(num => Math.Abs(num) % 3 == 0).ToArray();
            //var reminder1 = input.Where(num => Math.Abs(num) % 3 == 1).ToArray();
            //var reminder2 = input.Where(num => Math.Abs(num) % 3 == 2).ToArray();

            //var matrix = new int[3][];
            //matrix[0] = reminder0;
            //matrix[1] = reminder1;
            //matrix[2] = reminder2;

            //foreach (var col in matrix)
            //{
            //    Console.WriteLine(string.Join(" ", col));
            //}

            var numbers = Console.ReadLine()
                         .Split(new string[] { ", " }, StringSplitOptions.None)
                         .Select(int.Parse)
                         .ToArray();

            var sizes = new int[3];
            foreach (var number in numbers)
            {
                sizes[Math.Abs(number % 3)]++;
            }

            int[][] jaggedArray = new int[3][];
            for (int counter = 0; counter < sizes.Length; counter++)
            {
                jaggedArray[counter] = new int[sizes[counter]];
            }

            int[] index = new int[3];
            foreach (var number in numbers)
            {
                var remainder = Math.Abs(number % 3);
                jaggedArray[remainder][index[remainder]] = number;
                index[remainder]++;
            }

            for (int rows = 0; rows < jaggedArray.Length; rows++)
            {
                for (int columns = 0; columns < jaggedArray[rows].Length; columns++)
                {
                    Console.Write(jaggedArray[rows][columns] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
