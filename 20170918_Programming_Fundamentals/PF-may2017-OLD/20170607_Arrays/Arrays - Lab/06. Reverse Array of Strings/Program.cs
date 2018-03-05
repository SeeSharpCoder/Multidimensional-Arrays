using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(String.Join(" ",Console.ReadLine().Split(' ').ToArray().Reverse()));

            string[] arr = Console.ReadLine().Split(' ').ToArray();
            string[] reversed = new string[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                reversed[i] = arr[arr.Length - i - 1];
            }
            Console.WriteLine(String.Join(" ",reversed));
        }
    }
}
